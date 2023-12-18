﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PatternsClient
{
    internal class RandomIP
    {
        public static IPAddress CreateRandomIP()
        {
            var data = new byte[4];
            new Random().NextBytes(data);
            IPAddress ip = new IPAddress(data);
            return ip;
        }
    }
}
