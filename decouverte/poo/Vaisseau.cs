namespace decouverte.poo
{
    internal class Vaisseau
    {
        public String nom;
        public int nbMissiles;


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
    }
}