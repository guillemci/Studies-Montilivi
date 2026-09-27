using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace Mètodes_d_extensió_i_funcions_lambda
{
    public static class Extensions
    {
        #region funcionsmeves
        public static int Quadrat(this int n)
        {
            return n * n;
        }
        public static bool EsMajuscula(this char cara)
        {
            return cara >= 'A' && cara <= 'Z';
        }
        public static bool EsMinuscula(this char cara)
        {
            return cara >= 'a' && cara <= 'z';
        }
        public static char AMajuscula(this char cara)
        {
            return char.ToUpper(cara);
        }
        public static char AMinuscula(this char cara)
        {
            return char.ToLower(cara);
        }
        #endregion

        #region funcionschar
        public static int ToInt(this char cara)
        {
            return (cara.EsNumero()) ? cara - '0' : -1;
        }

        public static bool EsVocal(this char cara)
        {
            string caracters = "aeiouàáèéìíòóúùü";
            return caracters.Contains(char.ToLower(cara));
        }

        public static bool EsConsonant(this char cara)
        {
            string caracters = "qwrtypsdfghjklzxcvbnmçñ";
            return caracters.Contains(char.ToLower(cara));
        }

        public static bool EsNumero(this char digit)
        {
            return digit >= '0' && digit <= '9';
        }

        public static string Repeteix(this char cara, int vegades)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0;  i < vegades; i++)
                sb.Append(cara);
            return sb.ToString();
        }

        public static char InvertirMajusculesMinuscules(this char cara)
        {
            char convertit = cara;
            if (convertit.EsMinuscula())
                convertit = char.ToUpper(cara);
            else if (convertit.EsMajuscula())
                convertit = char.ToLower(cara);

            return convertit;
        }

        public static int ToAscii(this char cara)
        {
            return (int)cara;
        }

        public static bool EsDinsDelRang(this char cara,char inici, char final)
        {
            return cara >= inici && cara <= final;
        }

        public static char LletraSeguent(this char cara)
        {
            char resultat = cara;

            if (cara.EsMinuscula())
                resultat = (cara == 'z') ? 'a' : (char)(cara + 1);
            else if (cara.EsMajuscula())
                resultat = (cara == 'Z') ? 'A' : (char)(cara + 1);

            return resultat;
        }
        #endregion

        #region funcionsint
        public static bool EstaEntre(this int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }

        public static bool EsPositiu(this int valor)
        {
            return valor > 0;
        }

        public static bool EsNegatiu(this int valor)
        {
            return valor < 0;
        }

        public static int ToValorAbsolut(this int valor)
        {
            return (valor < 0) ? -valor : valor;
        }

        public static bool EsMultipleDe(this int valor, int divisor)
        {
            //faig try catch perque el enunciat sembla dir gestiona error
            //try
            //{
            //    return valor % divisor == 0;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("no es pot fer X % 0");
            //    return false;
            //}
            bool EsMultiple = false;
            if (divisor == 0)
                EsMultiple = false;
            else
                EsMultiple = valor % divisor == 0;

            return EsMultiple;
        }

        public static int Clamp(this int valor, int min, int max)
        {
            if (min > max)
                throw new ArgumentException("min no pot ser més gran que max");

            if (valor < min)
                valor = min;

            if (valor > max)
                valor = max;

            return valor;
        }

        public static bool EsPrimer(this int valor)
        {
            bool esPrimer = true;

            if (valor <= 1)
                esPrimer = false;
            else
            {
                int i = 2;

                while (i * i <= valor && esPrimer)
                {
                    if (valor % i == 0)
                        esPrimer = false;
                    i++;
                }
            }

            return esPrimer;
        }
        public static TimeSpan Segons(this int valor)
        {
            return TimeSpan.FromSeconds(valor);
        }

        public static TimeSpan Minuts(this int valor)
        {
            return TimeSpan.FromMinutes(valor);
        }

        public static TimeSpan Hores(this int valor)
        {
            return TimeSpan.FromHours(valor);
        }

        public static TimeSpan Dies(this int valor)
        {
            return TimeSpan.FromDays(valor);
        }

        public static TimeSpan Setmanes(this int valor)
        {
            return TimeSpan.FromDays(valor * 7);
        }
        #endregion

        #region funcionsstring
        public static bool EsNumeric(this string cadena)
        {
            //fer el meu is null or empty
            if (string.IsNullOrEmpty(cadena))
                return false;

            bool esNumeric = true;

            int i = 0;
            while (esNumeric && i < cadena.Length)
            {
                esNumeric = cadena[i].EsNumero();
                i++;
            }

            return esNumeric;
        }

        public static string Trunca(this string cadena, int max)
        {
            StringBuilder sr = new StringBuilder();
            string resultat = cadena;

            if (!string.IsNullOrEmpty(cadena) && cadena.Length > max)
            {
                for (int i = 0; i < max; i++)
                    sr.Append(cadena[i]);

                sr.Append("...");
                resultat = sr.ToString();
            }

            return resultat;
        }

        public static string Capitalitza(this string cadena)
        {
            //crear el meu propi IsNull
            if (string.IsNullOrEmpty(cadena))
                return cadena;

            StringBuilder sr = new StringBuilder();
            sr.Append(cadena[0].AMajuscula());
            for (int i = 1; i < cadena.Length; i++)
                sr.Append(cadena[i].AMinuscula());

            return sr.ToString();
        }
        public static string ExtreuDigits(this string cadena)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cadena.Length; i++)
                if (cadena[i].EsNumero())
                    sb.Append(cadena[i]);

            return sb.ToString();
        }

        public static bool Conte(this string cadena, char carbuscar)
        {
            bool trovat = false;
            int i = 0;
            while (i < cadena.Length && !trovat)
            {
                trovat = cadena[i] == carbuscar;
                i++;
            }

            return trovat;
        }

        public static bool EsCorreuElectronic(this string cadena)
        {
            return cadena.Conte('@') && cadena.Conte('.');
        }

        public static string Inverteix(this string cadena)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = cadena.Length - 1; i >= 0; i--)
                sb.Append(cadena[i]);

            return sb.ToString();
        }

        #endregion

        #region funcionsdatetime
        public static bool EsCapDeSetmana(this DateTime data)
        {
            return data.DayOfWeek == DayOfWeek.Sunday || data.DayOfWeek == DayOfWeek.Saturday;
        }

        public static bool EsEntreSetmana(this DateTime data)
        {
            return !(data.DayOfWeek == DayOfWeek.Sunday || data.DayOfWeek == DayOfWeek.Saturday);
        }

        public static int IniciDeMesSetmana(this DateTime data)
        {
            DateTime dt = new DateTime(data.Year, data.Month, 1);
            return (int)dt.DayOfWeek;
        }

        public static int FinalDeMesSetmana(this DateTime data)
        {
            DateTime dt = new DateTime(data.Year, data.Month, 1).AddMonths(1);
            dt = dt.AddDays(-1);

            return (int)dt.DayOfWeek;

        }

        public static int IniciDeMes(this DateTime data)
        {
            DateTime dt = new DateTime(data.Year, data.Month, 1);
            return dt.Day;
        }

        public static int FiDeMes(this DateTime data)
        {
            DateTime dt = new DateTime(data.Year, data.Month, 1).AddMonths(1);
            dt = dt.AddDays(-1);

            return dt.Day;

        }

        public static DateTime SeguentDiaFeiner(this DateTime data)
        {
            DateTime seguent = data.AddDays(1);

            while (seguent.DayOfWeek == DayOfWeek.Saturday || seguent.DayOfWeek == DayOfWeek.Sunday)
            {
                seguent = seguent.AddDays(1);
            }

            return seguent;
        }

        public static DateTime AfegeixDiesFeiners(this DateTime data, int n)
        {
            DateTime resultat = data;
            int afegits = 0;

            while (afegits < n)
            {
                resultat = resultat.AddDays(1);

                if (resultat.DayOfWeek != DayOfWeek.Saturday &&
                    resultat.DayOfWeek != DayOfWeek.Sunday)
                {
                    afegits++;
                }
            }

            return resultat;
        }

        public static int CalculaEdat(this DateTime data)
        {
            DateTime avui = DateTime.Today;

            int edat = avui.Year - data.Year;

            if (avui.Month < data.Month ||
               (avui.Month == data.Month && avui.Day < data.Day))
            {
                edat--;
            }

            return edat;
        }
        #endregion

        #region funcionsEnumerables
        public static bool EsBuida<T>(this IEnumerable<T> col)
        {
            return !col.GetEnumerator().MoveNext();
        }

        public static int NElem<T>(this IEnumerable<T> col)
        {
            int count = 0;

            foreach (var item in col)
                count++;

            return count;
        }

        public static int ComptarOcurrencies<T>(this IEnumerable<T> col, T objectiu)
        {
            int cont = 0;

            foreach (var element in col)
                if (element.Equals(objectiu))
                    cont++;

            return cont;
        }

        public static bool TotsCompleixen<T>(this IEnumerable<T> col, Func<T, bool> predicat)
        {
            var enumerator = col.GetEnumerator();

            bool compleix = true;

            while (enumerator.MoveNext() && compleix)
                compleix = predicat(enumerator.Current);

            return compleix;
        }

        public static T? PrimerOPerDefecte<T>(this IEnumerable<T> col, Func<T, bool> predicat)
        {
            var enumerator = col.GetEnumerator();
            bool compleix = false;
            T? valor = default;

            while (enumerator.MoveNext() && !compleix)
            {
                if (predicat(enumerator.Current))
                {
                    valor = enumerator.Current;
                    compleix = true;
                }

                
            }

            return valor;
        }

        public static IEnumerable<T> ExecutaPerACadascun<T>(this IEnumerable<T> col, Action<T> accio)
        {
            foreach (T element in col)
                accio(element);

            return col;
        }
        #endregion

        #region funcionsgeneric
        public static string ToJson<T>(this T element)
        {
            return JsonSerializer.Serialize(element);
        }

        public static T? DeepClone<T>(this T element)
        {
            string json = element.ToJson();
            return JsonSerializer.Deserialize<T>(json);
        }

        public static bool EsDins<T>(this T element, params T[] opcions)
        {
            int i = 0;
            bool trovat = false;

            while (i < opcions.Length && !trovat)
            {
                trovat = element.Equals(opcions[i]);
                i++;
            }

            return trovat;
        }
        public static T EscriuPerConsola<T>(this T element)
        {
            Console.WriteLine(element);
            return element;
        }
        public static T EscriuAmbEtiqueta<T>(this T element, string etiqueta)
        {
            Console.WriteLine($"{etiqueta}: {element}");
            return element;
        }
        public static T GuardaEnFitxer<T>(this T element, string ruta)
        {
            string json = ToJson(element);
            File.WriteAllText(ruta, json);
            return element;
        }
        #endregion
    }
}