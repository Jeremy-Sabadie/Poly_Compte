namespace Poly_Compte;


internal class Client
{
    private string Name { get; set; }
    private string firstName { get; set; }
    private List<Compte> comptes = new List<Compte>();

    public Client(string name, string firstName)
    {
        this.Name = name;
        this.firstName = firstName;
    }
}








