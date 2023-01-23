namespace Poly_Compte
{
    internal class Compte
    {


        private int number { get; set; }
        private Client holder { get; set; }
        private DateTime creationDate { get; set; }
        private float sold { get; set; }
        public Compte(int number, Client holder, DateTime creationDate, float sold)
        {
            this.number = number;
            this.holder = holder;
            this.creationDate = creationDate;
            this.sold = sold;
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
        }
    }
}
