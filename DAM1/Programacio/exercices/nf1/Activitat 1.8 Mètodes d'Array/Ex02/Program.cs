namespace Ex02
{
    /// <summary>
    /// /// Exercici 02
    /// Retorna un array de longitud 'n' amb números enters aleatoris entre -100 i 100.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("especifica la longitud del array");
            int longitudArray = Convert.ToInt32(Console.ReadLine());
            int[] ArrayReturnat = ArrayRetornar(longitudArray);

            for (int i = 0; i < ArrayReturnat.Length; i++)
            {
                Console.WriteLine(ArrayReturnat[i]);
            }
        }


        public static int[] ArrayRetornar(int n)
        {
            Random rnd = new Random();
            int[] newArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                newArray[i] = rnd.Next(-100, 101);
            }

            return newArray;
        }
    }
}
