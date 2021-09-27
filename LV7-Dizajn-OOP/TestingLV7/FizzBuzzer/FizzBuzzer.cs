namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        public string Convert(int value)
        {
            string output = "";

            if (value % 3 == 0) output += "Fizz";
            if (value % 5 == 0) output += "Buzz";
            if (string.IsNullOrEmpty(output)) output = value.ToString();

            return output;
        }
    }
}
