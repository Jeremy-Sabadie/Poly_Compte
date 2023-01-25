namespace Poly_Compte
{
    internal class CompteCourant : Compte
    {
        private int sold = 0;
        private int Number;
        private int DecouvertAutorise;
        public CompteCourant(int number, Client holder)
             : base(number, holder)
        {
            DecouvertAutorise = 300;
            Number += 1;
            holder = holder;
            sold = 100;
        }

    }
}
