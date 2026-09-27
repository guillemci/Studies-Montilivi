using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// Un fitxer conté línies amb tripletes PRODUCTE , PREU_UNITARI, UNITATS corresponents a un
        /// tiquet de venda.
        /// Els productes rics amb colesterol són aquells que contenen el substring “PIZZ” o la paraula EMBOTIT.
        /// Rebutjarem la compra si en el ticket hi apareix més d’un producte ric en colesterol.
        /// Per exemple, el següent fitxer implica un rebutjar la compra ja que hi ha 3 productes rics en colesterol
        /// (importa l’aparició de l’element, no el nombre d’unitats).
        /// A partir de la seqüència d’entrada del fitxer “TIQUET.TXT”, informar:
        /// ● Si retornem la compra per ser rica en colesterol, o bé fem la compra finalment.
        /// ● Si fem la compra, informar de l’import total i en cas que hagi aparegut només un producte ric
        /// en colesterol, informar-ne quin és.Si no n’ha aparegut cap, cal donar el missatge “COMPRA
        /// SANA”
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("TIQUET.TXT");
            double preuTotal = 0;
            string linea, volsComprar, producteaparegut = "";
            bool comprat = false, trovatmaxcore = false;
            int cont = 0, cantitatTotal = 0;

            while ((linea = trova.ReadLine()) != null && !trovatmaxcore)
            {
                if (linea.Contains("PIZZ") || linea.Contains("EMBOTIT"))
                {
                    cont++;
                    producteaparegut = linea;
                }
                cantitatTotal += Convert.ToInt32(trova.ReadLine());
                preuTotal += Convert.ToDouble(trova.ReadLine());
                trovatmaxcore = cont > 1;
            }

            comprat = cont == 0;

            if (trovatmaxcore) Console.WriteLine("compra rebutjada per tenir masa coresterol");
            
            if (cont == 1)
            {
                comprat = false;
                volsComprar = Console.ReadLine();
                comprat = volsComprar.Contains("yes");
            }

            if (comprat)
            {
                if (cont == 1) Console.WriteLine($"la compra s'ha dut a terme tot i que el producte {producteaparegut} amb coresterol estava en la llista:");
                else Console.WriteLine("s'ha dut a terme la compra (COMPRA SANA):");

                Console.WriteLine($"el preu total de la compra es de {preuTotal:F2}");
                Console.WriteLine($"el total de productes comprats es de {cantitatTotal}");
            }
        }
    }
}