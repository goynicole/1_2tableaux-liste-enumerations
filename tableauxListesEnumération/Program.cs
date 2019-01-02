using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableauxListesEnumération
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] week = new String[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            foreach (String Day in week)
            Console.WriteLine(Day);
            Console.ReadKey();
        }
    }
}
