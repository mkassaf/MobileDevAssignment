using System;

namespace hw1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NumberAnalayzer largestNumber = new NumberAnalayzer();
            DigitAnalyzer largestDigit = new DigitAnalyzer();
            Reverser reverser = new Reverser();
            Searcher searcher = new Searcher();

            while (true)
            {
                switch (menu())
                {
                    case 1:
                        largestNumber.GetLargest();
                        break;
                    case 2:
                        reverser.GetReverse();
                        break;
                    case 3:
                        largestDigit.GetLargest();
                        break;
                    case 4:
                        searcher.GetInt();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
        }
        public static int menu()
        {
            System.Console.WriteLine("Hello, Please Enter Your Choice:");
            System.Console.WriteLine("1. Get Largest Number");
            System.Console.WriteLine("2. Get Reversed Number");
            System.Console.WriteLine("3. Get Largest Digit");
            System.Console.WriteLine("4. Get First Number");
            System.Console.WriteLine("0. Exit");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}