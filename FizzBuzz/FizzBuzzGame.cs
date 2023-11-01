namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string CheckFizzBuzz(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
