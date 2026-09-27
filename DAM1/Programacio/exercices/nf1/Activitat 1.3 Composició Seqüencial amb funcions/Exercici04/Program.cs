using System.Text;

namespace Exercici04
{
    internal class Program
    {
        /// <summary>
        ///Escriu un programa per convertir "Dolars" a "Euros". El programa ens ha de
        ///demanar quant Euros són un dólar, i la quantitat de dolars que volem convertir.Feu
        ///que es mostri el símbol $ i el símbol € correctament.Per assolir el vostre
        ///objectiu, cal dissenyar una funció que rebi dos paràmetres: un valor real
        ///corresponent a una quantitat en euros que cal convertir (qtyEuros) i un
        ///segon valor real corresponent a l’equivalència euro/dollar (euro2Dollar). La
        ///funció ha de retornarl’equvalent de qtyEuros dollars . (suposarem que
        ///sempre serà una lletra minúscula) i retorni el valor de la majúscula
        ///corresponent.
        /// </summary>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //variables
            double numeroDeDollars;
            double dollaraEuro;
            double numeroDeEuros;


            //inicialitzacio de variables
            Console.WriteLine("aquest programa es un conversor de dolars a euros");
            Console.WriteLine("actualment un dolar equival a 0.92 euros introdueix quan val el dolar");
            dollaraEuro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("introdueix aqui el numero de dolars que volguem pasar a euros");
            numeroDeDollars = Convert.ToDouble(Console.ReadLine());

            //calculs fets en funcio
            numeroDeEuros = DollarAEuro(numeroDeDollars, dollaraEuro);

            //output
            Console.WriteLine($"Aquest numero de dollars {numeroDeDollars}$ equivalen a {numeroDeEuros}€");
        }

        //funcio
        static double DollarAEuro(double dollars, double euroPerDolar)
        {
            double numeroDeEuros = dollars * euroPerDolar;
            return numeroDeEuros;
        }
    }
}