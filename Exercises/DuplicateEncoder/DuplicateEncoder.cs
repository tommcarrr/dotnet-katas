using System.Linq;

namespace DotNetKatas.Exercises.DuplicateEncoder;
public class DuplicateEncoder
{
    internal string Get(string input)
    {
        input = input.ToLower();
        return string.Join("", input.Select(x => input.Count(y => y == x) > 1 ? ")" : "("));
    }
}