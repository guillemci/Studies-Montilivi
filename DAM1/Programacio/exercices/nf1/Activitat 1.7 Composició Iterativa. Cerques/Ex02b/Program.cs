namespace Ex02b
{
    internal class Program
    {
        /// <summary>
        /// 2- Donada una seqüència d’enters, informar si el primer valor es repeteix. Podem considerar un
        ///número per línia.
        ///b.Versió 2: La seqüència prové del teclat i acaba amb -9999.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("en el seguent codi es mirara si es torna a introduir un altre\nvalor que sigui igual al valor que introdueixi l'usuari, en cas de que es possi -9999 la cerca acabara");
            int primerNumero = Convert.ToInt32(Console.ReadLine());
            int altresIteracions = 0;
            bool trobat = false;

            while (altresIteracions != -9999 && primerNumero != -9999 && !trobat)
            {
                altresIteracions = Convert.ToInt32(Console.ReadLine());
                trobat = primerNumero == altresIteracions;
            }

            if (trobat) Console.WriteLine($"s'ha trovat un numero que coincideix amb el primer numero: {primerNumero}");
            else Console.WriteLine("no s'han trobat numeros que coincideixin amb el primer");
        }
    }
}
