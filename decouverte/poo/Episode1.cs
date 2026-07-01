using System;
using System.Collections.Generic;
using System.Text;

namespace decouverte.poo
{
    internal class Episode1 : IItem
    {
        public string GetName()
        {
            return "Starwars Episode 1";
        }

        public void Run()
        {
            Vaisseau v1 = new Vaisseau();
            Vaisseau v2 = new Vaisseau();


            // initialiser les vaiseaux
            v1.nom = "Millenium";
            v2.nom = "Xwing";

            v1.nbMissiles = 4;
            v2.nbMissiles = -8;


            Console.WriteLine($"le vaisseau {v1.nom} tire");
            v1.Tirer();
            Console.WriteLine($"le vaisseau {v2.nom} tire");
            v2.Tirer();
            Console.WriteLine($"le vaisseau {v1.nom} tire");
            v1.Tirer();
            Console.WriteLine($"le vaisseau {v2.nom} tire");
            v2.Tirer();
            Console.WriteLine($"le vaisseau {v1.nom} tire");
            v1.Tirer();
            Console.WriteLine($"le vaisseau {v2.nom} tire");
            v2.Tirer();
            Console.WriteLine($"le vaisseau {v1.nom} tire");
            v1.Tirer();
            Console.WriteLine($"le vaisseau {v2.nom} tire");
            v2.Tirer();
            Console.WriteLine($"le vaisseau {v1.nom} tire");
            v1.Tirer();
            Console.WriteLine($"le vaisseau {v2.nom} tire");
            v2.Tirer();
        }
    }
}
