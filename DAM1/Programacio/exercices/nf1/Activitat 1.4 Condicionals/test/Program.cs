namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int cont = 0;
            int num;
            int final = 100;

            num = Convert.ToInt32(Console.ReadLine());


            while (cont < 100) 
            {
                Console.WriteLine(num);
                num++;
                cont ++;
            }
        }
    }
}
