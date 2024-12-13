using System;

public class Calculator
{
    private readonly UserInputService _userInputService;
    private readonly CalculationService _calculationService;
    private readonly MenuService _menuService;

    public Calculator()
    {
        _userInputService = new UserInputService();
        _calculationService = new CalculationService();
        _menuService = new MenuService();
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Calculator!");

        while (true)
        {
            _menuService.ShowMenu();
            string choice = _userInputService.ReadChoice();

            if (choice == "4")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }

            double num1 = _userInputService.ReadNumber("Enter the first number: ");
            double num2 = _userInputService.ReadNumber("Enter the second number: ");

            _calculationService.PerformOperation(choice, num1, num2);
        }
    }
}
