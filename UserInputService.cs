using System;

public class UserInputService
{
    public string ReadChoice()
    {
        string choice;
        bool isValidChoice = false;

        do
        {
            Console.Write("Select an option: ");
            choice = Console.ReadLine();

            if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
            {
                isValidChoice = true;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        } while (!isValidChoice);

        return choice;
    }

    public double ReadNumber(string message)
    {
        double number;
        bool isValid = false;

        do
        {
            Console.Write(message);
            isValid = Double.TryParse(Console.ReadLine(), out number);

            if (!isValid)
            {
                Console.WriteLine("Invalid number, please try again.");
            }
        } while (!isValid);

        return number;
    }
}
