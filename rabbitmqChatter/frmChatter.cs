using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rabbitmqChatter
{
    public partial class frmChatter : Form
    {
        IConnection conProducer, conConsumer;
        IModel channelProducer, channelConsumer;
        private string strUserName;
        private string strPassword;
        private string strVirtualHost;
        private string strHostName;

        public frmChatter()
        {
            InitializeComponent();
        }

        private void frmChatter_Load(object sender, EventArgs e)
        {

        }

        private void btnSucscribe_Click(object sender, EventArgs e)
        {
            try
            {
                strUserName = cmbNames.Text;
                strPassword = txtPassword.Text;
                strVirtualHost = txtVirtualHost.Text;
                strHostName = "127.0.0.1";

                Task.Factory.StartNew(new Action(() => Producer())).Wait();
                Task.Factory.StartNew(new Action(() => Consumer())).Wait();

                btnSucscribe.Enabled = false;
                btnUnSubscribe.Enabled = true;
                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                channelProducer.Close();
                channelProducer.Dispose();
                conProducer.Close();

                channelConsumer.Close();
                channelConsumer.Dispose();
                conConsumer.Close();

                btnSucscribe.Enabled = true;
                btnUnSubscribe.Enabled = false;
                btnSend.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var body = Encoding.UTF8.GetBytes(txtMsg.Text);

                channelProducer.BasicPublish(exchange: RabbitConnectionHelper.eName,
                                     routingKey: cmbRoutingKey.Text,
                                     basicProperties: null,
                                     body: body);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Consumer()
        {
            try
            {
                #region c1
                conConsumer = RabbitConnectionHelper.CreateConnection(strUserName, strPassword, strVirtualHost, strHostName);
                channelConsumer = conConsumer.CreateModel();

                var consumer = new EventingBasicConsumer(channelConsumer);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    txtStatus.BeginInvoke(new Action(() => txtStatus.AppendText(RabbitConnectionHelper.qName1 + " " + message + Environment.NewLine)));
                };

                channelConsumer.BasicConsume(queue: RabbitConnectionHelper.qName1,
                                     autoAck: true,
                                     consumer: consumer);

                #endregion

                #region c2
                conConsumer = RabbitConnectionHelper.CreateConnection(strUserName, strPassword, strVirtualHost, strHostName);
                channelConsumer = conConsumer.CreateModel();

                consumer = new EventingBasicConsumer(channelConsumer);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    txtStatus.BeginInvoke(new Action(() => txtStatus.AppendText(RabbitConnectionHelper.qName2 + " " + message + Environment.NewLine)));
                };

                channelConsumer.BasicConsume(queue: RabbitConnectionHelper.qName2,
                                     autoAck: true,
                                     consumer: consumer);

                #endregion

                #region c3
                conConsumer = RabbitConnectionHelper.CreateConnection(strUserName, strPassword, strVirtualHost, strHostName);
                channelConsumer = conConsumer.CreateModel();

                consumer = new EventingBasicConsumer(channelConsumer);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    txtStatus.BeginInvoke(new Action(() => txtStatus.AppendText(RabbitConnectionHelper.qName3 + " " + message + Environment.NewLine)));
                };

                channelConsumer.BasicConsume(queue: RabbitConnectionHelper.qName3,
                                     autoAck: true,
                                     consumer: consumer);

                #endregion
            }
            catch (Exception ex)
            {
                txtStatus.BeginInvoke(new Action(() => txtStatus.AppendText(ex.Message + Environment.NewLine)));
            }
        }

        public void Producer()
        {
            try
            {
                conProducer = RabbitConnectionHelper.CreateConnection(strUserName, strPassword, strVirtualHost, strHostName);
                channelProducer = conProducer.CreateModel();

                channelProducer.ExchangeDeclare(RabbitConnectionHelper.eName, ExchangeType.Topic, true);

                channelProducer.QueueDeclare(RabbitConnectionHelper.qName1, true, false, true, null);
                channelProducer.QueueBind(RabbitConnectionHelper.qName1, RabbitConnectionHelper.eName, RabbitConnectionHelper.rPattern_TurkeyAnkara);

                channelProducer.QueueDeclare(RabbitConnectionHelper.qName2, true, false, true, null);
                channelProducer.QueueBind(RabbitConnectionHelper.qName2, RabbitConnectionHelper.eName, RabbitConnectionHelper.rPattern_TurkeyAdana);

                channelProducer.QueueDeclare(RabbitConnectionHelper.qName3, true, false, true, null);
                channelProducer.QueueBind(RabbitConnectionHelper.qName3, RabbitConnectionHelper.eName, RabbitConnectionHelper.rPattern_StartsWithTurkey);
            }
            catch (Exception ex)
            {
                txtStatus.BeginInvoke(new Action(() => txtStatus.AppendText(ex.Message + Environment.NewLine)));
            }
        }
    }
}
