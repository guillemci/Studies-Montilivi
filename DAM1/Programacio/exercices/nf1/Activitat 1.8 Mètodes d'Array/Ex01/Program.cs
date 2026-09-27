namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("especifica la longitud del array");
            int longitudArray = Convert.ToInt32(Console.ReadLine());
            int[] ArrayReturnat = OmpleNaturals(longitudArray);

            Console.WriteLine("els numeros naturals del array son");
            for (int i = 0; i < ArrayReturnat.Length; i++)
            {
                Console.WriteLine(ArrayReturnat[i]);
            }
        }

        public static int[] OmpleNaturals(int n)
        {
            int[] numNatu = new int[n];
            for (int i = 0; i < n; i++)
            {
                numNatu[i] = i + 1;
            }
            return numNatu;

        }
    }
}
