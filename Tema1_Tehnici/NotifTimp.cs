using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Tehnici
{
    internal class NotifTimp : INotify
    {
        public void Notify(string content, string dest)  //urmeaza a fi implementata si ideea asta
        {
            Console.WriteLine("Ai terminat nr de comenzi pe astazi. Poti pleca acasa!" + dest);
        }
    }
}
