using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo8
{
    class Program
    {
        enum week
        {
            Lundi = 1, // la valeur de lundi devien 1
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Enum.GetName(typeof(week), 4));// affiche Jeudi
            // tableau pour le changement de valeur de base 0 à 1
        }
    }
}
