using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;
using System.Xml.Serialization;

namespace XmlServer
{
    public class Server
    {
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 10002);
            server.Start();

            using (TcpClient socket = server.AcceptTcpClient())
            using (NetworkStream ns = socket.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                XmlSerializer carSerializer = new XmlSerializer(typeof(Car));
                Car carCopy = (Car) carSerializer.Deserialize(sr);
                Console.WriteLine("carCopy: " + carCopy);

                Console.ReadLine();
            }
        }
    }
}
