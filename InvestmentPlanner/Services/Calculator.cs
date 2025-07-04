using System;
using InvestmentPlanner.Models;


namespace InvestmentPlanner.Services
{
    public static class Calculator
    {
        //For Formula reffer the image i have attached.....
        public static double CalculateSip(Investment inv)
        {
            double monthlyRate = inv.AnnualRate / 12 / 100;
            int totalMonths = inv.Years * 12;

            double maturity = inv.Amount * (Math.Pow(1 + monthlyRate, totalMonths) - 1) * (1 + monthlyRate) / monthlyRate;
            return Math.Round(maturity, 2);
        }

        public static double CalculateLumSum(Investment inv)
        {

            double maturity = inv.Amount * Math.Pow(1 + inv.AnnualRate / 100, inv.Years);
            return Math.Round(maturity, 2);
        }

    }
}
