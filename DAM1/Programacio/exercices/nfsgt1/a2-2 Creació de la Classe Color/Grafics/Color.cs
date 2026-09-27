using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Grafics
{
    public class Color
    {
        #region "Exercici 1"
        private const int NUM_CANALS = 4;
        private const int NUM_DEFECTE_PR = 256;

        private int[] valorsCanal;
        private bool transparent;
        private int profunditat;
        #endregion

        #region "Exercici 2"
        //valida valors valids utilitzant profunditat
        private bool ValidaValor(int valor)
        {
            if (valor < 0 || valor >= this.profunditat)
                throw new ArgumentException("valor Incorrecte");

            return true;
        }

        // serveix per agafar valors del get
        private void ValidaIndexExternament(int index)
        {
            if ((this.transparent && (index < 0 || index >= NUM_CANALS)) ||
                (!this.transparent && (index <= 0 || index >= NUM_CANALS)))
                throw new IndexOutOfRangeException("index fora de rang");
        }

        //facilita la validacio del index en el private set, no es utilitzat publicament
        private void ValidaIndexInternament(int index)
        {
            if (index < 0 || index >= NUM_CANALS)
                throw new IndexOutOfRangeException("index fora de rang");
        }

        //valida length del array independentment de la transparencia (la transparencia es gestiona en el metode)
        private void ValidaLength(int totalindex)
        {
            if (NUM_CANALS != totalindex && NUM_CANALS - 1 != totalindex)
                throw new IndexOutOfRangeException("length incorrecte");
        }

        //valida length del string hexadecimal
        private static void ValidaLengthHexa(int totalindex)
        {
            if (6 != totalindex && 8 != totalindex)
                throw new IndexOutOfRangeException("length hexadecimal invalida");
        }
        #endregion

        #region "Exercici 3"

        //mante unida tota la logica del constructor
        private void MontarThisArray(int[] valorsCanal, bool transparent)
        {
            this.valorsCanal = new int[NUM_CANALS];

            if (valorsCanal != null)
            {
                ValidaLength(valorsCanal.Length);

                // nomes 3 canals
                if (valorsCanal.Length == NUM_CANALS - 1)
                {
                    for (int i = 0; i < valorsCanal.Length; i++)
                    {
                        ValidaValor(valorsCanal[i]);
                        this.valorsCanal[i + 1] = valorsCanal[i];
                    }
                }
                //4 canals
                if (valorsCanal.Length == NUM_CANALS)
                {
                    for (int i = 0; i < valorsCanal.Length; i++)
                    {
                        ValidaValor(valorsCanal[i]);
                        this.valorsCanal[i] = valorsCanal[i];
                    }
                }
            }
            else
            {
                //en cas de null negre
                for (int i = 0; i < NUM_CANALS; i++)
                    this.valorsCanal[i] = 0;
            }

            //gestor transparencia, tots els que tinguin transparencia false, encara que siguin de 4 posicions s'els hi posara la profunditat maxima al alpha
            if (!this.transparent)
                this.valorsCanal[0] = this.profunditat - 1;
        }

        //constructors
        public Color(int[] valorsCanal, bool transparent, int profunditat) //array valors amb bool i profunditat
        {
            this.profunditat = profunditat;
            this.transparent = transparent;
            MontarThisArray(valorsCanal, transparent);
        }

        public Color(int a, int r, int g, int b, bool transparent, int profunditat) //ints separats amb bool transparent i profunditat
        {
            this.profunditat = profunditat;
            this.transparent = transparent;
            int[] valorsCanalAuto = new int[] { a, r, g, b };
            MontarThisArray(valorsCanalAuto, transparent);
        }

        //secundaris

        //Afegit NUM_DEFECTE_PR degut a que la profunditat es pot modificar pero oferint l'opcio default "256" que es NUM_DEFECTE_PR
        public Color(int a, int r, int g, int b, bool transparent) : this(a, r, g, b, transparent, NUM_DEFECTE_PR) { } //ints separats amb bool transparent
        public Color(int[] valorsCanal, bool transparent) : this(valorsCanal, transparent, NUM_DEFECTE_PR) { } //valors en array i bool transparent
        public Color(int[] valorsCanal) : this(valorsCanal, false, NUM_DEFECTE_PR) { } //valors canal unicament
        public Color(bool transparent) : this([NUM_DEFECTE_PR - 1, NUM_DEFECTE_PR - 1, NUM_DEFECTE_PR - 1, NUM_DEFECTE_PR - 1], transparent, NUM_DEFECTE_PR) { } //unicament transparencia
        public Color() : this([NUM_DEFECTE_PR - 1, NUM_DEFECTE_PR - 1, NUM_DEFECTE_PR - 1, NUM_DEFECTE_PR - 1], false, NUM_DEFECTE_PR) { } //ningun valor pasat
        public Color(int profunditat) : this([profunditat - 1, profunditat - 1, profunditat - 1, profunditat - 1], false, profunditat) { } //unicament profunditat
        public Color(bool transparent, int profunditat) : this([profunditat - 1, profunditat - 1, profunditat - 1, profunditat - 1], transparent, profunditat) { } //unicament bool transparencia i profunditat

        #endregion

        #region "Exercici 4"
        public bool TeTransparencia
        {
            set
            {
                if (this.transparent && !value)
                    this.valorsCanal[0] = this.profunditat - 1;

                this.transparent = value;
            }
            get { return transparent; }
        }

        public int ProfunditatDeColor
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("valor Incorrecte");

                for (int i = 0; i < NUM_CANALS; i++)
                    this.valorsCanal[i] = this.valorsCanal[i] * value / this.profunditat;

                this.profunditat = value;

                //if (valorsCanal[0] == 98)
                //    throw new ArgumentException($"valor {valorsCanal[0]}");
            }

            get { return this.profunditat; }
        }
        #endregion

        #region "Exercici 5"
        public int this[int index]
        {
            get
            {
                int realIndex = index;
                if (!transparent) realIndex += 1;
                ValidaIndexExternament(realIndex);
                return this.valorsCanal[realIndex];
            }

            private set
            {
                ValidaIndexInternament(index);
                ValidaValor(value);
                this.valorsCanal[index] = value;
            }
        }

        #endregion

        #region "Exercici 6"
        public static Color Vermell
        {
            get
            {
                Color vermell = new Color([255, 255, 0, 0]);
                return vermell;
            }
        }

        public static Color Blau
        {
            get
            {
                Color verd = new Color([255, 0, 0, 255]);
                return verd;
            }
        }

        public static Color Verd
        {
            get
            {
                Color verd = new Color([255, 0, 255, 0]);
                return verd;
            }
        }
        public static Color Negre
        {
            get
            {
                Color negre = new Color([255, 0, 0, 0]);
                return negre;
            }
        }

        public static Color Transparent
        {
            get
            {
                Color Transparent = new Color([0, 0, 0, 0], true);
                return Transparent;
            }
        }
        #endregion

        #region "Exercici 7"
        public int ObtenCanal(int index)
        {
            //ValidaIndex(index);
            //return valorsCanal[index];
            int realIndex = index;
            if (!transparent) realIndex += 1;
            ValidaIndexExternament(realIndex);
            return this.valorsCanal[realIndex];
        }

        public Color Inverteix()
        {
            int a = this.valorsCanal[0];
            int r = (this.profunditat - 1) - this.valorsCanal[1];
            int g = (this.profunditat - 1) - this.valorsCanal[2];
            int b = (this.profunditat - 1) - this.valorsCanal[3];
            return new Color(a, r, g, b, this.transparent, this.profunditat);
        }

        public Color A_EscalaDeGrisos()
        {
            int alpha = this.valorsCanal[0];
            int mitjana = (this.valorsCanal[1] + this.valorsCanal[2] + this.valorsCanal[3]) / 3;

            return new Color(alpha, mitjana, mitjana, mitjana, this.transparent, this.profunditat);
        }
        #endregion

        #region "Exercici 8"
        public override string ToString()
        {
            if (this.transparent)
                return $"ARGB: [{this.valorsCanal[0]}, {this.valorsCanal[1]}, {this.valorsCanal[2]}, {this.valorsCanal[3]}] PROFUNDITAT: {this.profunditat} TRANSPARENCIA: {this.transparent}";
            else
                return $"RGB: [{this.valorsCanal[1]}, {this.valorsCanal[2]}, {this.valorsCanal[3]}] PROFUNDITAT: {this.profunditat} TRANSPARENCIA: {this.transparent}";
        }

        public static bool Equals(Color c1, Color c2)
        {
            bool retornar;

            if (c1 is null && c2 is null) retornar = true;
            else if (c1 is null || c2 is null) retornar = false;
            else retornar = c1.Equals(c2);


            return retornar;
        }

        public override bool Equals(object? obj)
        {
            bool iguals = true;
            int i = 0;

            if (obj == null)
                iguals = this is null;
            else if (obj is Color aux)
            {
                while (i < NUM_CANALS && iguals)
                {
                    iguals = aux.valorsCanal[i] == this.valorsCanal[i];
                    i++;
                }
            }
            else
            {
                iguals = false;
            }

            return iguals;
        }
        #endregion

        #region "Exercici 9"
        public static Color operator +(Color c1, Color c2)
        {
            int novaProfunditatColor = (c1.ProfunditatDeColor + c2.ProfunditatDeColor) / 2;

            bool determinarBool = c1.transparent || c2.transparent;

            Color colorAux = new Color(determinarBool, novaProfunditatColor);

            for (int i = 1; i < NUM_CANALS; i++)
            {
                if (c1.valorsCanal[i] + c2.valorsCanal[i] >= novaProfunditatColor)
                    colorAux[i] = novaProfunditatColor - 1;
                else
                    colorAux[i] = c1.valorsCanal[i] + c2.valorsCanal[i];
            }

            colorAux[0] = (c1.valorsCanal[0] + c2.valorsCanal[0]) / 2;

            return colorAux;
        }

        //logica necesaria en cas de que no existis validacio interna i el private set no tingues una logica diferent
        //for (int i = 1; i<c1.valorsCanal.Length; i++)
        //{
        //  if (!(c1.valorsCanal[controladorDeIndex1 - i] + c2.valorsCanal[controladorDeIndex2 - i] > novaProfunditatColor))
        //      colorAux[i] = novaProfunditatColor - 1;
        //  else
        //      colorAux[i] = c1.valorsCanal[controladorDeIndex1 - i] + c2.valorsCanal[controladorDeIndex2 - i];
        //}

        public static Color operator +(Color color, int valor)
        {
            Color colorAux = new Color(color.transparent, color.profunditat);

            for (int i = 1; i < NUM_CANALS; i++)
            {
                if (color[i] + valor >= colorAux.ProfunditatDeColor)
                    colorAux[i] = colorAux.ProfunditatDeColor - 1;
                else
                    colorAux[i] = color[i] + valor;
            }

            colorAux[0] = color[0];

            return colorAux;
        }

        public static bool operator ==(Color c1, Color c2)
        {
            return Color.Equals(c1, c2);
        }

        public static bool operator !=(Color c1, Color c2)
        {
            return !Color.Equals(c1, c2);
        }

        #endregion

        #region "Exercici 10"

        public static implicit operator Color(int origen)
        {
            int[] array = new int[] {origen - 1, origen - 1, origen - 1, origen - 1 };
            Color colorAux = new Color(array, true, origen);

            return colorAux;
        }

        public static explicit operator int(Color color)
        {
            int colorAEnter;

            if (color.transparent)
                colorAEnter = (color[1] + color[2] + color[3]) / 3;
            else
                colorAEnter = (color[0] + color[1] + color[2]) / 3;


            return colorAEnter;
        }

        public static implicit operator Color(string origenString)
        {

            if (origenString[0] == '#')
            {
                StringBuilder sb = new StringBuilder(origenString);
                sb.Remove(0, 1);
                origenString = sb.ToString();
            }

            bool transparencia;
            int[] arrayAux = new int[4];
            ValidaLengthHexa(origenString.Length);
            int arrayIndex = 0; //serveix unicament per recorrer l'array de forma independent a la logica del for no força el for de cap manera

            if (origenString.Length == 8)
            {
                arrayIndex = ConstructorArrayHexa(origenString, arrayAux, arrayIndex);
            }
            else
            {
                arrayIndex = 1;
                arrayIndex = ConstructorArrayHexa(origenString, arrayAux, arrayIndex);
            }

            if (origenString.Length == 8)
                transparencia = true;
            else
                transparencia = false;


            return new Color(arrayAux, transparencia);
        }

        private static int ConstructorArrayHexa(string origenString, int[] arrayAux, int arrayIndex)
        {
            for (int i = 0; i <= origenString.Length - 2; i += 2)
            {
                string fragmentHexString = (origenString.Substring(i, 2));
                int fragmentHexDecimal = Convert.ToByte(fragmentHexString, 16);
                arrayAux[arrayIndex] = fragmentHexDecimal;
                arrayIndex++;
            }

            return arrayIndex;
        }
        #endregion
    }
}
