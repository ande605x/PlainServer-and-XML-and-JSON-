﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlainServer__and_XML_and_JSON_
{
    class Program
    {
        static void Main(string[] args)
        {
            Server s = new Server();
            s.Start();
        }
    }
}
