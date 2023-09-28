// Axelkone
using System;

class Program
{
    static void Main()
    {
        // Taux de change 
        double tauxUSD = 0.78; 
        double tauxEuro = 0.68; 

        // entrer le montant
        Console.Write("Entrez un montant en dollars canadiens : ");

        //choisir la devise
        if (double.TryParse(Console.ReadLine(), out double montantEnCAD))
        {
            Console.Write("Choisissez la devise de conversion (USD/Euro) : ");
            string choixDevise = Console.ReadLine();

            double montantConverti = 0.0;

            // Faire la conversion en fonction du choix 
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

                    Console.ReadKey();
            }
        }
     
    }
}












