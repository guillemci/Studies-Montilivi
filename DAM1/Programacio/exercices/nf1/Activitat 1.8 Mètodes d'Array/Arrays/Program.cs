using System.Net.NetworkInformation;

namespace Arrays
{

    public class MetodesArrays
    {
        public static void Main() { }
        // --- VECTORS ---
        public static int[] OmpleNaturals(int n)
        {
            int[] naturals = new int[n];
            for (int i = 0; i < n; i++)
            {
                naturals[i] = i + 1;
            }
            return naturals;

        }

        public static int[] GeneraTaula(int n, int llavor = 0)
        {
            Random rnd = new Random(llavor);

            int[] newArray = new int[n];

            for (int i = 0; i < n; i++)
                newArray[i] = rnd.Next(-100, 101);

            return newArray;
        }

        public static int SumaTaula(int[] taula)
        {
            int suma = 0;

            for (int i = 0; i < taula.Length; i++)
                suma += taula[i];

            return suma;
        }
        public static int MinimTaula(int[] taula)
        {
            int numeroMesPetit = taula[0];

            for (int i = 0; i < taula.Length; i++)
            {
                if (numeroMesPetit > taula[i])
                    numeroMesPetit = taula[i];
            }

            return numeroMesPetit;
        }
        public static int PosicioMinimTaula(int[] taula)
        {
            int numeroMesPetit = taula[0];
            int indexmespetit = 0;

            for (int i = 0; i < taula.Length; i++)
            {

                if (numeroMesPetit > taula[i])
                {
                    numeroMesPetit = taula[i];
                    indexmespetit = i;
                }
            }

            return indexmespetit;
        }
        public static int MaximTaula(int[] taula)
        {
                int numeroMesGran = taula[0];

                for (int i = 0; i < taula.Length; i++)
                {
                    if (numeroMesGran < taula[i])
                        numeroMesGran = taula[i];
                }

                return numeroMesGran;
        }
        public static double MitjanaTaula(int[] taula)
        {
            double suma = 0;
            double mitjana;

            for (int i = 0; i < taula.Length; i++)
                suma += taula[i];

            mitjana = Math.Round(suma / taula.Length, 0);

            return mitjana;
        }
        public static void CapgiraTaula(int[] taula)
        {
            int valorAuxinici;
            int valorAuxfinal;
            for (int i = 0; i < taula.Length / 2; i++)
            {
                valorAuxfinal = taula[(taula.Length - 1) - i];
                valorAuxinici = taula[i];
                taula[i] = valorAuxfinal;
                taula[(taula.Length - 1) - i] = valorAuxinici;

            }

            for (int i = 0; i < taula.Length; i++)
            {
                Console.WriteLine(taula[i]);
            }
        }

        public static int PosicioDe(int[] t, int valor)
        {
            bool final = false;
            int i = 0;
            int valoractual = t[i];
            while (i < t.Length && !final)
            {
                valoractual = t[i];

                if (valoractual == valor)
                    final = true;
                else
                {
                    i++;
                }
            }

            if (final) return i;
            else return -1;
        }

        public static bool Conte(int[] t, int valor)
        {
            bool final = false;
            int i = 0;
            int valoractual = t[i];

            while (i < t.Length && !final)
            {
                valoractual = t[i];

                if (valoractual == valor)
                    final = true;
                else
                {
                    i++;
                }
            }

            if (final) return true;
            else return false;
        }

        public static bool ConteEnRang(int[] t, int valor, int indexDesDe, int indexFinsA)
        {
            int valorComparar;
            bool final = false;
            while (indexDesDe <= indexFinsA && !final)
            {
                valorComparar = t[indexDesDe];
                if (valorComparar == valor)
                {
                    final = true;
                }
                else
                {
                    indexDesDe++;
                }
            }
            return final;
        }

        public static string TaulaAString(int[] taula)
        {
            string valors = "";

            for (int i = 0; i < taula.Length; i++)
            {
                valors += ($"Index {i}: {taula[i]}");
                if (i < taula.Length - 1) valors += "\n";
            }

            return valors;
        }
        public static int[] ComunsOrdenades(int[] t1, int[] t2) => throw new NotImplementedException();
        public static int[] FusioOrdenades(int[] t1, int[] t2) => throw new NotImplementedException();

        // --- MATRIUS ---
        public static int[,] OmpleMatriuPerFiles(int fila, int columna) => throw new NotImplementedException();
        public static int[,] OmpleMatriuPerColumnes(int fila, int columna) => throw new NotImplementedException();
        public static int[,] OmpleMatriuConsecutius(int fila, int columna) => throw new NotImplementedException();
        public static int[,] OmpleMatriuConsecutiusInvers(int fila, int columna) => throw new NotImplementedException();
        public static int[,] OmpleMatriuIdentitat(int nFiles) => throw new NotImplementedException();
        public static int MinimMatriu(int[,] matriu) => throw new NotImplementedException();
        public static int[] PosicioMinimMatriu(int[,] matriu) => throw new NotImplementedException();
    }
}
