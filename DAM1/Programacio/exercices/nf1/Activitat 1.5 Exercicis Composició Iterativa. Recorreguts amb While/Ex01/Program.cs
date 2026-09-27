namespace Ex01
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa per contar quants valors enters introdueix un usuari per Consola. Deixarem
        ///de contar valors en trobar el valor 0.
        ///Quin és el primer element que tractarem?
        ///Quina és la condició de final de recorregut?
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int cont = 0;
            int numero;

            //inicialitzacio
            Console.WriteLine("introdueix aqui els numeros que vulguis que siguin contats per el programa, quan s'introdueixi un 0 el programa es detindra");
            numero = Convert.ToInt32(Console.ReadLine()); //aquest es el primer element que tractarem

            //bucle
            while (numero != 0) //aquesta es la condicio de final
            {
                cont ++; //primer element a tractar
                numero = Convert.ToInt32(Console.ReadLine()); //condicio final dints recorregut
            }

            //output
            Console.WriteLine($"el total de numeros que an sigut contats es de {cont}");
        }
    }
}
