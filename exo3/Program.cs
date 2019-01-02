using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] week = new String[7] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche" };
            int i = Array.IndexOf(week, "Jeudi"); //IndexOf permet de retrouver l'indice d'un élément dans un tableau, renvoi -1 si l'élément n'existe pas.
            week[i + 1] = "Vendredi";
            foreach (String day in week)
                Console.WriteLine(day);
        }
    }
}
