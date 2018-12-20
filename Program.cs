using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            int counter;
            for (counter = 0; counter < week.Length; counter++) //week.Length nous donne le nombre d'éléments contenu dans le tableau week
            {
                Console.WriteLine(week[counter]);
            }

            /*
            while (counter < week.Length)
            {
                Console.WriteLine(week[counter]);
                counter++;
            }*/
        }
    }
}
