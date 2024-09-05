using System;

namespace W7P1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Making list with random ten numbers

            Random newRandom = new Random();
            List<int> ourList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                ourList.Add(newRandom.Next(-50, 50));
            }

            // Displaying our random numbers list

            string numbersString = string.Join(", ", ourList);
            Console.WriteLine($"Rastgele olan sayılarımız: {numbersString}");

            // Even numbers

            var evenNums = ourList.Where(n => n % 2 == 0);
            string evenNumString = string.Join(", ", evenNums);
            Console.WriteLine($"Çift sayılarımız: {evenNumString}");

            // Odd numbers 

            var oddNums = ourList.Where(n => n % 2 == 1);
            string oddNumString = string.Join(", ", oddNums);
            Console.WriteLine($"Tek sayılarımız: {oddNumString}");

            // Negative numbers 

            var negativeNums = ourList.Where(n => n < 0);
            string negativeNumString = string.Join(", ", negativeNums);
            Console.WriteLine($"Negatif sayılarımız: {negativeNumString}");

            // Positive numbers

            var positiveNums = ourList.Where(n => n > 0);
            string positiveNumString = string.Join(", ", positiveNums);
            Console.WriteLine($"Pozitif sayılarımız: {positiveNumString}");

            // Bigger than 15 smaller than 22 numbers

            var numberRange = ourList.Where(n => n > 15 && n < 22);
            string numberRangeString = string.Join(", ", numberRange);
            if (numberRange.Any())
            {
                Console.WriteLine($"15'ten büyük ve 22'den küçük sayılarımız: {numberRangeString}");
            }
            else
            {
                Console.WriteLine("15'ten büyük ve 22'den küçük sayılarımız yoktur");
            }
        }
    }
}