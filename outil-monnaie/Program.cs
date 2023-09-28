// Axelkone

using System;
class Program
{
    static void Main()
    {
        double tauxUSD = 0.78; // Taux de change actuel : 1 CAD = 0.78 USD
        double tauxEuro = 0.68; // Taux de change actuel : 1 CAD = 0.68 Euro

        Console.Write("Entrez un montant : ");
        if (double.TryParse(Console.ReadLine(), out double montant))
        {
            Console.Write("Choisissez une devise (USD, CAD ou EURO) : ");
            string devise = Console.ReadLine().ToLower();

            double montantConverti = 0.0;

            switch (devise)
            {
                case "usd":
                    montantConverti = montant / tauxUSD;
                    Console.WriteLine($"{montant} CAD équivaut à environ {montantConverti:F0} USD");
                    break;
                case "cad":
                    montantConverti = montant * tauxUSD;
                    Console.WriteLine($"{montant} USD équivaut à environ {montantConverti:F0} CAD");
                    break;
                case "euro":
                    montantConverti = montant * tauxEuro;
                    Console.WriteLine($"{montant} CAD équivaut à environ {montantConverti:F0} Euro");
                    break;
                default:
                    Console.WriteLine("Devise invalide. Veuillez choisir parmi USD, CAD ou EURO.");
                    break;

                    Console.ReadKey();
            }
        }
    }
}