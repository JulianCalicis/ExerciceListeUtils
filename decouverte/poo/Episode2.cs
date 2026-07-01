using System;
using System.Collections.Generic;
using System.Text;

namespace decouverte.poo
{
    internal class Episode2 : IItem
    {
        public string GetName()
        {
            return "Construction de vaiseau sécurisé";
        }

        public void Run()
        {
            VaisseauSecurise v1 = new VaisseauSecurise("Millénium");
          
            v1.SetNbMissiles(3);
            v1.NbMissiles = 4;

            Console.WriteLine($"il reste {v1.NbMissiles} missilles au vaisseau {v1.Nom}");
            v1.Tirer();
            v1.Tirer();
            v1.Tirer();
            v1.Tirer();
            v1.Tirer();

            VaisseauSecurise v2 = new VaisseauSecurise("Xwing-1");
            VaisseauSecurise v3 = new VaisseauSecurise("Xwing-2");
            v2.Decoller();
            Console.WriteLine($"{v2.Nom} est {(v2.EnVol ? "en vol" : "au sol")}");
            v2.Decoller();
            Console.WriteLine($"{v2.Nom} est {(v2.EnVol ? "en vol" : "au sol")}");
            v3.Decoller();
            Console.WriteLine($"{v3.Nom} est {(v3.EnVol ? "en vol" : "au sol")}");
            v3.Atterrir();
            Console.WriteLine($"{v3.Nom} est {(v3.EnVol ? "en vol" : "au sol")}");
            v3.Atterrir();
            Console.WriteLine($"{v3.Nom} est {(v3.EnVol ? "en vol" : "au sol")}");

            Console.WriteLine($" il y a {VaisseauSecurise.NbEnvol} vaiseau(x) en vol");

        }
    }
}
