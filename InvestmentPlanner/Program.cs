using System;
using InvestmentPlanner.Models;
using InvestmentPlanner.Services;
using InvestmentPlanner.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentPlanner
{
    class Program
    {
        static void Main()
        {
            Console.Title = "SmartSaver - Investment Planner";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SMARTSAVER INVESTMENT PLANNER ===");
                Console.WriteLine("1. SIP Calculator");
                Console.WriteLine("2. Lump Sum Calculator");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        HandleSIP();
                        break;
                    case "2":
                        HandleLumpSum();
                        break;
                    case "3":
                        Console.WriteLine("Thank you for using SmartSaver!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        static void HandleSIP()
        {
            Console.Clear();
            Console.WriteLine("SIP (Systematic Investment Plan) Calculator");

            double monthly = InputHelper.ReadDouble("Enter monthly investment : ");
            int years = InputHelper.ReadInt("Enter duration (in years): ");
            double rate = InputHelper.ReadDouble("Enter expected annual return (%): ");

            var investment = new Investment
            {
                Amount = monthly,
                Years = years,
                AnnualRate = rate,
                IsSip = true
            };

            double maturity = Calculator.CalculateSip(investment);
            ReportGenerator.Generate(investment, maturity);
        }

        static void HandleLumpSum()
        {
            Console.Clear();
            Console.WriteLine("Lump Sum Investment Calculator");

            double principal = InputHelper.ReadDouble("Enter one-time investment : ");
            int years = InputHelper.ReadInt("Enter duration (in years): ");
            double rate = InputHelper.ReadDouble("Enter expected annual return (%): ");

            var investment = new Investment
            {
                Amount = principal,
                Years = years,
                AnnualRate = rate,
                IsSip = false
            };

            double maturity = Calculator.CalculateLumSum(investment);
            ReportGenerator.Generate(investment, maturity);
        }
    }
}