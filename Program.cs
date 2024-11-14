using System.IO;
namespace Assignment_2_3

{
    internal class Program
    {
        static void Main(string[] args)
        {//tip calculator . enter bill total,
         //enter tip percentage.
         //display grand total after adding tip
            Console.WriteLine("How much was the bill?");
            double billCost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How much would you like to tip? (A) 20% (B) 15% (C) 10% (D) Other?");
           double finalAmount = (billCost*.05)+billCost;
            string tipAmount = Console.ReadLine();

            switch (tipAmount)
            {

                case "A":
                case "a":
                    Console.WriteLine($"${finalAmount * 1.20} will be your total if you decide to tip 20%");

                    break;

                case "B":
                case "b":
                    Console.WriteLine($"${finalAmount * 1.15} will be your total if you decide to tip 15%");

                    break;


                case "C":
                case "c":
                    Console.WriteLine($"${finalAmount * 1.10} will be your total if you decide to tip 10%");

                    break;

                case "D":
                case "d":
                    Console.WriteLine("How much would you like to tip (%)? \nYou can use decimals\n");
                    double userAnswer = Convert.ToDouble(Console.ReadLine());
                    double userAnswer2=(userAnswer / 100)+1;
                    Console.WriteLine($"${finalAmount * userAnswer2} will be your total if you decide to tip {userAnswer} %");

                    break;

            }


            //Assignment 2_3 Part 1

            //Write a console application to create a text file
            //and save your basic details like name, age, address ( use dummy data).
            //Read the details from same file and print on console.
            string filePath = @"C:\TextFiles\CodingExample.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {


                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
