using System;

public class CalculationService
{
    public void PerformOperation(string choice, double num1, double num2)
    {
        double result = 0;

        switch (choice)
        {
            case "1":
                result = Add(num1, num2);
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case "2":
                result = Subtract(num1, num2);
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case "3":
                result = Divide(num1, num2);
                if (result != double.MinValue)
                {
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
        }
    }

    private double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    private double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    private double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.MinValue; // Return a special value to indicate an error
        }

        return num1 / num2;
    }
}
