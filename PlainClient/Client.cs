using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;

namespace PlainClient
{
    public class Client
    {
        public void Start()
        {
            ModelLib.Car testCar = new Car();
            testCar.Model = "Tesla";
            testCar.Color = "red";
            testCar.RegNo = "EL23400";


            using (TcpClient socket = new TcpClient("localhost", 10001))
            using (NetworkStream ns = socket.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                String sendStr = testCar.ToString();
                sw.WriteLine(sendStr);
                sw.Flush();

                String incommingStr = sr.ReadLine();
                Console.WriteLine("Ekko modtaget: " + incommingStr);

                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
