namespace Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilaGenerica<int> pila = new PilaGenerica<int>(5);
            PilaGenerica<int> pila2 = new PilaGenerica<int>(5);


            Console.WriteLine("Empilar 10, 20, 30");
            pila.Empila(10);
            pila.Empila(20);
            pila.Empila(30);
            Console.WriteLine();

            Console.WriteLine("Recorregut amb foreach:");
            foreach (var valor in pila)
                Console.Write($"{valor} ");
            Console.WriteLine();

            Console.WriteLine("Pila actual: " + pila);
            Console.WriteLine("Cim: " + pila.Cim());
            Console.WriteLine();

            Console.WriteLine("PCim: " + pila.PCim());
            Console.WriteLine("Despres de PCim: " + pila);
            Console.WriteLine();

            pila.Desempila();
            Console.WriteLine("Despres de Desempila: " + pila);
            Console.WriteLine();

            Console.WriteLine("Es buida: " + pila.EsBuida());
            Console.WriteLine("Es plena: " + pila.EsPlena());
            Console.WriteLine();

            pila2.Empila(10);

            Console.WriteLine("Pila1: " + pila);
            Console.WriteLine("Pila2: " + pila2);
            Console.WriteLine("Equals: " + pila.Equals(pila2));
            Console.WriteLine();

            pila2.Empila(20);
            pila2.Empila(30);

            Console.WriteLine("Pila2: " + pila2);
            Console.WriteLine("Equals despres: " + pila.Equals(pila2));
            Console.WriteLine();

            try
            {
                PilaGenerica<int> pilaBuida = new PilaGenerica<int>();
                pilaBuida.Cim();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcio Cim: " + ex.Message);
            }
            Console.WriteLine();

            try
            {
                PilaGenerica<int> pilaPetita = new PilaGenerica<int>(2);
                pilaPetita.Empila(1);
                pilaPetita.Empila(2);
                pilaPetita.Empila(3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcio Empila: " + ex.Message);
            }
        }
    }
}
