namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 4 };

            int total = caluclarArrayNumeros(array);

            Console.WriteLine(total);
        }

        static int caluclarArrayNumeros(int[] array)
        {
            int sumarTotal = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumarTotal += array[i];
            }

            return sumarTotal;
        }
    }
}
