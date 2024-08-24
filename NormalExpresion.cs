using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class NormalExpresion
    {
        public static bool IsAnyLargerThan100With(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if(IsLargerThan100(number))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsLargerThan100(int number)
        {
            return number > 100;
        }

        public static bool IsAnyEven(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (IsEven(number))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }


        //using func 
        public static bool IsAny(int[] numbers, Func<int, bool> predicate)
        {

            foreach (int number in numbers)
            {
                if (predicate(number))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAnyGeneric<T>(T[] numbers, Func<T, bool> predicate)
        {

            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    return true;
                }
            }
            return false;
        }



    }




}
