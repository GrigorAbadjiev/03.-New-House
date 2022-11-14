using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowerPrice = 0;
            switch (flowersType)
            {
                case "Roses": flowerPrice = 5; break;
                case "Dahlias": flowerPrice = 3.80; break;
                case "Tulips": flowerPrice = 2.80; break;
                case "Narcissus": flowerPrice = 3; break;
                case "Gladiolus": flowerPrice = 2.50; break;
                default:
                    break;
            }
            double totalSum = flowersCount * flowerPrice;

            if (flowersType == "Roses" && flowersCount > 80)
            {
                totalSum *= 0.9;
            }
            else if (flowersType == "Dahlias" && flowersCount > 90)
            {
                totalSum *= 0.85;
            }
            else if (flowersType == "Tulips" && flowersCount > 80)
            {
                totalSum *= 0.85;
            }
            else if (flowersType == "Narcissus" && flowersCount < 120)
            {
                totalSum *= 1.15;
            }
            else if (flowersType == "Gladiolus" && flowersCount < 80)
            {
                totalSum *= 1.20;
            }
            if (totalSum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalSum - budget:f2} leva more.");
            }
        }
    }
}
