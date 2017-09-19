using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlainServer__and_XML_and_JSON_
{
    public class Server
    {
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 10001);
            server.Start();

            using (TcpClient socket = server.AcceptTcpClient())
            using (NetworkStream ns = socket.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                String carString = sr.ReadLine();
                sw.WriteLine(carString);


                int countWords = carString.Split(' ').Length;


                Console.WriteLine("Besked fra client modtaget: " + carString + " Antal ord modtaget: " + countWords);


                sw.Flush();

                Console.ReadLine();
            }


            Console.ReadLine();
        }
    }
}
