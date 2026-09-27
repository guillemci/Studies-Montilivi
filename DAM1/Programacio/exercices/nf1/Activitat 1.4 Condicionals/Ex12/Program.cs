namespace Ex12
{
    internal class Program
    {
        /// <summary>
        /// 12. Feu un programa que, a partir d’un any entrat per teclat, t’informi si l’any és de
        ///traspàs o no ho és.Un any és de traspàs si és divisible per 4 i no ho és per 100, a
        ///excepció dels anys divisibles per 400, que també són de traspàs(per exemple l’any 2000
        ///va ser de traspàs perquè era divisible per 400 tot i també ser-ho per 100).
        ///Comprova si aquest curs conté algun any de traspàs!
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int anyProporcionat;
            string resultatComprovador;

            //inicialitzacio
            Console.WriteLine("Introdueix l'any per saber si es de transpas");
            anyProporcionat = Convert.ToInt32(Console.ReadLine());

            //calcul funcio
            resultatComprovador = ComprovadorAnyDeTraspas(anyProporcionat);

            //output
            Console.WriteLine(resultatComprovador);
        }

        static string ComprovadorAnyDeTraspas(int anyProporcionat_)
        {
            string resultat;

            //condicional
            if (anyProporcionat_ % 4 == 0 && anyProporcionat_ % 100 != 0)
            {
                resultat = ($"l'any proporcionat, el qual es {anyProporcionat_} es de traspàs ja que es divisible entre 4 i no o es entre 100");
            }
            else if (anyProporcionat_ % 400 == 0)
            {
                resultat = ($"l'any proporcionat, el qual es {anyProporcionat_} es de traspàs ja que es divisible entre 400");
            }
            else
            {
                resultat = ($"l'any proporcionat, el qual es {anyProporcionat_} no es de traspàs");
            }
            return resultat;
        }
    }
}
