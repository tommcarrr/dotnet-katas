using System.Collections.Generic;

namespace DotNetKatas.Exercises.FizzBuzz;

public class FizzBuzz
{
    internal List<string> GetFizzBuzz(int max)
    {
        List<string> s = new ();
        for (int i = 1; i <= max; i++)
        {
            s.Add(GetString(i));
        }
        return s;
    }

    internal string GetString(int i)
    {
        if (i % 15 == 0)
        {
            return "FizzBuzz";
        }
        else if (i % 3 == 0)
        {
            return "Fizz";
        }
        else if (i % 5 == 0)
        {
            return "Buzz";
        }
        return i.ToString();
    }
}