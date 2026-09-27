

namespace Joc_de_la_vida
{
    internal class Program
    {
        const bool TAULER_TOROIDAL = false;
        static void Main(string[] args)
        {
            const int AMPLADA = 50;
            const int ALÇADA = 25;
            const int MARGE_ESQUERRE = 4;
            const int MARGE_SUPERIOR = 2;
            const int PERCENTATGE_DE_CASELLES_PLENES = 5;
            const ConsoleColor COLOR_FONS = ConsoleColor.Gray;
            const ConsoleColor COLOR_BUIDA = ConsoleColor.DarkGray;
            const ConsoleColor COLOR_PLENA = ConsoleColor.DarkYellow;
            const char CASELLA = '█';
            ConsoleKey tecla = ConsoleKey.None;
            ConsoleColor fonsOriginal = Console.BackgroundColor;
            ConsoleColor lletraOriginal = Console.ForegroundColor;
            Console.WindowHeight = ALÇADA + MARGE_SUPERIOR * 5;
            Console.WindowWidth = AMPLADA * 2 + MARGE_ESQUERRE * 2;

            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;

            //Declaració del taulell
            List<List<bool>> taulell;
            taulell = new List<List<bool>>();
            int nGeneracio = 0;

            CreaElTaulell(taulell, AMPLADA, ALÇADA);

            InicilitzaElTaulell(taulell, PERCENTATGE_DE_CASELLES_PLENES);
            PintaElTaulell(taulell, COLOR_FONS, COLOR_PLENA, COLOR_BUIDA, CASELLA, MARGE_ESQUERRE, MARGE_SUPERIOR, nGeneracio);
            tecla = Console.ReadKey().Key;
            while (tecla != ConsoleKey.Escape)
            {
                if (tecla == ConsoleKey.R)
                {
                    NetejaElTaulell(taulell);
                    InicilitzaElTaulell(taulell, PERCENTATGE_DE_CASELLES_PLENES);
                    nGeneracio = 0;
                }
                else
                {
                    CalculaLaGeneracioSeguent(taulell);
                    nGeneracio++;
                }

                PintaElTaulell(taulell, COLOR_FONS, COLOR_PLENA, COLOR_BUIDA, CASELLA, MARGE_ESQUERRE, MARGE_SUPERIOR, nGeneracio);
                tecla = Console.ReadKey().Key;
            }

            Console.BackgroundColor = fonsOriginal;
            Console.ForegroundColor = lletraOriginal;
            Console.CursorVisible = true;
        }

        /// <summary>
        /// Crea les List que conformen el taulell
        /// </summary>
        /// <param name="taulell">List que ja ha d'estar creada</param>
        /// <param name="amplada">Número de columnes que ha de tenir el taulell</param>
        /// <param name="alçada">Número de files que ha de tenir el taulell</param>
        private static void CreaElTaulell(List<List<bool>> taulell, int amplada, int alçada)
        {
            taulell.Clear();

            for (int i = 0; i < alçada; i++)
            {
                taulell.Add(new List<bool>());
                for (int j = 0; j < amplada; j++)
                {
                    taulell[i].Add(false);
                }
            }
        }

        /// <summary>
        /// Posa totes les caselles del taulell a fals
        /// </summary>
        /// <param name="taulell">Taulell que ha d'estar ja creat</param>
        private static void NetejaElTaulell(List<List<bool>> taulell)
        {
            for (int i = 0; i < taulell.Count; i++)
            {
                for (int j = 0; j < taulell[i].Count; j++)
                {
                    taulell [i][j] = false;
                }
            }
        }

        /// <summary>
        /// Inicialitza un tauler amb caselles buides i plenes.
        /// Hi haurà aproximadament un PERCENTATGE_DE_CASELLES_PLENES%
        /// de les caselles que estaràn plenes
        /// </summary>
        /// <param name="taulell">taulell ja creat</param>
        private static void InicilitzaElTaulell(List<List<bool>> taulell, int percentatgeDeCasellesPlenes)
        {
            Random rnd = new Random();

            for (int i = 0; i < taulell.Count; i++)
            {
                for (int j = 0; j < taulell[i].Count; j++)
                {
                    taulell[i][j] = (rnd.Next(100) <= percentatgeDeCasellesPlenes);
                }
            }
        }

