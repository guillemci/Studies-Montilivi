namespace ClasseTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(3, 4, "Triangulos");
            Triangle t3 = new Triangle(t2);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
        }
    }
}
