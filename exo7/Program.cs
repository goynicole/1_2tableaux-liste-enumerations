using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7
{
    class Program
    {
        enum Week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {
            // pour afficher tout les jours  Enum.GetNames(typeof(Week))=> renvoie un tableau d'ou l'utilisation du foreach
            foreach (string day in Enum.GetNames(typeof(Week)))
            {
                Console.WriteLine(day);
            }
             //pour mettre à la ligne = ("\n")
            Console.WriteLine(Enum.GetName(typeof(Week),4));
            // pour afficher la valeur en position 4
            }
    }
}
