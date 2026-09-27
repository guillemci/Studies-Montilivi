/// <summary>
/// Escriu un programa per convertir "Dolars" a "Euros". El programa ens ha de demanar
/// quant Euros són un dólar, i la quantitat de dolars que volem convertir. Feu que es
/// mostri el símbol $ i el símbol € correctament
/// </summary>

//funcions del llengautje
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//variables
double numeroDeEuros;
double dollaraEuro;
double numeroDeDolars;

//entrada
Console.WriteLine("aquest programa es un conversor de dolars a euros");
Console.WriteLine("actualment un dolar equival a 0.92 euros introdueix quan val el dolar");
dollaraEuro = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("introdueix aqui el numero de dolars que volguem pasar a euros");
numeroDeDolars = Convert.ToDouble(Console.ReadLine());

//calcul
numeroDeEuros = numeroDeDolars * dollaraEuro;

//sortida
Console.WriteLine($"el numero de dolars donats {numeroDeDolars}$ pasats a euros es {numeroDeEuros}€");