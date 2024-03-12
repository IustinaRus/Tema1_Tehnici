using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Tehnici
{
    internal abstract class Personal_McRoland_s  //abstractizare
    {
        public Personal_McRoland_s(string role, string name, int exp)
        {
            Role = role;  //daca avem un ospatar sau un chef
            Name = name;  //numele personalului nostru
            Exp = exp;    
        }

        public string Role {  get; set; }
        public string Name { get; set; }
        public int Exp {  get; set; }
        //care va fi un numar de la 1 la 5, unde 5 este 
        //nivelul maxim de experienta

    }
}
