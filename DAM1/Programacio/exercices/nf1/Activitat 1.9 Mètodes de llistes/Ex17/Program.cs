using System.Collections.Generic;

namespace Ex17
{
    internal class Program
    {
        /// <summary>
        /// Exercici 17
        /// Retorna una matriu NxM plena per columnes.
        /// Exemple (nFiles=3, nColumnes=2):
        /// {{1, 2}
        /// {1, 2}
        /// {1, 2}}
        /// </summary>
        static void Main(string[] args)
        {
            int n = 3;
            int m = 2;

            List<List<int>> matriuRetornat = OmplirMatriuPerColumnes(n, m);

            Console.WriteLine("matriu retornada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriuRetornat[i][j]} ");
                }
                Console.WriteLine();
            }

        }

        public static List<List<int>> OmplirMatriuPerColumnes(int n, int m)
        {
            List<List<int>> matriu = new List<List<int>>();
            
            for (int i = 0; i < n ; i++)
            {
                matriu.Add(new List<int>());
            }

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    matriu[i].Add(j + 1);
                }
            }
            return matriu;
        }
    }
}
