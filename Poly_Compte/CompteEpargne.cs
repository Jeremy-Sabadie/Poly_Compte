namespace Poly_Compte
{

    internal class CompteEpargne : Compte
    {
        private double TauxInterets = 1.0075d;
        private int MinimalSold { get; set; }
        private decimal Sold { get; set; }
        public CompteEpargne(int number, Client holder, decimal sold, int MinimalSold, double TauxInterets)
            : base(number, holder)
        {
            MinimalSold = 150;
            number = number;
            holder = holder;
            sold = sold;
            TauxInterets = 1.0075d;
        }
        public double CalculerInterets()
        {

            return Convert.ToDouble(Sold) * TauxInterets;
        }
        public double VerserInterets()
        {
            return Convert.ToDouble(Sold) + CalculerInterets();
        }

    }
}
