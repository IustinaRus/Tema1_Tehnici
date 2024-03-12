using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Tehnici
{
    internal static class ListaPersonal  //baza de date cu angajati a restaurantului McRoland's
    {
        public static string Role1 = "Ospatar";
        public static string Role2 = "Bucatar";

        public static List<Chef> Chefs = new List<Chef>(); //lista bucatari
        public static List<Ospatar> Ospatari = new List<Ospatar>();  //lista ospatari


        //urmeaza doua functii care adauga in lista de bucatari/ospatari (adica angajati) doar persoanele care indeplinesc un anumit standard
        //cand vine vorba de experienta
        public static void AddChef(Chef chef)
        {
            if (Chefs.Contains(chef))
            {
                Console.WriteLine("Acest Chef deja exista");
            }else if(chef.Exp < 3)
            {
                Console.WriteLine("Acest Chef are un exp prea mic pentru a fi angajat");
            }
            else
            {
                Chefs.Add(chef);
                Console.WriteLine("Acest Chef a fost adaugat in lista cu angajati");
            }
        }

        public static void AddOspatar(Ospatar ospatar)
        {
            if (Ospatari.Contains(ospatar))
            {
                Console.WriteLine("Acest Chef deja exista");
            }
            else if (ospatar.Exp < 3)
            {
                Console.WriteLine("Acest Chef are un exp prea mic pentru a fi angajat");
            }
            else
            {
                Ospatari.Add(ospatar);
                Console.WriteLine("Acest Chef a fost adaugat in lista cu angajati");
            }
        }


        //urmatoarele doua functii sunt folosite pentru a concedia angajati in functie de numele persoanei pe care dorim
        //sa o dam afara 

        public static void RemoveChef(string name)
        {
            var chef = Chefs.SingleOrDefault(x => x.Name == name);
            if (chef != null)
            {
                Chefs.Remove(chef);
                Console.WriteLine("Cheful acesta a fost concediat.");
            }
        }

        public static void RemoveOspatar(string name)
        {
            var ospatar = Ospatari.SingleOrDefault(x => x.Name == name);
            if (ospatar != null)
            {
                Ospatari.Remove(ospatar);
                Console.WriteLine("Ospatarul acesta a fost concediat.");
            }
        }
    }
}
