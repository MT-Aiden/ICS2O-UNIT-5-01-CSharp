// Aiden McLeod
// ICS2O-Unit5-01-CSharp
// April 22 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int choice;
        int randomnumber;

        System.Random random = new System.Random();
        randomnumber = random.Next(1, 6);
        // Console.WriteLine("For debugging, the random number is " + randomnumber + ".");
        Console.Write("Pick a number from 1 to 6: ");
        choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number was " + randomnumber + "!");
        if (choice == randomnumber)
        {
            Console.WriteLine("You got it right!");
        }
        else
        {
            Console.WriteLine("You got it wrong...");
        }
        Console.WriteLine("\nFinished.");
    }
}