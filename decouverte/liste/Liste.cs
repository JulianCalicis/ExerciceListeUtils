using System;
using System.Collections.Generic;
using System.Text;

namespace decouverte.liste
{
    internal class Liste
    {
        public int val;
        public Liste? suivant;
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
            Console.WriteLine(ListeUtil.Size(liste));
            ListeUtil.Add(ref liste, 10);
            ListeUtil.Push(ref liste, 9);
            ListeUtil.Push(ref liste, 8);
            ListeUtil.Push(ref liste, 7);

            Console.WriteLine(ListeUtil.Peek(liste));

            ListeUtil.PrintListe(liste);

            Console.WriteLine(ListeUtil.Pop(ref liste));

            ListeUtil.PrintListe(liste);

            ListeUtil.Add(ref liste, 15);

            Console.WriteLine($"read(l,2): {ListeUtil.Read(liste, 2)}");

            ListeUtil.Insert(ref liste, 2, 100);


            Console.WriteLine(ListeUtil.Size(liste));

            ListeUtil.PrintListe(liste);

            Console.WriteLine($"remove(l) : {ListeUtil.Remove(ref liste)}");

            ListeUtil.PrintListe(liste);

            Console.WriteLine($"removeAt(l,2) : {ListeUtil.RemoveAt(ref liste, 2)}");

            ListeUtil.PrintListe(liste);

            Console.WriteLine($"removeAt(l,2) : {ListeUtil.RemoveAt(ref liste, 2)}");

            ListeUtil.PrintListe(liste);



        }
    }

    internal class ListeUtil
    {
        public static void PrintListe(Liste? l)
        {
            Console.Write('[');
            while (l != null)
            {
                Console.Write(l.val);
                if (l.suivant != null)
                {
                    Console.Write(", ");
                }
                l = l.suivant;
            }
            Console.Write("]\n");
        }

        internal static void Add(ref Liste? liste, int valeur)
        {
            int size = 0;
            if (liste == null)
            {
                Push(ref liste, valeur);
            }
            else
            {
                Liste temp = liste;
                while (temp.suivant != null)
                {
                    size++;
                    temp = temp.suivant;
                }
                temp.suivant = new Liste();
                temp = temp.suivant;
                temp.val = valeur;
                temp.suivant = null;
            }

        }

        internal static void Insert(ref Liste? liste, int pos, int valeur)
        {
            if (pos == 0)
            {
                Push(ref liste, valeur);
            }
            else
            {
                Liste? temp = liste;
                for (int p = 0; p < pos - 1; p++)
                {
                    temp = temp.suivant;
                }

                Push(ref temp.suivant, valeur);
                /*
                Liste nouv = new Liste();
                nouv.val = valeur;
                nouv.suivant = temp.suivant;
                temp.suivant = nouv;
                */
            }
        }

        internal static int Peek(Liste? liste)
        {
            return liste.val;
        }

        internal static int Pop(ref Liste? liste)
        {
            int result = ListeUtil.Peek(liste);
            liste = liste.suivant;
            return result;
        }

        internal static void Push(ref Liste? liste, int val)
        {
            Liste nouv = new Liste();
            nouv.val = val;
            nouv.suivant = liste;
            liste = nouv;
        }

        internal static int Read(Liste? liste, int pos)
        {
            for (int p = 0; p < pos; p++)
            {
                liste = liste.suivant;
            }
            return liste.val;
        }

        internal static int Remove(ref Liste? liste)
        {
            Liste temp = liste;
            int result = 0;
            if (temp.suivant == null)
            {
                result = Pop(ref liste);
            }
            else
            {
                while (temp.suivant.suivant != null)
                {
                    temp = temp.suivant;
                }
                result = temp.suivant.val;
                temp.suivant = null;
            }

            return result;
        }

        internal static int RemoveAt(ref Liste? liste, int pos)
        {
            int removed = 0;
            if (pos == 0)
            {
                removed = Pop(ref liste);
            }
            else
            {
                Liste? temp = liste;
                for (int p = 0; p < pos - 1; p++)
                {
                    temp = temp.suivant;
                }
                removed = temp.suivant.val;
                temp.suivant = temp.suivant.suivant;
            }
            return removed;

        }

        internal static int Size(Liste? liste)
        {
            int size = 0;
            while (liste != null)
            {
                size++;
                liste = liste.suivant;
            }
            return size;
        }
    }
}
