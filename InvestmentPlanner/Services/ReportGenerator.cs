using System;
using System.IO;  //-----> For File in the below 
using InvestmentPlanner.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentPlanner.Services
{
    class ReportGenerator
    {
        public static void Generate(Investment inv,double maturity)
        {
            double totalInvested = inv.IsSip ? inv.Amount * 12 * inv.Years : inv.Amount;
            double gain = maturity - totalInvested;

            Console.WriteLine($"\nTotal Invested: {totalInvested:N2}");
            Console.WriteLine($"Maturity Amount: {maturity:N2}");
            Console.WriteLine($"Estimated Gain: {gain:N2}");

            string report = $"Investment Type: {(inv.IsSip ? "SIP" : "Lump Sum")}\n" +
                            $"Invested: ₹{totalInvested:N2}\n" +
                            $"Maturity: ₹{maturity:N2}\n" +
                            $"Gain: ₹{gain:N2}\n" +
                            $"Years: {inv.Years}\n" +
                            $"Rate: {inv.AnnualRate}%\n" +
                            $"Date: {DateTime.Now}\n--------------------------\n";

            File.AppendAllText("Investment.txt", report);
            Console.WriteLine("\nReport saved to Investment.txt");
        }
    }
}
