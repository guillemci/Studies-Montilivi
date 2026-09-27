namespace Ex01
{
    internal class Program
    {
        /// <summary>
        /// 1. Valora els resultats de les següent expressions booleanes. Executa el codi adjunt per a
        ///verificar-ne els resultats obtinguts.
        ///Valors de les variables a, b i c:
        ///● a = 5
        ///● b = 3
        ///● c = -10
        ///Expressions booleanes a valorar:
        ///e1.a > 3
        ///e2.a > c
        ///e3. b != c
        ///e4. a == 3
        ///e5.a* b == 15
        ///e6.c / b < a
        /// e7.c / b == -10
        ///e8.a + b + c == 5
        ///e9. (a + b == 8) && (a - b == 2)
        ///e10. (a + b == 8) || (a - b == 6)
        ///e11.a > 3 && b > 3 && c< 3
        /// </summary>

        static void Main(string[] args)
        {
            //variables declarades
            int a = 5;
            int b = 3;
            int c = -10;

            bool ex1 = a > 3;
            bool ex2 = a > c;
            bool ex3 = b != c;
            bool ex4 = a == 3;
            bool ex5 = a * b == 15;
            bool ex6 = c / b < a;
            bool ex7 = c / b == -10;
            bool ex8 = a + b + c == 5;
            bool ex9 = (a + b == 8) && (a - b == 2);
            bool ex10 = (a + b == 8) || (a - b == 6);
            bool ex11 = a > 3 && b > 3 && c < 3;

            //resultats booleans
            Console.WriteLine($"ex1 = {ex1}"); //true
            Console.WriteLine($"ex2 = {ex2}"); //true
            Console.WriteLine($"ex3 = {ex3}"); //true
            Console.WriteLine($"ex4 = {ex4}"); //false
            Console.WriteLine($"ex5 = {ex5}"); //true
            Console.WriteLine($"ex6 = {ex6}"); //true
            Console.WriteLine($"ex7 = {ex7}"); //false
            Console.WriteLine($"ex8 = {ex8}"); //false
            Console.WriteLine($"ex9 = {ex9}"); //true
            Console.WriteLine($"ex10 = {ex10}"); //true
            Console.WriteLine($"ex11 = {ex11}"); //false
        }
    }
}