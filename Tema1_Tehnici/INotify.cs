using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Tehnici
{
    internal interface INotify //interfata facuta pentru notificari
    {
        public void Notify(string content, string dest);
    }
}
