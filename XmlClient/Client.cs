using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModelLib;

namespace XmlClient
{
    public class Client
    {
        public void Start()
        {
            ModelLib.Car testCar = new Car();
           
            testCar.Model = "Tesla";
            testCar.Color = "blue";
            testCar.RegNo = "XMLCar23";



            using (TcpClient socket = new TcpClient("localhost", 10002))
            using (NetworkStream ns = socket.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {

                XmlSerializer carSerializer = new XmlSerializer(typeof(Car));
                carSerializer.Serialize(sw, testCar);
                sw.Flush();

                Console.WriteLine("Sender: "+testCar);
            }


            Console.ReadLine();
        }
    }
}
