namespace CodingChallenge.BusinessLogic.Validation
{
    public static class InputValidator
    {
        public static int IsPositiveWholeNumber(string value)
        {
            if (!IsDouble(value))
            {
                throw new ArgumentException();
            }

            double number = Convert.ToDouble(value);

            if (!IsWholeNumber(number))
            {
                throw new ArgumentException();
            }

            if (!IsPositiveNumber(number))
            {
                throw new ArgumentOutOfRangeException();
            }
            return (int)number;
        }

        private static bool IsWholeNumber(double number)
        {
            return number * 2 % 1 == 0;
        }

        private static bool IsDouble(string value)
        {
            double number;
            return double.TryParse(value, out number);
        }

        private static bool IsPositiveNumber(double number)
        {
            return number >= 0;
        }

        public static void IsLessThanOrEqualTo(int number, int value)
        {
            if (number > value)
            {
                throw new ArgumentOutOfRangeException();
            };
        }
    }
}
