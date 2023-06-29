using System;
using System.Collections.Generic;

public class FinanceManager
{
    private List<double> incomes;
    private List<double> expenses;
    private double savings;

    public FinanceManager()
    {
        incomes = new List<double>();
        expenses = new List<double>();
        savings = 0.0;
    }

    public void Run()
    {
        Console.WriteLine("Welcome to Personal Cato Finance Manager");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Select an option");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. View Financial Summary");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter your choice (1-4): ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddIncome();
                    break;
                case "2":
                    AddExpense();
                    break;
                case "3":
                    ViewFinancialSummary();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using Personal Cato Finance Manager");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void AddIncome()
    {
        Console.Write("Enter the income amount: ");
        double amount = ReadAmount();

        incomes.Add(amount);
        savings += amount;

        Console.WriteLine("Income added successfully");
    }

    private void AddExpense()
    {
        Console.Write("Enter the expense amount: ");
        double amount = ReadAmount();

        expenses.Add(amount);
        savings -= amount;

        Console.WriteLine("Expense added successfully.");
    }

    private void ViewFinancialSummary()
    {
        Console.WriteLine("Financial Summary: ");
        Console.WriteLine("Incomes: ");

        if (incomes.Count == 0)
        {
            Console.WriteLine("No incomes recorded.");
        }
        else
        {
            foreach (double income in incomes)
            {
                Console.WriteLine($"- {income}");
            }
        }

        Console.WriteLine("Expenses: ");

        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses recorded.");
        }
        else
        {
            foreach (double expense in expenses)
            {
                Console.WriteLine($"- {expense}");
            }
        }

        Console.WriteLine($"Savings: {savings}");
    }

    private double ReadAmount()
    {
        string input = Console.ReadLine();
        double amount;

        while (!double.TryParse( input, out amount) || amount <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive amount: ");
            input = Console.ReadLine();
        }

        return amount;
    }
}