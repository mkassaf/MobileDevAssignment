using System;namespace hw1{    public class Reverser    {        public void GetReverse()
        {            System.Console.WriteLine("insert number: ");            int number = Convert.ToInt32(Console.ReadLine());            string reverse = "";            int remaining;            while (number > 0)
            {                remaining = number % 10;                number = number / 10;                reverse = reverse + remaining;            }            System.Console.WriteLine("reverse is: " + reverse);        }    }}
