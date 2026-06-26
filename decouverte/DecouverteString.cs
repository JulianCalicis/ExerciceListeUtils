using System;
using System.Collections.Generic;
using System.Text;

namespace decouverte
{
    internal class DecouverteString : IItem
    {
        public string GetName()
        {
            return "Découverte des strings";
        }

        public void Run()
        {
            string standard = "string \"standard\"";
            string verbatime = @"c:\test\\""louis"" ";
            String raw = $$"""

                premier texte 
                "{{standard}}"

                Deuxième texte : 
                "{{verbatime}}"
          """;

            Console.WriteLine(standard);
            Console.WriteLine(verbatime);
            Console.WriteLine(raw);
        }
    }
}
