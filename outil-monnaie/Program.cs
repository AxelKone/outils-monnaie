// Axelkone
using System;

class Program
{
    static void Main()
    {
        // Taux de change actuels
        double tauxUSD = 0.78; // 1 CAD = 0.78 USD
        double tauxEuro = 0.68; // 1 CAD = 0.68 Euro

        Console.Write("Entrez un montant en dollars canadiens : ");
        if (double.TryParse(Console.ReadLine(), out double montantEnCAD))
        {
            Console.Write("Choisissez la devise de conversion (USD/Euro) : ");
            string choixDevise = Console.ReadLine();

            double montantConverti = 0.0;

            // Effectuer la conversion en fonction du choix de l'utilisateur
            switch (choixDevise.ToLower())
            {
                case "usd":
                    montantConverti = montantEnCAD * tauxUSD;
                    Console.WriteLine($"{montantEnCAD} CAD équivaut à {montantConverti} USD");
                    break;
                case "euro":
                    montantConverti = montantEnCAD * tauxEuro;
                    Console.WriteLine($"{montantEnCAD} CAD équivaut à {montantConverti} Euro");
                    break;
                default:
                    Console.WriteLine("Choix de devise invalide. Veuillez choisir USD ou Euro.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Montant invalide. Assurez-vous d'entrer un nombre valide.");
        }
    }
}












