using System;namespace hw1{    public class DigitAnalyzer    {
        public void GetLargest()
        {
            System.Console.WriteLine("insert the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int largest = 0;
            int remaining;
            while (number > 0)
            {
                remaining = number % 10;
                if (remaining > largest)
                {
                    largest = remaining;
                }
                number = number / 10;
            }
            System.Console.WriteLine("largest is: " + largest);
        }    }}
