﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFTPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "1 ";
            var data = Client.SendRequest(command).Result;
        }
    }
}
