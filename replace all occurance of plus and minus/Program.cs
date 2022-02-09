using System;

namespace replace_all_occurance_of_plus_and_minus
{
  class Program
  {
    static void Main(string[] args)
    {
      Program p = new Program();
      Console.WriteLine(p.solution("plusminusminusplus", "plus", "minus"));
    }

    public string solution(string S, string plus, string minus)
    {
      // Replacing all occurrences of 
      // Sub in Str by empty spaces 
      S = S.Replace(plus, "+");
      S = S.Replace(minus, "-");

      // Removing unwanted spaces in the 
      // start and end of the string 
      S = S.Trim();

      return S;
    }
  }
}