        /// <summary>
        /// Escriu el taulell a la consola. Si una cel·la conté un false, dibuixa el caràcter
        /// de color buit, i sinó ho fa de color ple.
        /// Com que el caràcter és el doble d'alt que d'ample, sempre dibuixa el caràcter dues 
        /// vegades, així fem que les caselles siguin quadrades.
        /// </summary>
        /// <param name="taulell">Taulell que conté els valors</param>
        /// <param name="colorFons">Color de fons</param>
        /// <param name="colorPlena">Color de les caselles plenes</param>
        /// <param name="colorBuida">Color de les caselles buides</param>
        /// <param name="casella">Caràcter que dibuixarà per a cada casella</param>
        private static void PintaElTaulell(List<List<bool>> taulell, ConsoleColor colorFons, ConsoleColor colorPlena, ConsoleColor colorBuida, char casella, int margeEsquerre, int margeSuperior, int nGeneracio)
        {
            bool estrue = false;
            Console.BackgroundColor = colorFons;
            Console.Clear();


            for (int i = 0; i < taulell.Count; i++)
            {
                Console.SetCursorPosition(margeEsquerre, margeSuperior + i);

                for (int j = 0; j < taulell[i].Count; j++)
                {
                    estrue = taulell[i][j];

                    if (estrue)
                    {
                        Console.ForegroundColor = colorPlena;
                        Console.Write(casella); Console.Write(casella);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = colorBuida;
                        Console.Write(casella); Console.Write(casella);
                        Console.ResetColor();
                    }
                }

                Console.ResetColor();
                Console.WriteLine();
            }

            Console.ResetColor();
            Console.SetCursorPosition(margeEsquerre, margeSuperior + taulell.Count + 1);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"el numero de Generacions que han existit son: {nGeneracio}   ");
            Console.ResetColor();
        }
        /// <summary>
        /// Retorna si una posició està plena
        /// Si la posició cau fora del taulell, retorna fals (cap)
        /// </summary>
        /// <param name="fila">Fila de la posició</param>
        /// <param name="columna">Columna de la posició</param>
        /// <param name="taulell">Taulell on cal mirar la posició</param>
        /// <returns>Si aquesta posició està o no plena (cert o fals)</returns>
        private static bool HiHaVidaALaPosicio(int fila, int columna, List<List<bool>> taulell)
        {
            if (fila < 0 || fila >= taulell.Count) return false;
            if (columna < 0 || columna >= taulell[fila].Count) return false;

            return taulell[fila][columna];
        }

        /// <summary>
        /// Donat un taulell i unes coordades, ens retorna el número de veins de la casella descrita
        /// </summary>
        /// <param name="fila">fila de la casella</param>
        /// <param name="columna">columna de la casella</param>
        /// <param name="taulell">Matriu a on hi ha les dades</param>
        /// <returns>El nombre de veïns de la casella</returns>
        private static int ComptaVeins(int fila, int columna, List<List<bool>> taulell)
        {
            int totalVeins = 0;
            for (int i = fila -1; i <= fila + 1; i++)
            {
                for (int j = columna - 1; j <= columna + 1; j++)
                { 
                    //es podria fer amb un "continue en contes d'un if aniuat"
                    if (j != columna || i != fila)
                    {
                        bool existeix = false;
                        existeix = HiHaVidaALaPosicio(i, j, taulell);

                        if (existeix) totalVeins++;
                    }
                }
            }

            return totalVeins;
        }

        /// <summary>
        /// Copia el contingut de la matriu origen a la matriu destinació. 
        /// Ambdues matrius han d'estar creades
        /// </summary>
        /// <param name="origen">Matriu ja creada que conté les dades a copiar</param>
        /// <param name="destinacio">matriu ja creada a on es copiaran les dades</param>
        private static void CopiaTauler(List<List<bool>> origen, List<List<bool>> destinacio)
        {
            for (int i  = 0; i < origen.Count; i++)
            {
                for (int j = 0; j < origen[i].Count; j++)
                {
                    destinacio[i][j] = origen[i][j];
                }
            }
        }

        /// <summary>
        /// Analiza el taulell i hi calcula la generació següent
        /// </summary>
        /// <param name="taulell"></param>
        private static void CalculaLaGeneracioSeguent(List<List<bool>> taulell)
        {
            int ALÇADAAUX = taulell.Count;
            int  AMPLADAAUX = taulell[0].Count;

            List<List<bool>> taulellOrigen;
            taulellOrigen = new List<List<bool>>();

            CreaElTaulell(taulellOrigen, AMPLADAAUX, ALÇADAAUX);

            for (int i = 0; i < taulell.Count; i++)
            {
                int fila = i;

                for (int j = 0; j < taulell[i].Count; j++)
                {
                    int columna = j;
                    int veins = ComptaVeins(fila, columna, taulell);

                    if (taulell[i][j] == false && veins == 3)
                    {
                        taulellOrigen[i][j] = true;
                    }

                    if (taulell[i][j] == true && (veins > 3 || veins <= 1))
                    {
                        taulellOrigen[i][j] = false;
                    }

                    if (taulell[i][j] == true && (veins == 3 || veins == 2))
                    {
                        taulellOrigen[i][j] = true;
                    }
                }
            }

            CopiaTauler(taulellOrigen, taulell);
        }

    }
}
