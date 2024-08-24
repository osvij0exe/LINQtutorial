using LinqTutorial;
using System.Linq.Expressions;

//sin usar linq

var wordsNoUppercase = new string[]
{
    "quick","brown","fox"
};


Console.WriteLine(ExampleMethods.IsAnyWordUpperCase(wordsNoUppercase));

var wordsWithUppercase  = new string[]
{
    "quick","brown","FOX"

};


Console.WriteLine(ExampleMethods.IsAnyWordUpperCase(wordsWithUppercase));

//usando linq
Console.WriteLine("---  1) LINQ Example ---");
Console.WriteLine(ExampleMethods.IsAnyWordUperCase_With_Linq(wordsNoUppercase));
Console.WriteLine(ExampleMethods.IsAnyWordUperCase_With_Linq(wordsWithUppercase));



// lambas expresions

Console.WriteLine("---  2) Lambda Expresions Explicacion---");

var numbers = new[] { 1, 4, 3, 99, 256, 2 };

bool isAnyLargerThan100 = NormalExpresion.IsAnyLargerThan100With(numbers);
Console.WriteLine(isAnyLargerThan100);

bool iseven = NormalExpresion.IsAnyEven(numbers);
Console.WriteLine(iseven);

Console.WriteLine("---  2.1) Lambda Expresions usinf Func ---");
bool isAnyLargerThan100UsingFunc = NormalExpresion.IsAny(numbers,NormalExpresion.IsLargerThan100) ;
Console.WriteLine(isAnyLargerThan100UsingFunc);

bool isevenUsingFunc = NormalExpresion.IsAny(numbers,NormalExpresion.IsEven);
Console.WriteLine(isevenUsingFunc);

Console.WriteLine("---  2.2) Using a Lambda Expresions ()=> inside the Func ---");
bool isAnyLargerThan100UsingLamda = NormalExpresion.IsAny(numbers, numbers => numbers > 100);
Console.WriteLine(isAnyLargerThan100UsingLamda);

bool isevenUsingLamda = NormalExpresion.IsAny(numbers, numbers => numbers % 2 == 0);
Console.WriteLine(isevenUsingLamda);

Console.WriteLine("---  3) LINQ and Extension Methods ---");

var words = new[] { "a", "bb", "ccc", "ddd" };
var wordsLongerThan2Letters = words.Where(w => w.Length > 2);


Console.WriteLine(string.Join(", ",wordsLongerThan2Letters));

Console.WriteLine("---  3.1) Extension method for strings ---");

var multiLineString = @" 
please give me a ride on your back,
said the Duck to the Kangaroo:";


var countofLines = multiLineString.GetCountOfLines();
Console.WriteLine(countofLines);

Console.WriteLine("---  4) Method syntax vs Query syntax ---");

var Numbers = new[] { 4, 7, 8, 20, 5, 25 };

var smallerordereNumbersmethodSyntax =
    Numbers.Where(n => n < 10)
    .OrderBy(n => n);

Console.WriteLine($"Method syntax: {string.Join(",", smallerordereNumbersmethodSyntax)}");


var smallerordereNumbersQuerySyntax =
    from number in Numbers
    where number < 10
    orderby number
    select number;

Console.WriteLine($"Query syntax: {string.Join(",",smallerordereNumbersQuerySyntax)}");



