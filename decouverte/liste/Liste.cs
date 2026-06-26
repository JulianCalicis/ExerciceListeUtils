using System;
using System.Collections.Generic;
using System.Text;

namespace decouverte.liste
{
    internal class Liste
    {
        public int val;
        public Liste suivant;
    }

    internal class MainList : IItem
    {
        public string GetName()
        {
            return "Manipulation de liste";
        }

        public void Run()
        {
            Liste? liste = null;
            ListeUtil.Push(ref liste, 10);
            ListeUtil.Push(ref liste, 9);
            ListeUtil.Push(ref liste, 8);
            ListeUtil.Push(ref liste, 7);

            ListeUtil.PrintListe(liste);
        }
    }

    internal class ListeUtil
    {
        public static void PrintListe(Liste l)
        {
            Console.Write('[');
            while(l != null)
            {
                Console.Write(l.val);
                if(l.suivant != null)
                {
                    Console.Write(", ");
                }
                l = l.suivant;
            }
            Console.Write(']');
        }

        internal static void Push( ref Liste? liste, int val)
        {
            Liste nouv = new Liste();
            nouv.val = val;
            nouv.suivant = liste;
            liste = nouv;
        }
    }
}
