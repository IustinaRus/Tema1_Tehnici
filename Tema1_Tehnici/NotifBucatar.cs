﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Tehnici
{
    internal class NotifBucatar : INotify
    {
        public void Notify(string content, string dest)   //aici am folosit polimorfismul; am implementat metoda Notify din interfata INotify
        {
            Console.WriteLine("Comanda este gata" + dest);
        }
    }
}
