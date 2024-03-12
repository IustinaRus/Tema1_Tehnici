using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Tehnici
{
    internal class Chef : Personal_McRoland_s //aici am folosit mostenirea, unde Chef mosteneste clasa Personal_McRoland_s (De unde ia atributele role, name si exp) 
    {
        public Chef(string role, string name, int exp, int nrcom, int timp, string status) : base(role, name, exp)
        {
            Cooked = false;
            NrComenzi = nrcom;
            TimpGatire = timp;
            Status = status;
        }

        public int NrComenzi { get; set; } 
        //numarul de comenzi pe care le are de preparat in total
        public int TimpGatire {  get; set; } 
        //unde va fi trecut numarul de minute de care are nevoie
        //bucatarul pentru a prepara o comanda in general 
        //si care va fi alocat in functie de experienta bucatarului
        public string Status {  get; set; }
        //vom atribui "Gata" daca bucatarul a terminat de gatit
        //"Nu e gata" daca bucatarul nu a terminat 
        public bool Cooked {  get; private set; } // incapsulare
        //true daca comanda este gata si false daca comanda inca e in decurs de gatire
        //implicit o sa fie setat ca fiind false 
        //aceasta este o variabila care e folosita pentru a
        //anunta ospatarul ca (,) comanda poate fi preluata si dusa
        //la client


        public void isCooked(bool cooked)
        {
            Cooked = cooked;
        } //aici as vrea sa adaug faptul ca daca statusul comenzii este
          //"Gata" atunci lui Cooked ii vom atribui valoarea true
          //si as mai putea adauga un atribut care numara toate comenzile 
          //care au fost terminate 
          //Atunci cand acest numar de comenzi terminate este egal cu
          //NrComenzi, atunci Status se poate schimba cu 
          //"Bucatarul a terminat toate comenzile".
          //Atunci cand Status primeste aceasta valoare, in Program.cs
          //se poate face un if prin care bucatarul care a terminat
          //toate comenzile primeste o notificare ca si-a terminat 
          //tura si poate pleca acasa. 
    }
    
}
