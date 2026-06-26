using decouverte;
using decouverte.liste;

Console.WriteLine("Découvert");

IItem[] item = {
    new Test(),
    new DecouverteString(),
    new MainList()
};

for (int i = 0; i < item.Length; i++)
{
    Console.WriteLine($" {i+1} : {item[i].GetName()}");
}

Console.Write("Choix : ");
int choix = int.Parse(Console.ReadLine());

item[choix-1].Run();
