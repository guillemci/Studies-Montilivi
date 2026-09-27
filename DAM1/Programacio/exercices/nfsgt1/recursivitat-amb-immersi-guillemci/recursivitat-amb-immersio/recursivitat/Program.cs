namespace recursivitat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(7));
            Console.WriteLine(primer(29));
            Console.WriteLine(triangular(21));
            Console.WriteLine(Perfecte(496));
            Console.WriteLine(Capgirar(204));
            Console.WriteLine(ProducteEscalar([1, 3, 5], [2, 4, 6]));
            Console.WriteLine(MaximValorArray([1, 9, 6]));
            Console.WriteLine(MesLlargSumaZero([1, 2, -3, 4, -4]));
            Console.WriteLine(Ordenat([1, 2, 3, 4]));
            Console.WriteLine(Ordenat([4, 3, 2, 1]));
            Console.WriteLine(CapICua([1, 2, 2, 1]));
            Console.WriteLine(SumaElementsProcedents([1, 2, 3, 216, 101]));
            Console.WriteLine(BuscarElement([2, 5, 3], 7));
            List<int> llista = ComunsOrdenatsCreixent([1, 2, 3, 4, 5, 6, 7], [3, 4, 6, 9]);

            foreach (var element in llista)
                Console.WriteLine(element);
        }

        static int Fibonacci(int numero)
        {
            int resultat;

            if (numero < 0)
                throw new ArgumentException("no es pot");
            else if (numero < 2)
                resultat = numero;
            else
                resultat = FibonacciImmersio(numero, 2, 0, 1);

            return resultat;
        }

        static int FibonacciImmersio(int numero, int index, int a, int b)
        {
            int resultatBrutal;
            int seguent = a + b;

            if (index == numero)
                resultatBrutal = seguent;
            else
                resultatBrutal = FibonacciImmersio(numero, index + 1, b, seguent);

            return resultatBrutal;
        }

        /// <summary>
        /// Un número és primer si té estrictament dos divisors. Dissenyeu una funció que ens digui si un número és primer.
        /// </summary>
        static bool primer(int numero)
        {
            int indexfinal = numero / 2;
            bool resultat;
            if (numero <= 1) resultat = false;
            else if (numero == 2) resultat = true;
            else
            { 
                resultat = ImmersioPrimer(numero, indexfinal, 2);
            }

            return resultat;
        }
        
        static bool ImmersioPrimer(int numero, int indexfinal, int index)
        {
            bool trovat = true;

            if (numero % index == 0)
                trovat = false;


            if (trovat && index < indexfinal)
            {
                trovat = ImmersioPrimer(numero, indexfinal, index + 1);
            }
                 
            return trovat;
        }

        /// <summary>
        /// Un número és triangular quan es pot expressar com la suma de naturals consecutius a 
        /// partir de l’1. Ex: 6 = 1 + 2 + 3; 10 = 1 + 2 + 3 + 4. Feu una funció recursiva que 
        /// donat un número natural, ens digui si és triangular.
        /// </summary>
        static bool triangular(int numero)
        {
            bool trovat;
            if (numero < 1)
                trovat = false;
            else
                trovat = ImmersioTriangular(numero, 1, 0);

            return trovat;
        }

        static bool ImmersioTriangular(int numero, int index, int acomulat)
        {
            bool trovat;
            int nouacomulat = index + acomulat;
            if (numero == nouacomulat)
                trovat = true;
            else if (numero > nouacomulat)
                trovat = ImmersioTriangular(numero, index + 1, nouacomulat);
            else
                trovat = false;

            return trovat;
        }

        /// <summary>
        /// Un número és perfecte si és igual a la suma de 
        /// tots els seus divisors (sense comptar-se ell mateix, és clar). 
        /// Dissenyeu una funció que ens digui si un nombre és perfecte.
        /// </summary>
        static bool Perfecte(int numero)
        {
            bool trovat;
            if (numero <= 1)
                trovat = false;
            else
                trovat = immersioPerfecte(numero, 1, 0);

            return trovat;
        }

        static bool immersioPerfecte(int numero, int index, int valoracomulat)
        {
            bool trovat;
            int nouvaloracomulat = valoracomulat;

            if (numero % index == 0)
                nouvaloracomulat += index;

            if (nouvaloracomulat == numero)
                trovat = true;
            else if (nouvaloracomulat < numero)
                trovat = immersioPerfecte(numero, index + 1, nouvaloracomulat);
            else
                trovat = false;

            return trovat;
        }

        /// <summary>
        /// Dissenyeu una funció que capgiri un número enter (sense fer servir strings)
        /// </summary>
        static int Capgirar(int numero)
        {
            return CapgirarImmersio(numero, 0);
        }

        static int CapgirarImmersio(int numero, int numerocapgirant)
        {
            int nounumerocapgirant = numerocapgirant;

            if (numero != 0)
                nounumerocapgirant = CapgirarImmersio(numero / 10, nounumerocapgirant * 10 + (numero % 10));

            return nounumerocapgirant;
        }

        /// <summary>
        /// Feu una funció que retorni el valor màxim d’un vector d’enters.
        /// </summary>
        static int MaximValorArray(int[] array)
        {
            return ImmersioMaximValorArray(array, array[0], 1);
        }

        static int ImmersioMaximValorArray(int[] array, int maxim, int index)
        {
            int noumaxim = maxim;

            if (index < array.Length)
            {
                if (array[index] > maxim)
                    noumaxim = array[index];
                noumaxim = ImmersioMaximValorArray(array, noumaxim, index + 1);
            }

            return noumaxim;
        }


        /// <summary>
        /// Dissenyeu un algorisme recursiu que calculi el producte escalar de dos vectors d’enters a[1:n] i b[1:n] amb n ≥ 0.
        /// </summary>
        static int ProducteEscalar(int[] array1, int[] array2)
        {
            return ImmersioProductEescalar(array1, array2, 0);
        }

        static int ImmersioProductEescalar(int[] array1, int[] array2, int index)
        {
            int resultat = 0;
            if (index < array1.Length && index < array2.Length)
            {
                resultat = array1[index] * array2[index];
                resultat+= ImmersioProductEescalar(array1, array2, index + 1);
            }

            return resultat;
        }

        /// <summary>
        /// Dissenyeu un algorisme recursiu que donat un vector d’enters i 
        /// un enter x, torni la posició on es troba x dins del vector (-1 si no hi és).
        /// </summary>
        static int BuscarElement(int[] array, int buscar)
        {
            return ImmersioBuscarElement(array, 0, buscar);
        }

        static int ImmersioBuscarElement(int[] array, int index, int buscar)
        {
            int trovat = 0;
            if (index < array.Length)
            {
                if (array[index] != buscar)
                    trovat = ImmersioBuscarElement(array, index + 1, buscar);
                else
                    trovat = index + 1;
            }

            return trovat;
        }

        /// <summary>
        /// Fer una funció recursiva que ens digui si algun 
        /// element d’un vector coincideix amb la suma dels elements que el precedeixen.
        /// </summary>
        static bool SumaElementsProcedents(int[] array)
        {
            bool trovat;
            if (array.Length <= 1)
                trovat = true;

            trovat = ImmersioSumaElementsProcedents(array, 1, array[0]);

            return trovat;
        }

        static bool ImmersioSumaElementsProcedents(int[] array, int index, int valorsumat)
        {
            int nouvalorsumat = valorsumat;
            bool iguals = false;

            if (index < array.Length)
            {
                iguals = nouvalorsumat == array[index];
                nouvalorsumat += array[index];

                if (!iguals)
                    iguals = ImmersioSumaElementsProcedents(array, index + 1, nouvalorsumat);
            }

            return iguals;
        }

        /// <summary>
        /// Fer una funció recursiva que digui si un vector és cap-i-cua. 
        /// Un vector és capicua si els elements equidistants dels extrems són iguals
        /// </summary>
        static bool CapICua(int[] array)
        {
            return CapICuaImmersio(array,0,array.Length-1,true);
        }

        static bool CapICuaImmersio(int[] array, int index1, int index2, bool capicua)
        {
            bool escapicua = capicua;
            if (index1 <= index2 && capicua)
            {
                escapicua = array[index1] == array[index2];
                escapicua = CapICuaImmersio(array, index1 + 1, index2 - 1, escapicua);
            }

            return escapicua;
        }

        /// <summary>
        /// Dissenyeu un algorisme recursiu que donat un vector d’enters sense repetits, 
        /// decideixi si el vector està ordenat. Pot estar ordenat de manera creixent o decreixent.
        /// </summary>
        static bool Ordenat(int[] array1)
        {
            return ImmersioOrdenat(array1, 0, false, false);
        }

        static bool ImmersioOrdenat(int[] array1, int index, bool llistamesgrans, bool llistamespetits)
        {
            bool nouordenacioMesGranAPetit = llistamesgrans;
            bool nouordenacioMesPetitGran = llistamespetits;
            bool ordenats = !nouordenacioMesGranAPetit || !nouordenacioMesPetitGran;


            if (index < array1.Length - 1 && (ordenats))
            {
                if (array1[index] < array1[index + 1])
                    nouordenacioMesGranAPetit = true;
                
                if (array1[index] > array1[index + 1])
                    nouordenacioMesPetitGran = true;

                ordenats = ImmersioOrdenat(array1, index + 1, nouordenacioMesGranAPetit, nouordenacioMesPetitGran);
            }

            return ordenats;
        }

        /// <summary>
        /// Feu una funció recursiva que donat un vector V d’enters, digui quina és la longitud del prefix més 
        /// llarg que suma zero. Si no n’hi ha cap, 
        /// la funció retornarà 0. S’entén per prefix qualsevol subvector de V que comenci per V[0].
        /// </summary>
        static int MesLlargSumaZero(int[] array)
        {
            return MesLlargSumaZeroImmersio(array, 0, 0, 0);
        }

        static int MesLlargSumaZeroImmersio(int[] array, int index, int valorAcomulat, int trovat)
        {
            int noutrovat = trovat;
            int nouValorAcomulat;

            if (index < array.Length)
            {
                nouValorAcomulat = valorAcomulat + array[index];

                if (nouValorAcomulat == 0)
                    noutrovat = index + 1;

                trovat = MesLlargSumaZeroImmersio(array, index + 1, nouValorAcomulat, noutrovat);
            }


            return trovat;
        }

        /// <summary>
        /// Dissenyeu un algorisme recursiu que donats dos vectors 
        /// d’enters ordenats creixentment, a[1:n] i b[1:m] amb n i m diferents, n ≥ 0 i m ≥ 0, 
        /// que representen dos conjunts d’enters, retorni una llista d'enters amb els elements comuns a les dues taules.
        /// </summary>

        static List<int> ComunsOrdenatsCreixent(int[] array1, int[]array2)
        {
            List<int> elementsComuns = new List<int>();
            ImmersioComunsOrdenatsCreixent(array1, array2, 0, 0, elementsComuns);
            return elementsComuns;
        }

        static void ImmersioComunsOrdenatsCreixent(int[] array1, int[] array2, int index1, int index2, List<int> listfinal)
        {
            if (index1 < array1.Length && index2 < array2.Length)
            {
                if (array1[index1] == array2[index2])
                {
                    listfinal.Add(array1[index1]);
                    ImmersioComunsOrdenatsCreixent(array1, array2, index1 + 1, index2 + 1, listfinal);
                }
                else if (array1[index1] < array2[index2])
                {
                    ImmersioComunsOrdenatsCreixent(array1,array2,index1 + 1,index2, listfinal);
                }
                else
                {
                    ImmersioComunsOrdenatsCreixent(array1 ,array2 ,index1 ,index2 + 1, listfinal);
                }
            }
        }
    }
}