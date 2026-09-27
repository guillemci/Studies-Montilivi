namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// 6. Feu un programa que llegeixi (per aquest ordre), nom d’equip local, gols fets per
        ///l’equip local, nom d’equip visitant, gols fets per l’equip visitant.El programa ha
        ///d’informar de qui ha guanyat o bé si han empatat i el número de gols amb un missatge
        ///de l’estil: “El Girona FC ha guanyat al Barcelona FC amb un resultat de 4 a 1”
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            string equipLocal_;
            int golsLocal_;
            string equipVisitant_;
            int golsVisitant_;
            string resultat;

            //inicialitzacio de variable
            Console.WriteLine("Introdueix nom equip local");
            equipLocal_ = Console.ReadLine();

            Console.WriteLine("nombre gols equip local");
            golsLocal_ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introdueix nom equip visitant");
            equipVisitant_ = Console.ReadLine();

            Console.WriteLine("nombre de gols equip visitant");
            golsVisitant_ = Convert.ToInt32(Console.ReadLine());

            //calcul dints funcio
            resultat = ConsolePrintGuanyador(equipLocal_, golsLocal_, equipVisitant_, golsVisitant_);

            //output
            Console.WriteLine(resultat);
        }

        public static string ConsolePrintGuanyador(string equipLocal, int golsLocal, string equipVisitant, int golsVisitant)
        {
            string resultat;

            //condicional
            if (golsLocal > golsVisitant)
            {
               return resultat = ($"l'equip local {equipLocal} a guanyat a {equipVisitant} amb una puntuació de:\n({equipLocal}:{golsLocal}|{equipVisitant}:{golsVisitant})");
            }
            else if (golsLocal < golsVisitant)
            {
                return resultat = ($"l'equip local {equipVisitant} a guanyat a {equipLocal} amb una puntuació de:\n({equipLocal}:{golsLocal}|{equipVisitant}:{golsVisitant})");
            }
            else
             {
                return resultat = ($"l'equip local {equipLocal} a empatat amb {equipVisitant} amb una puntuació de:\n({equipLocal}:{golsLocal}|{equipVisitant}:{golsVisitant})");
             }
        }
    }
}
