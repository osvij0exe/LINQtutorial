using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class ExampleMethods
    {
        public static bool IsAnyWordUpperCase(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                bool areAllUpperCase = true;
                foreach (var letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        areAllUpperCase = false;
                    }
                }
                if (areAllUpperCase)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAnyWordUperCase_With_Linq(IEnumerable<string> words)
        {
            return words.Any(word => word.All(letter => char.IsUpper(letter)));
        }

    }
}
