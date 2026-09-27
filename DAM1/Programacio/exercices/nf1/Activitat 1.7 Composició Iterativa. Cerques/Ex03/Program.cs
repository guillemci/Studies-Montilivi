namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, indicar si hi ha algun número parell.
        ///a.Versió 1: La seqüència prové d’un fitxer de text(un enter per línia).
        ///Usarem el fitxer NUMEROS.TXT que conté molts números parells i NUMEROS2.TXT que no conté cap número parell
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader trovar = new StreamReader("NUMEROS.TXT");

            int lineaNumero = 0;
            string linea;
            bool trobat = false;

            while ((linea = trovar.ReadLine()) != null && !trobat)
            {
                lineaNumero = Convert.ToInt32(linea);
                trobat = lineaNumero % 2 == 0;
            }

            if (trobat) Console.WriteLine($"a la linea numero: {lineaNumero} s'ha trovat un numero parell");
            else Console.WriteLine("no s'ha trovat cap numero parell");
        }
    }
}
