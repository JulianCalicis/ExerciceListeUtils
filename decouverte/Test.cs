using System;
using System.Collections.Generic;
using System.Text;

namespace decouverte
{
    internal class Test : IItem
    {
        public string GetName()
        {
            return "Petit test";
        }

        public void Run()
        {
            Console.WriteLine("exécution de test");
        }
    }
}
