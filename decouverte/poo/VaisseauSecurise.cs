using System;
using System.Collections.Generic;
using System.Text;

namespace decouverte.poo
{
    internal class VaisseauSecurise
    {
        private String nom;
        private int nbMissiles;

        /* constructeur*/
        public VaisseauSecurise(string nom)
        {
            this.nom = nom;
        }

        public String Nom
        {
            get { return this.nom; }
        }
        public int NbMissiles
        {
            get
            {
                Console.WriteLine("appel du getter");
                return nbMissiles;
            }
            set
            {
                Console.WriteLine("appel du setter");
                if (value >= 0)
                {
                    nbMissiles = value;
                }
            }
        }

        public bool EnVol { get; private set; }
        public static int NbEnvol { get; private set; }

        /*
         * private static bool toto;
         * 
         * public static int NbEnvol {
         *  get{return toto;}
         *  private set{toto = value;}
         * }
         * 
         */

        public void Tirer()
        {

            if (this.nbMissiles > 0)
            {
                Console.WriteLine("PAN");
                this.nbMissiles--;
            }
            else
            {
                Console.WriteLine("POUF");
            }
        }

        public void SetNbMissiles(int nbr)
        {
            if (nbr >= 0)
            {
                nbMissiles = nbr;
            }

        }

        internal int GetNbMissiles()
        {
            return nbMissiles;
        }

        public void Decoller()
        {
            if (EnVol)
            {
                Console.WriteLine("je suis déjà en vol!!");
            }
            else
            {
                Console.WriteLine("je décolle");
                EnVol = true;
                NbEnvol++;
            }
        }

        public void Atterrir()
        {
            if (EnVol)
            {
                Console.WriteLine("J'atterris");
                EnVol = false;
                NbEnvol--;
            }
            else
            {
                Console.WriteLine("je suis déjà au sol!!");
            }
        }

    }
}
