double Fahrenheit, Celsius;
const double componentFormula = 9.0 / 5.0;

Console.WriteLine("introdueix aqui els graus Celsius que es vulguin pasar a Fahrenheit");
Celsius = Convert.ToDouble(Console.ReadLine());


Fahrenheit = (Celsius * componentFormula) + 32;

Console.WriteLine($"Els {Celsius}C equivalen a {Fahrenheit}F");