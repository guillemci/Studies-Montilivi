namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// 9. Fes un programa que calculi la nota qualitativa d’un estudiant. Per calcular la nota
        ///qualitativa cal tenir en compte la nota numèrica de l’examen i la nota numèrica de les
        ///pràctiques.Aquestes dues notes seran números reals en el nostre programa.
        ///Si alguna d'aquestes dues notes és inferior a 3 aleshores la nota qualitativa de
        ///l’assignatura és Suspens.Altrament es calcula una nota numèrica global agafant el 80%
        ///de la nota de l’examen i el 20% de la nota de pràctiques, i s’ estableix la nota qualitativa
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            double notaExamen;
            double notaPractiques;
            double notaTotal;
            string resultatComprovador;

            //inicialitzacio
            Console.WriteLine("quina es la nota del examen?");
            notaExamen = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("quina es la nota de les practiques?");
            notaPractiques = Convert.ToDouble(Console.ReadLine());

            //calcul
            resultatComprovador = ComprovadorNota(notaExamen, notaPractiques);

            //output
            Console.WriteLine(resultatComprovador);
        }

        static string ComprovadorNota(double notaExamen, double notaPractiques)
        {
            string resultat;
            double notaTotal;

            //condicional
            if (notaExamen < 3 || notaPractiques < 3)
            {
                return resultat = ($"suspes perque l'examen o la nota de les practiques es inferior a 3");
            }

            notaTotal = 0.8 * notaExamen + 0.2 * notaPractiques;

            if (notaTotal >= 0 && notaTotal < 5)
            {
                resultat = ($"suspes amb la nota {notaTotal}");
            }
            else if (notaTotal < 7)
            {
                resultat = ($"suficient amb la nota {notaTotal}");
            }
            else if (notaTotal < 9)
            {
                resultat = ($"notable amb la nota {notaTotal}");
            }
            else if (notaTotal < 10)
            {
                resultat = ($"excelent amb la nota {notaTotal}");
            }
            else if (notaTotal == 10)
            {
                resultat = ($"matrícula amb la nota {notaTotal}");
            }
            else
            {
               resultat = ($"introdueix un valor valid, el valor introduit es: {notaTotal}");
            }

            return resultat;
        }
    }
}
