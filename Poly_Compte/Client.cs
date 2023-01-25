namespace Poly_Compte;


internal class Client
{
    private string Name { get; set; }
    private string firstName { get; set; }
    public List<Compte> comptes = new List<Compte>();

    public Client(string name, string firstName)
    {
        this.Name = name;
        this.firstName = firstName;
    }/// <summary>
     /// Méthode qui affiche le contenu de la liste des comptes du client.
     /// </summary>
    public void printComptList()
    {
        foreach (Compte Compte in comptes)
        {
            Console.WriteLine(Compte);
        }
    }
    /// <summary>
    /// Méthode pour ajouter le compte à la liste du client.
    /// </summary>
    /// <param name="compte"></param>
    public void addToClientList(Compte compte)
    {
        comptes.Add(compte);
    }

    public override string? ToString()
    {
        return $"{Name}";
    }
}









