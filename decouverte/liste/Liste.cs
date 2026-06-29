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
      Console.WriteLine(ListeUtil.Size(liste));

      ListeUtil.PrintListe(liste);

      ListeUtil.PrintListe(ListeUtil.Push(ListeUtil.Push(ListeUtil.Push(ListeUtil.Push(liste, 6), 5), 4), 3));

      Console.WriteLine(ListeUtil.Pop(ref liste));

      ListeUtil.PrintListe(liste);

      ListeUtil.Add(ref liste, 11);
      ListeUtil.PrintListe(liste);
    }
  }
  internal class ListeUtil
  {
    public static void PrintListe(Liste l)
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
      Console.WriteLine(']');
    }

    internal static void Push(ref Liste? liste, int val)
    {
      Liste nouv = new Liste();
      nouv.val = val;
      nouv.suivant = liste;
      liste = nouv;
    }

    internal static Liste Push(Liste? liste, int val)
    {
      Liste nouv = new Liste();
      nouv.val = val;
      nouv.suivant = liste;

      return nouv;
    }
    internal static int Pop(ref Liste? liste)
    {
      Liste anc = liste;
      int valeurRetirée = liste.val;
      liste = new Liste();
      liste.val = anc.suivant.val;
      liste.suivant = anc.suivant.suivant;

      return valeurRetirée;
    }
    internal static int Size(Liste? liste)
    {
      Liste? current = liste; //Mettre le pointeur à la surface
      int sizeOfList = 0;
      while (current != null)
      {
        sizeOfList++;
        current = current.suivant;
      }
      return sizeOfList;
    }
    internal static void Add(ref Liste? liste, int val)
    {
      if (liste != null)
      {
        Liste? current = liste;
        while (current.suivant != null)
        {
          current = current.suivant;
        }
        current.suivant = new Liste()
        {
          val = val
        };
      }
      else
      {
        liste = new Liste()
        {
          val = val
        };
      }
    }
  }
}
