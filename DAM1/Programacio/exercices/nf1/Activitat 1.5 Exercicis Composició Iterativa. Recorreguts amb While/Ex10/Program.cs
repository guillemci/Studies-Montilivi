namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa on llancem un dau de 6 cares (valors de forma aleatoria) fins que el número
        /// de vegades que surti 1 i 6 sigui el mateix.Conta quantes vegades hem llançat el dau i quantes
        /// vegades ha aparegut el valor 6.
        /// </summary>

        static void Main(string[] args)
        {
            //variables i inicialitzacio
            Random atzar = new Random();
            int cont = 0, contNumeros6 = 0, contNumeros1 = 0;
            int valorRandom = atzar.Next(1,7);

            //bucle
            //mentres contnumeros1 no sigui igual a contnumeros6 0 i contnumeros1 == 0
            while (contNumeros1 != contNumeros6 || contNumeros1 == 0) //condicio final descrita adalt
            {
                //element principal es valor random
                if (valorRandom == 6) contNumeros6++;
                if (valorRandom == 1) contNumeros1++;
                valorRandom = atzar.Next(1, 7);
                cont++;
            }

            //outputs
            Console.WriteLine($"el numero de vegades que a sortit el numero 1 abans de que 1 i 6 hagin surtit el mateix numero de vegades es de {contNumeros1}");
            Console.WriteLine($"el numero de vegades que a sortit el numero 6 abans de que 1 i 6 hagin surtit el mateix numero de vegades es de {contNumeros6}");
            Console.WriteLine($"el numero de vegades que el dau a estat llençat es de {cont}");
        }
    }
}