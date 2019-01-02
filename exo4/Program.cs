using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> shopping = new List<String>()
            { "Carotte", "Oignon", "Pomme de terre", "Salade", "Tomate"};
            foreach (String product in shopping)
                Console.WriteLine(product);
        }
    }
}
