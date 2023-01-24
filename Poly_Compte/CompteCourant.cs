namespace Poly_Compte
{
    internal class CompteCourant : Compte
    {
        private int DecouvertAutorise;
        public CompteCourant(int number, Client holder, decimal sold, int DecouvertAutorise)
             : base(number, holder, sold)
        {
            DecouvertAutorise = 300;
            number = number;
            holder = holder;
            sold = sold;
        }

    }
}
