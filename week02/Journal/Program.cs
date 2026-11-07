using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(filename))
                {
                    Console.WriteLine("Filename cannot be empty.");
                }
                else
                {
                    journal.SaveToFile(filename);
                }
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                 if (string.IsNullOrWhiteSpace(filename))
                {
                    Console.WriteLine("Filename cannot be empty.");
                }
                else
                {
                    journal.LoadFromFile(filename);
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the Journal Program!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

    }
}