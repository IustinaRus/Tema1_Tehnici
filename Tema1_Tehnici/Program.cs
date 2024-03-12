namespace Tema1_Tehnici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bucatar1 = new Chef(ListaPersonal.Role1, "Grigore", 5, 7, 12, "Nu e gata");
            var bucatar2 = new Chef(ListaPersonal.Role1, "Anastasia", 3, 5, 20, "Nu e gata");
            var bucatar3 = new Chef(ListaPersonal.Role1, "Mirela", 4, 10, 17, "Gata");
            var bucatar4 = new Chef(ListaPersonal.Role1, "Antonio", 5, 6, 12, "Gata");
            var bucatar5 = new Chef(ListaPersonal.Role1, "Marcel", 2, 9, 30, "Nu e gata");

            ListaPersonal.AddChef(bucatar1);
            ListaPersonal.AddChef(bucatar2);
            ListaPersonal.AddChef(bucatar3);
            ListaPersonal.AddChef(bucatar4);
            ListaPersonal.AddChef(bucatar5);

            Console.WriteLine("Sunt in total " + ListaPersonal.Chefs.Count + " bucatari.");

            var ospatar1 = new Ospatar(ListaPersonal.Role2, "Emil", 5, 10, 4, "Food and Drinks");
            var ospatar2 = new Ospatar(ListaPersonal.Role2, "Elena", 3, 8, 5, "Food");
            var ospatar3 = new Ospatar(ListaPersonal.Role2, "Ionel", 4, 12, 2, "Drinks");

            ListaPersonal.AddOspatar(ospatar1);
            ListaPersonal.AddOspatar(ospatar2);
            ListaPersonal.AddOspatar(ospatar3);

            Console.WriteLine("Sunt in total " + ListaPersonal.Ospatari.Count + " ospatari.");

            INotify chefNotif = new NotifBucatar();
            INotify ospNotif = new NotifOspatar();

            for(int i = 0; i<ListaPersonal.Chefs.Count; i++)
            {
                if (ListaPersonal.Chefs[i].Status == "Gata")
                {
                    String dest = ListaPersonal.Chefs[i].Name;
                    chefNotif.Notify("Comanda este gata, ", dest);
                }
            }

            for (int i = 0; i < ListaPersonal.Ospatari.Count; i++)
            {
                if (ListaPersonal.Ospatari[i].Comanda == "Food and Drinks")
                {
                    ListaPersonal.Ospatari[i].isFood(true);
                    Console.WriteLine("Clientul a comandat mancare si bautura");
                }else if (ListaPersonal.Ospatari[i].Comanda == "Food")
                {
                    ListaPersonal.Ospatari[i].isFood(true);
                    Console.WriteLine("Clientul a comandat doar mancare");
                }
                else
                {
                    ListaPersonal.Ospatari[i].isFood(false);
                    Console.WriteLine("Clientul a comandat doar bauturi");
                }

                if (ListaPersonal.Ospatari[i].Food)
                {   
                    String dest = ListaPersonal.Chefs[i].Name;
                    ospNotif.Notify("Aceasta este comanda, ", dest);
                }
                else
                {
                    String dest = ListaPersonal.Ospatari[i].Name;
                    ospNotif.Notify("Aceasta este comanda, ", dest);
                }
            }

            ListaPersonal.RemoveChef("Antonio");
            Console.WriteLine("Sunt in total " + ListaPersonal.Chefs.Count + " bucatari.");

            ListaPersonal.RemoveOspatar("Ionel");
            Console.WriteLine("Sunt in total " + ListaPersonal.Ospatari.Count + " ospatari.");
        }
    }
}
