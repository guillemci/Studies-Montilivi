namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 02
        /// Retorna un array de longitud 'n' amb números enters aleatoris entre -100 i 100.
        /// </summary>
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 5, 6, 10, 2 };

            RotarArray(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        public static void RotarArray(int[] array)
        {
            int cacheArray;
            for (int i = 0; i < array.Length / 2; i++)
            {
                cacheArray = array[(array.Length - 1) - i];
                array[(array.Length - 1) - i] = array[i];
                array[i] = cacheArray;
            }
        }
    }
}