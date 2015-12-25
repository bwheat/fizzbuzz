using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzRules
{
    public interface IFizzbuzzRule
    {
        string DetermineFizzBuzz(int number);
    }

    public class IsDivisibleBy5 : IFizzbuzzRule
    {
        public string DetermineFizzBuzz(int number)
        {
            return number%5 == 0 ? "Buzz" : "";
        }
    }

    public class IsDivisibleBy3 : IFizzbuzzRule
    {
        public string DetermineFizzBuzz(int number)
        {
            return number % 3 == 0 ? "Fizz" : "";
        }
    }


    public class FizzBuzzRules
    {
        private List<IFizzbuzzRule> _rules = new List<IFizzbuzzRule>();

        public FizzBuzzRules()
        {
            _rules.Add(new IsDivisibleBy3());
            _rules.Add(new IsDivisibleBy5());
        }

        public List<string> FindFizzBuzzList(int min, int max)
        {
            var results = new List<string>();
            for (var i = min; i < max; i++)
            {
                var result = "";
                foreach (var rule in _rules)
                {
                    result += rule.DetermineFizzBuzz(i);
                }

                results.Add(result);
            }
            return results;
        }
    }
}
