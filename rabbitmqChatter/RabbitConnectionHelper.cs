using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbitmqChatter
{
    public class RabbitConnectionHelper
    {
        public static string eName = "turkey-exchange-test";
        public static string qName1 = "turkey-ankara-1";
        public static string qName2 = "turkey-adana-2";
        public static string qName3 = "turkey-3";

        public static string rPattern_TurkeyAnkara = "Country.Turkey.Ankara";
        public static string rPattern_TurkeyAdana = "Country.Turkey.Adana";
        public static string rPattern_StartsWithTurkey = "Country.Turkey.*";

        public static IConnection CreateConnection(string strUsername, string strPassword, string strVirtualHost, string strHostname = "localhost")
        {
            var factory = new ConnectionFactory() { HostName = strHostname, VirtualHost = strVirtualHost, UserName = strUsername, Password = strPassword };
            var connection = factory.CreateConnection();
            return connection;
        }
    }
}
