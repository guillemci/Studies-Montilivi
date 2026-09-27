namespace Ex05b
{
    internal class Program
    {
        /// <summary>
        /// Escriu la funció public static bool EsPerfecte(int n) que retorna true si n és un número
        /// perfecte i seguidament, reescriu el programa 5a usant la funció
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("introdueix un valor per saber si es perfecte");
            int valorTeclatPrimer = Convert.ToInt32(Console.ReadLine());
            bool retornat = EsPerfecte(valorTeclatPrimer);

            if (EsPerfecte(valorTeclatPrimer))
                Console.WriteLine($"el numero {valorTeclatPrimer} es tracta d'un numero perfecte");
            else
            {
                Console.WriteLine($"el numero {valorTeclatPrimer} no es tracta d'un numero perfecte");
            }
        }

        public static bool EsPerfecte(int n)
        {
            int contador = 1;
            int acomulador = 0;
            bool passat = false, final = false;

            while (!passat && !final)
            {

                if (n % contador == 0)
                    acomulador += contador;

                passat = n <= acomulador;
                final = contador <= n / 2;

                contador++;
            }

            return acomulador == n;
        }
    }
}
