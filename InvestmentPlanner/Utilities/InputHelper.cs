using System;
using System.Globalization;

namespace InvestmentPlanner.Utilities
{
    public static class InputHelper
    {
        public static double ReadDouble(string message)
        {
            double value;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();

                // Try to parse using culture-independent format (dot as decimal separator)
                if (!double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out value) || value < 0)
                {
                    Console.WriteLine("Please enter a valid non-negative number (e.g., 1000.50).");
                }

            } while (value < 0);
            return value;
        }

        public static int ReadInt(string message)
        {
            int value;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out value) || value <= 0)
                {
                    Console.WriteLine("Please enter a valid positive whole number (e.g., 5).");
                }

            } while (value <= 0);
            return value;
        }
    }
}
