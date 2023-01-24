namespace Poly_Compte;

internal class Compte
{


    private static Guid Number { get; set; }
    private Client holder { get; set; }
    private DateTime creationDate { get; set; }
    private decimal sold { get; set; }
    public Compte(int number, Client holder, decimal sold)
    {
        Number = Guid.NewGuid();
        this.holder = holder;
        this.creationDate = DateTime.Now;
        this.sold = 0;
        Console.WriteLine($"compte n°: {number}");
        Console.WriteLine($"Appartient à:{holder}");


    }
    public decimal addMoney(decimal mount)
    {
        sold = sold + mount;
        return sold;
    }
    public decimal removeMoney(decimal mount)
    {
        sold = sold - mount;
        return sold;
    }
    public void soldPrint()
    {
        Console.WriteLine($"Le solde du compten°: {Number} est de:{sold}$");
    }
    public void infoPrint()
    {
        Console.WriteLine($"Numéro du compte:{Number}.");
        Console.WriteLine($"Titulaire ducompte:{holder}.");
        Console.WriteLine($"Date d'ouverture:{creationDate}.");
        Console.WriteLine($"Solde actuel du compte:{sold}.");
    }
}


