using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    //Permite extender los metodos de la clase string, utilizando this 
     public static class ExtensionMethod
    {
        public static int GetCountOfLines(this string input)
        {
            return input.Split("\n").Length;
        }
    }
}
