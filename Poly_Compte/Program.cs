using Poly_Compte;
Client cC1 = new Client("John", "Doe");
Compte Cpt1 = new Compte(358, cC1);
Console.WriteLine("Avant le dépôt:");
Cpt1.infoPrint();
Cpt1.addMoney(100);
Console.WriteLine("Après le dépôt:");
Cpt1.soldPrint();

Compte Cptcour = new CompteCourant(0, cC1);
Cptcour.addMoney(100);
Cptcour.soldPrint();
Compte Cep1 = new CompteCourant(2, cC1);