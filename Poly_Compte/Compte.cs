namespace Poly_Compte
{
    internal class Compte
    {


        private int number { get; set; }
        private Client holder { get; set; }
        private DateTime creationDate { get; set; }
        private float sold { get; set; }
        public Compte(int number, Client holder, float sold)
        {
            this.number = number;
            this.holder = holder;
            this.creationDate = DateTime.Now;
            this.sold = sold;
            Console.WriteLine($"compte n°: {number}");
            Console.WriteLine($"Appartient à:{holder}");
            holder.comptes.add(Compte)
        }
            public float addMoney(float mount)
            {
                sold = sold + mount;
                return sold;
            }
            public float removeMoney(float mount)
            {
                sold = sold - mount;
                return sold;
            }
            public void soldPrint()
            {
                Console.WriteLine($"Le solde du compten°: {number} est de:{sold}$");
            }
        public void infoPrint()
        {
            Console.WriteLine($"Numéro du compte:{number}.");
            Console.WriteLine($"Titulaire ducompte:{holder}.");
            Console.WriteLine($"Date d'ouverture:{creationDate}.");
            Console.WriteLine($"Solde actuel du compte:{sold}.");
        }
        }
    }
}
