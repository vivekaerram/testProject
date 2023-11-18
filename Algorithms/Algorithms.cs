using System;
using System.Text;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial of negative number is not defined.");

            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items == null || items.Length == 0)
                return string.Empty;

            if (items.Length == 1)
                return items[0];

            StringBuilder formattedString = new StringBuilder();
            for (int i = 0; i < items.Length; i++)
            {
                formattedString.Append(items[i]);

                if (i < items.Length - 2)
                    formattedString.Append(", ");
                else if (i == items.Length - 2)
                    formattedString.Append(" and ");
            }

            return formattedString.ToString();
        }
    }
}
