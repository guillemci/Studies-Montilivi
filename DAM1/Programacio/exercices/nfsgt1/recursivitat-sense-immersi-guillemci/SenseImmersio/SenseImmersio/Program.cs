namespace SenseImmersio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sumatori (5): {Sumatori(5)}");
            Console.WriteLine($"ProducteSumas (5,4): {ProducteSumas(5, 4)}");
            Console.WriteLine($"Potencia (20,2): {Potencia(20, 2)}");
            Console.WriteLine($"Divisio (10 / 3): {DivisioEntera(10, 3)}");
            Console.WriteLine($"Modul (10 % 3): {Modul(10, 3)}");
            Console.WriteLine($"Fibonacci (7): {Fibonacci(7)}");
            Console.WriteLine($"Canvi Base (13 a base 2): {CanviBase(13, 2)}");
            Console.WriteLine($"Comptar xifres (1234): {ComptarXifres(1234)}");
            Console.WriteLine($"Esta en base 8? (745): {EstaEnBase(745, 8)}");
        }

        /// <summary>
        /// Feu una funció recursiva que calculi el sumatori d’un número natural
        /// </summary>
        static int Sumatori(int numero)
        {
            int resultat;

            if (numero == 0)
                resultat = numero;
            else
            {
                resultat = Sumatori(numero - 1);
                resultat += numero;
            }

            return resultat;
        }


        /// <summary>
        /// Feu una funció recursiva que calculi el producte de dos números naturals utilitzant sumes.
        /// </summary>
        static int ProducteSumas(int numero, int numerovegades)
        {
            int resultat;

            if (numerovegades == 0)
                return 0;
            else
            {
                resultat = ProducteSumas(numero, numerovegades - 1);
                resultat = numero + resultat;
            }

            return resultat;
        }

        /// <summary>
        /// Feu una funció recursiva que calculi la potència d’un número elevat a un altre
        /// </summary>
        static int Potencia(int numero, int potencia)
        {
            int resultat;

            if (potencia == 0) return 1;
            else
            {
                resultat = Potencia(numero, potencia - 1);
                resultat = resultat * numero;

            }

            return resultat;
        }

        /// <summary>
        /// Feu una funció recursiva que faci la divisió entera entre dos números
        /// </summary>
        static int DivisioEntera(int dividend, int divisor)
        {
            int resultat;

            if (dividend < divisor)
                resultat = 0;
            else
                resultat = 1 + DivisioEntera(dividend - divisor, divisor);

            return resultat;
        }

        /// <summary>
        /// Feu una funció recursiva que faci el mòdul entre dos números (residu de la divisió entera)
        /// </summary>
        static int Modul(int dividend, int divisor)
        {
            int resultat;

            if (dividend < divisor)
                resultat = dividend;
            else
                resultat = Modul(dividend - divisor, divisor);

            return resultat;
        }

        /// <summary>
        /// Feu una funció recursiva que calculi l’enèsim número de la sèrie de Fibonacci.
        /// </summary>
        static int Fibonacci(int n)
        {
            int resultat;

            if (n <= 1)
                resultat = n;
            else
                resultat = Fibonacci(n - 2) + Fibonacci(n - 1);

            return resultat;
        }

        /// <summary>
        /// Feu una funció recursiva que retorni un enter que sigui la interpretació en base b d’un altre enter n entrat com a argument a la funció.
        /// </summary>
        static int CanviBase(int n, int b)
        {
            int resultat;

            if (n < b)
                resultat = n;
            else
            {
                int residu = n % b;
                int quocient = n / b;
                resultat = CanviBase(quocient, b) * 10 + residu;
            }

            return resultat;
        }

        /// <summary>
        /// Feu una funció recursiva que compti les xifres d'un nombre.
        /// </summary>
        static int ComptarXifres(int n)
        {
            int resultat;

            if (n < 10)
                resultat = 1;
            else
            {
                resultat = 1 + ComptarXifres(n / 10);
            }

            return resultat;
        }

        /// <summary>
        /// Feu una funció recursiva que ens digui si un nombre está en base b
        /// </summary>
        static bool EstaEnBase(int n, int b)
        {
            bool esValid;

            if (n < 10)
                esValid = (n < b);
            else
            {
                if (n % 10 < b)
                    esValid = EstaEnBase(n / 10, b);
                else
                    esValid = false;
            }

            return esValid;
        }
    }
}

