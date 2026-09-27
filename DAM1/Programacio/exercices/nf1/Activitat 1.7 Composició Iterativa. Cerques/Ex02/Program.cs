namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, informar si el primer valor es repeteix. Podem considerar un
        ///número per línia.
        ///a.Versió 1: La seqüència prové d’un fitxer de text que conté com a mínim un número.
        ///Usarem el fitxer NUMEROS.TXT
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader trovar = new StreamReader("NUMEROS.TXT");

            int primeraLineaNumero = Convert.ToInt32(trovar.ReadLine());
            int lineaNumero = 0;
            string linea;
            bool trobat = false;

            while((linea = trovar.ReadLine()) != null && !trobat)
            {
                lineaNumero = Convert.ToInt32(linea);
                trobat = primeraLineaNumero == lineaNumero;
            }

            if (trobat) Console.WriteLine($"el primer valor llegit {lineaNumero} coincideix es repeteix");
            else Console.WriteLine("no s'han trobat numeros que coincideixin amb el primer");
        }
    }
}