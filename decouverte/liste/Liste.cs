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

      Console.WriteLine(ListeUtil.Read(liste, 2));

      ListeUtil.PrintListe(liste);
      ListeUtil.Insert(ref liste, 0, 909);
      ListeUtil.PrintListe(liste);

      ListeUtil.Remove(ref liste);
      ListeUtil.PrintListe(liste);
      //ListeUtil.Remove(ref liste);
      //ListeUtil.PrintListe(liste);
      //ListeUtil.Remove(ref liste);
      //ListeUtil.PrintListe(liste);
      //ListeUtil.Remove(ref liste);
      //ListeUtil.PrintListe(liste);
      //ListeUtil.Remove(ref liste);
      //ListeUtil.PrintListe(liste);

      ListeUtil.RemoveAt(ref liste, 4);
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
      Console.WriteLine(']');
    }

    internal static void Push(ref Liste? liste, int val)
    {
      Liste nouv = new()
      {
        val = val,
        suivant = liste
      };
      liste = nouv;
    }

    internal static Liste Push(Liste? liste, int val)
    {
      Liste nouv = new()
      {
        val = val,
        suivant = liste
      };

      return nouv;
    }
    internal static int Peek(Liste? liste)
    {
      int ret;
      if (liste != null)
        ret = liste.val;
      else
        throw new ArgumentNullException(nameof(liste));
      return ret;
    }
    internal static int Pop(ref Liste? liste)
    {
      if (liste != null)
      {
        //Liste anc = liste;
        int valeurRetirée = liste.val;
        //liste = new Liste();
        //liste.val = liste.suivant.val;
        liste = liste.suivant;

        return valeurRetirée;
      }
      else throw new ArgumentNullException(nameof(liste));
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
    internal static int Read(Liste? liste, int pos)
    {
      Liste current;
      ArgumentOutOfRangeException.ThrowIfNegative(pos);
      if (liste != null)
      {
        current = liste;
        while (current.suivant != null && pos > 0)
        {
          current = current.suivant;
          pos--;
        }
      }
      else throw new ArgumentNullException(nameof(liste));
      if (pos > 0)
      {
        throw new IndexOutOfRangeException();
      }
      return current.val;
    }
    internal static void Insert(ref Liste? liste, int pos, int val)
    {
      //Gérer les cas: première position, dernière position, dépassement
      if (liste != null && pos > 0)
      {
        Liste current = liste;
        while (current.suivant != null && pos > 1)
        //1 pour ajouter à la position pos
        //0 pour ajouter après l'élément de position pos
        {
          current = current.suivant;
          pos--;
        }
        Liste tmp = new()
        {
          val = val,
          suivant = current.suivant
        };
        current.suivant = tmp;
      }
      else
      {
        Push(ref liste, val);
      }
    }
    internal static int Remove(ref Liste? liste)
    {
      int retiré;
      if (liste != null)
      {
        Liste current = liste;
        if (current.suivant != null)
        {
          while (current.suivant != null && current.suivant.suivant != null)
          {
            current = current.suivant;
          }
          retiré = current.suivant.val;
          current.suivant = null;
        }
        else
        {
          // équivalent au Pop
          retiré = liste.val;
          liste = null;
        }
      }
      else throw new NullReferenceException();
      return retiré;
    }
    internal static int RemoveAt(ref Liste? liste, int pos)
    {
      int retiré;
      if (liste != null && pos > 0)
      {
        Liste current = liste;
        if (current.suivant != null)
        {
          while (current.suivant.suivant != null && pos > 1)//Si ça dépasse, le dernier est retiré, fallait pas jouer au con, utilisateur
          {
            current = current.suivant;
            pos--;
          }
          retiré = current.suivant.val;
          current.suivant = current.suivant.suivant;

        }
        else
        {
          retiré = liste.val;
          liste = null;
        }
      }
      else retiré = Pop(ref liste);
      return retiré;
    }

  }
}
