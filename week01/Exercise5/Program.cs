using System;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {

       //Displays he message, "Welcome to the Program!"
       //Asks for and returns the user's name (as a string)
       //Asks for and returns the user's favorite number (as an integer)
       //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
       //DisplayResult - Accepts the user's name and the squared number and displays them.displayWelcome();

        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResults(name, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!"); 
    }
    static string PromptUserName()
    {
        Console.Write("Please Enter your name: ");
        string name = Console. ReadLine();
        
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }
    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}