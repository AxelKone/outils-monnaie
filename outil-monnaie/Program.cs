// Axelkone
using System;
class Program
{
    static void Main()
    {
        // Taux de change actuels
        double tauxUSD = 0.78; 
        double tauxEuro = 0.68; 

        Console.Write("Entrez un montant en dollars canadiens : ");

        if (double.TryParse(Console.ReadLine(), out double montantEnCAD))
        {
            // Conversion en dollars américains 
            double montantEnUSD = montantEnCAD * tauxUSD;
            // Conversion en euros
            double montantEnEuro = montantEnCAD * tauxEuro;

            // Affichage des résultats
            Console.WriteLine($"{montantEnCAD} CAD équivaut à {montantEnUSD} USD");
            Console.WriteLine($"{montantEnCAD} CAD équivaut à {montantEnEuro} Euro");
        }
            Console.ReadKey();
    }
    
}












