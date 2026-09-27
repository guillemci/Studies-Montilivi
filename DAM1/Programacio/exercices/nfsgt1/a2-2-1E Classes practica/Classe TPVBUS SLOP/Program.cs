using System.Text;

namespace Classe_TPVBUS
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Targeta t1 = new Targeta(1.5);
            Targeta t2 = new Targeta(2, 10);

            t1.Recarregar(5);

            if (t1.Marcar())
                Console.WriteLine("saldo bé");
            else
                Console.WriteLine("saldo insuficient");

            t1.FusionarSaldos(t2);

            Targeta t3 = Targeta.FusionarSaldos(t1, t2);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            if (Targeta.Major(t3, t1))
                Console.WriteLine("t3 te mes saldo");
            else
                Console.WriteLine("t1 te mes saldo");
        }
    }
}
