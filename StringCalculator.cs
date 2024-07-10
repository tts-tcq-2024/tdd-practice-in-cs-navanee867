using System;

public class StringCalculator
{
 public int Add(string input)
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
                int x = ParseAndValidateNumber(number);
                sum += (x < 1000) ? x : 0;
            }

            return sum;
        }

        private int ParseAndValidateNumber(string number)
        {
            if (int.TryParse(number, out int result))
            {
                if (result < 0)
                {
                    throw new Exception("Negative numbers are not allowed: " + result);
                }
                return result;
            }
            else
            {
                throw new Exception("Invalid input: " + number);
            }
        }
}
