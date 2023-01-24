using Poly_Compte;
Client client_1 = new Client("John", "Doe");
Compte Cpt1 = new Compte(358, client_1, 0);
Cpt1.infoPrint();
Console.WriteLine("Avant le dépôt:");
Cpt1.addMoney(100);
Console.WriteLine("Après le dépôt:");
Cpt1.soldPrint();

Compte Cptcour = new CompteCourant(0, client_1);
Cptcour.addMoney(100);
Cptcour.soldPrint();
Compte Cep1 = new CompteCourant(2, client_1);