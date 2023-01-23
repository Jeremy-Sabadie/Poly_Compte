using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_Compte;
{
    internal class Client
    {
    private string _firstName { get; set; }
        private string _Name { get; set; }
    public Client(string firstName, string name)
    {
        Name=name
        FirstName = firstName
    }
        private List<Compte> comptes = new List<Compte>() { get;set; }

    }
}
