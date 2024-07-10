using System;

public class StringCalculator
{
 public static int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            string[] delimiters = { ",", "\n", "\\", ";", "//" };
            string[] numberArray = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            foreach (string number in numberArray)
            {
                if (int.TryParse(number, out int x))
                {
                    if (x < 0)
                    {
                        throw new Exception("Negative numbers are not allowed: " + x);
                    }

                    if (x < 1000)
                    {
                        sum += x;
                    }
                }
            }

            return sum;
        }
}
