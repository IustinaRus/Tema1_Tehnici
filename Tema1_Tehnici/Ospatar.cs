using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Tehnici
{
    internal class Ospatar : Personal_McRoland_s //aici am folosit mostenirea, unde Ospatar mosteneste clasa Personal_McRoland_s (De unde ia atributele role, name si exp) 
    {
        public Ospatar(string role, string name, int exp, int nrcom, int nrtable, string com) : base(role,name,exp)
        {
            NrComenzii = nrcom;
            NrTable = nrtable;
            Comanda = com;
            Food = false;
        }

        public int NrComenzii { get; set; } 
        //un fel de id al comenzii
        public int NrTable {  get; set; }
        //nr mesei de la care a fost preluata comanda
        public string Comanda {  get; set; }
        //comanda preluata careia ii vom atribui "Food and Drinks",
        // "Food" sau "Drinks" 
        public bool Food {  get; private set; } //incapsulare
        //false daca in comanda preluata nu este niciun fel de mancare
        //tot asa va fi si implicit setat

        public void isFood(bool food)
        {
            Food = food;
        } //daca Food este true, atunci in Program.cs se va face un if
        //prin care comanda va fi trimisa la bucatar
        //daca (,) comanda care a fost preluata nu are
        //niciun fel de mancare (doar bauturi), atunci nu este
        //nevoie ca bucatarul sa primeasca aceasta comanda. 
    }
}
