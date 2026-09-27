namespace Exercici03
{
    internal class Program
    {
        /// <summary>
        ///Escriu un programa per demanar una lletra minúscula i mostrar la lletra majúscula
        ///equivalent.Per assolir el vostre objectiu, cal dissenyar una funció que rebi un
        ///caràcter (suposarem que sempre serà una lletra minúscula) i retorni el valor
        ///de la majúscula corresponent
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            char majuscula;
            char minuscula;

            //inicialitzacio variables
            Console.Write("escriu la lletra minuscula: ");
            minuscula = Convert.ToChar(Console.ReadLine());

            //calculs amb funcio
            majuscula = Majuscula(minuscula);

            //output
            Console.Write($"la lletra original era '{minuscula}' ara es '{majuscula}'");
        }

        //funcio
        static char Majuscula(char lletraMinuscula)
        {
            char majuscula = (char)(lletraMinuscula - 32);

            //Console.Write($"la lletra original era {lletraMinuscula} ara es {majuscula}");

            return majuscula;
        }
    }
}
