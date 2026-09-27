using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mètodes_d_extensió_i_funcions_lambda
{
    public class MostraMenus
    {
        public static void MenuTria()
        {
            Console.WriteLine("========== Main Menu ==========");
            Console.WriteLine("1 = ExtensionsDeCaracters");
            Console.WriteLine("2 = ExtensionsDeInts");
            Console.WriteLine("3 = ExtensionsDeStrings");
            Console.WriteLine("4 = ExtensionsDeDates");
            Console.WriteLine("5 = ExtensionsDeIEnumerable");
            Console.WriteLine("6 = ExtensionsGeneriques");
            Console.WriteLine("========== 7 per sortir ==========");
        }

        public static void ExtensionsDeCaracters()
        {
            Console.WriteLine("==========FUNCIONS CARACTERS==========");

            char c1 = '5';
            char c2 = 'a';
            char c3 = 'É';
            char c4 = 'ç';
            char c5 = 'Z';

            Console.WriteLine($"Variables: {c1}, {c2}, {c3}, {c4}, {c5}");
            Console.WriteLine();

            //ToInt()
            Console.WriteLine("ToInt():");
            Console.WriteLine($"{c1} -> {c1.ToInt()}");
            Console.WriteLine($"{c2} -> {c2.ToInt()}");
            Console.WriteLine();

            //EsVocal()
            Console.WriteLine("EsVocal():");
            Console.WriteLine($"{c2} -> {c2.EsVocal()}");
            Console.WriteLine($"{c3} -> {c3.EsVocal()}");
            Console.WriteLine($"{c4} -> {c4.EsVocal()}");
            Console.WriteLine();

            //EsConsonant()
            Console.WriteLine("EsConsonant():");
            Console.WriteLine($"{c2} -> {c2.EsConsonant()}");
            Console.WriteLine($"{c4} -> {c4.EsConsonant()}");
            Console.WriteLine();

            //EsNumero()
            Console.WriteLine("EsNumero():");
            Console.WriteLine($"{c1} -> {c1.EsNumero()}");
            Console.WriteLine($"{c2} -> {c2.EsNumero()}");
            Console.WriteLine();

            //Repeteix()
            Console.WriteLine("Repeteix(3):");
            Console.WriteLine($"{c2} -> {c2.Repeteix(3)}");
            Console.WriteLine();

            //InvertirMajusculesMinuscules()
            Console.WriteLine("InvertirMajusculesMinuscules():");
            Console.WriteLine($"{c2} -> {c2.InvertirMajusculesMinuscules()}");
            Console.WriteLine($"{c5} -> {c5.InvertirMajusculesMinuscules()}");
            Console.WriteLine();

            //ToAscii()
            Console.WriteLine("ToAscii():");
            Console.WriteLine($"{c2} -> {c2.ToAscii()}");
            Console.WriteLine($"{c5} -> {c5.ToAscii()}");
            Console.WriteLine();

            //EsDinsDelRang()
            Console.WriteLine("EsDinsDelRang('a','z'):");
            Console.WriteLine($"{c2} -> {c2.EsDinsDelRang('a', 'z')}");
            Console.WriteLine($"{c5} -> {c5.EsDinsDelRang('a', 'z')}");
            Console.WriteLine();

            //LletraSeguent()
            Console.WriteLine("LletraSeguent():");
            Console.WriteLine($"{c2} -> {c2.LletraSeguent()}");
            Console.WriteLine($"z -> {'z'.LletraSeguent()}");

            Console.WriteLine("======================================");
        }

        public static void ExtensionsDeInts()
        {
            Console.WriteLine("==========FUNCIONS INTS==========");

            int n1 = 10;
            int n2 = -5;
            int n3 = 7;
            int n4 = 0;

            Console.WriteLine($"Variables: {n1}, {n2}, {n3}, {n4}");
            Console.WriteLine();

            //EstaEntre()
            Console.WriteLine("EstaEntre(5,15):");
            Console.WriteLine($"{n1} -> {n1.EstaEntre(5, 15)}");
            Console.WriteLine($"{n2} -> {n2.EstaEntre(5, 15)}");
            Console.WriteLine();

            //Positiu() / Negatiu()
            Console.WriteLine("EsPositiu():");
            Console.WriteLine($"{n1} -> {n1.EsPositiu()}");
            Console.WriteLine($"{n2} -> {n2.EsPositiu()}");
            Console.WriteLine();

            Console.WriteLine("EsNegatiu():");
            Console.WriteLine($"{n2} -> {n2.EsNegatiu()}");
            Console.WriteLine($"{n4} -> {n4.EsNegatiu()}");
            Console.WriteLine();

            //Valor absolut()
            Console.WriteLine("ToValorAbsolut():");
            Console.WriteLine($"{n2} -> {n2.ToValorAbsolut()}");
            Console.WriteLine();

            //Multiple()
            Console.WriteLine("EsMultipleDe():");
            Console.WriteLine($"{n1} % 5 -> {n1.EsMultipleDe(5)}");
            Console.WriteLine($"{n3} % 5 -> {n3.EsMultipleDe(5)}");
            Console.WriteLine($"{n1} % 0 -> {n1.EsMultipleDe(0)}");
            Console.WriteLine();

            //Clamp()
            Console.WriteLine("Clamp(0,8):");
            Console.WriteLine($"{n1} -> {n1.Clamp(0, 8)}");
            Console.WriteLine($"{n2} -> {n2.Clamp(0, 8)}");
            Console.WriteLine();

            //Primer()
            Console.WriteLine("EsPrimer():");
            Console.WriteLine($"{n1} -> {n1.EsPrimer()}");
            Console.WriteLine($"{n3} -> {n3.EsPrimer()}");
            Console.WriteLine($"{n4} -> {n4.EsPrimer()}");
            Console.WriteLine();

            //Temps()
            Console.WriteLine("Temps():");
            Console.WriteLine($"{n1} segons -> {n1.Segons()}");
            Console.WriteLine($"5 minuts -> {5.Minuts()}");
            Console.WriteLine($"2 hores -> {2.Hores()}");
            Console.WriteLine($"1 dia -> {1.Dies()}");
            Console.WriteLine($"1 setmana -> {1.Setmanes()}");

            Console.WriteLine("=================================");
        }

        public static void ExtensionsDeStrings()
        {
            Console.WriteLine("==========FUNCIONS STRINGS==========");

            string s1 = "12345";
            string s2 = "Hola123";
            string s3 = "text molt interesant";
            string s4 = "guillemcib@email.com";
            string s5 = "NoEmail";
            string s6 = "";
            string s7 = "HOlAp";
            string s8 = "hola";

            Console.WriteLine($"Variables:");
            Console.WriteLine($"s1: {s1}");
            Console.WriteLine($"s2: {s2}");
            Console.WriteLine($"s3: {s3}");
            Console.WriteLine($"s4: {s4}");
            Console.WriteLine($"s5: {s5}");
            Console.WriteLine($"s6: {s6}");
            Console.WriteLine($"s6: {s7}");
            Console.WriteLine($"s6: {s8}");
            Console.WriteLine();

            //EsNumeric()
            Console.WriteLine("EsNumeric():");
            Console.WriteLine($"{s1} -> {s1.EsNumeric()}");
            Console.WriteLine($"{s2} -> {s2.EsNumeric()}");
            Console.WriteLine();

            //Trunca()
            Console.WriteLine("Trunca(10):");
            Console.WriteLine($"{s3} -> {s3.Trunca(10)}");
            Console.WriteLine($"{s1} -> {s1.Trunca(10)}");
            Console.WriteLine();

            //Capitalitza()
            Console.WriteLine("Capitalitza():");
            Console.WriteLine($"{s2} -> {s2.Capitalitza()}");
            Console.WriteLine($"{s7} -> {s7.Capitalitza()}");
            Console.WriteLine($"{s8} -> {s8.Capitalitza()}");
            Console.WriteLine();

            //ExtreuDigits()
            Console.WriteLine("ExtreuDigits():");
            Console.WriteLine($"{s2} -> {s2.ExtreuDigits()}");
            Console.WriteLine($"{s3} -> {s3.ExtreuDigits()}");
            Console.WriteLine();

            //EsCorreuElectronic()
            Console.WriteLine("EsCorreuElectronic():");
            Console.WriteLine($"{s4} -> {s4.EsCorreuElectronic()}");
            Console.WriteLine($"{s5} -> {s5.EsCorreuElectronic()}");
            Console.WriteLine();

            //Inverteix()
            Console.WriteLine("Inverteix():");
            Console.WriteLine($"{s2} -> {s2.Inverteix()}");
            Console.WriteLine($"abc -> {"abc".Inverteix()}");
            Console.WriteLine();

            Console.WriteLine("====================================");
        }

        public static void ExtensionsDeDates()
        {
            Console.WriteLine("==========FUNCIONS DATETIME==========");

            DateTime d1 = new DateTime(2026, 1, 10);
            DateTime d2 = new DateTime(2026, 1, 13);
            DateTime d3 = new DateTime(2026, 2, 28);
            DateTime d4 = DateTime.Now.AddYears(-10);
            DateTime d5 = new DateTime(2026, 1, 16);

            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d2: {d2}");
            Console.WriteLine($"d3: {d3}");
            Console.WriteLine($"d4: {d4}");
            Console.WriteLine();

            //EsCapDeSetmana()
            Console.WriteLine("Cap de setmana:");
            Console.WriteLine($"{d1} -> {d1.EsCapDeSetmana()}");
            Console.WriteLine($"{d2} -> {d2.EsCapDeSetmana()}");
            Console.WriteLine();

            //EsEntreSetmana()
            Console.WriteLine("Entre setmana:");
            Console.WriteLine($"{d1} -> {d1.EsEntreSetmana()}");
            Console.WriteLine($"{d2} -> {d2.EsEntreSetmana()}");
            Console.WriteLine();

            //IniciDeMes() / FiDeMes()
            Console.WriteLine("Inici / Fi de mes:");
            Console.WriteLine($"{d1} -> {d1.IniciDeMes()} / {d1.FiDeMes()}");
            Console.WriteLine();

            //IniciDeMes() / FiDeMes() (dia setmana)
            Console.WriteLine("Inici / Fi de mes (setmana):");
            Console.WriteLine($"{d1} -> {(DayOfWeek)d1.IniciDeMesSetmana()} / {(DayOfWeek)d1.FinalDeMesSetmana()}");
            Console.WriteLine();

            //SeguentDiaFeiner()
            Console.WriteLine("Següent dia feiner:");
            Console.WriteLine($"{d2} -> {d2.SeguentDiaFeiner()}");
            Console.WriteLine($"{d5} -> {d5.SeguentDiaFeiner()}");
            Console.WriteLine();

            //AfegeixDiesFeiners(int n)
            Console.WriteLine("Afegeix dies feiners:");
            Console.WriteLine($"{d2} -> {d2.AfegeixDiesFeiners(5)}");
            Console.WriteLine();

            //CalculaEdat()
            Console.WriteLine("Edat:");
            Console.WriteLine($"{d4} -> {d4.CalculaEdat()} anys");

            Console.WriteLine("====================================");
        }

        public static void ExtensionsDeIEnumerable()
        {
            Console.WriteLine("==========FUNCIONS IENUMERABLE==========");

            List<int> nums = new List<int> { 1, 2, 3, 3, 4, 5 };
            List<int> buida = new List<int>();

            Console.WriteLine($"nums: {string.Join(", ", nums)}");
            Console.WriteLine($"buida: {string.Join(", ", buida)}");
            Console.WriteLine();

            //EsBuida()
            Console.WriteLine("EsBuida():");
            Console.WriteLine($"nums -> {nums.EsBuida()}");
            Console.WriteLine($"buida -> {buida.EsBuida()}");
            Console.WriteLine();

            //NElem()
            Console.WriteLine("NElem():");
            Console.WriteLine($"nums -> {nums.NElem()}");
            Console.WriteLine();

            //ComptarOcurrencies()
            Console.WriteLine("ComptarOcurrencies(3):");
            Console.WriteLine($"3 -> {nums.ComptarOcurrencies(3)}");
            Console.WriteLine();

            //TotsCompleixen()
            Console.WriteLine("TotsCompleixen:");
            Console.WriteLine($"x > 0 -> {nums.TotsCompleixen(x => x > 0)}");
            Console.WriteLine($"x > 3 -> {nums.TotsCompleixen(x => x > 3)}");
            Console.WriteLine();

            //PrimerOPerDefecte()
            Console.WriteLine("PrimerOPerDefecte:");
            Console.WriteLine($"x > 3 -> {nums.PrimerOPerDefecte(x => x > 3)}");
            Console.WriteLine($"x > 10 -> {nums.PrimerOPerDefecte(x => x > 10)}");
            Console.WriteLine();

            //ExecutaPerACadascun()
            Console.WriteLine("ExecutaPerACadascun (x * 2):");
            nums.ExecutaPerACadascun(x => Console.WriteLine(x * 2));
            Console.WriteLine();

            Console.WriteLine("====================================");
        }

        public static void ExtensionsGeneriques()
        {
            Console.WriteLine("==========FUNCIONS GENERIQUES==========");

            int n = 42;
            string text = "Hola";
            List<int> llista = new List<int> { 1, 2, 3 };

            Console.WriteLine($"n: {n}");
            Console.WriteLine($"text: {text}");

            Console.Write("llista: ");
            MostraColleccio(llista);
            Console.WriteLine();

            //ToJson()
            Console.WriteLine("ToJson():");
            Console.WriteLine($"int -> {n.ToJson()}");
            Console.WriteLine($"string -> {text.ToJson()}");
            Console.WriteLine();

            //DeepClone()
            Console.WriteLine("DeepClone():");
            var clone = llista.DeepClone();

            Console.Write("original: ");
            MostraColleccio(llista);

            Console.Write("clone: ");
            MostraColleccio(clone);

            Console.WriteLine();

            //EsDins
            Console.WriteLine("EsDins():");
            Console.WriteLine($"42 in (1,2,42) -> {n.EsDins([1, 2, 42])}");
            Console.WriteLine($"42 in (1,2,3) -> {n.EsDins([1, 2, 3])}");
            Console.WriteLine();

            //Mètodes "Passarela"//

            //EscriuPerConsola()
            Console.WriteLine("EscriuPerConsola():");
            n.EscriuPerConsola();
            text.EscriuPerConsola();
            Console.WriteLine();

            //EscriuAmbEtiqueta()
            Console.WriteLine("EscriuAmbEtiqueta():");
            n.EscriuAmbEtiqueta("int");
            text.EscriuAmbEtiqueta("string");
            Console.WriteLine();

            //GuardaEnFitxer()
            Console.WriteLine("GuardaEnFitxer():");
            n.GuardaEnFitxer("int.json");
            text.GuardaEnFitxer("text.json");

            Console.WriteLine("====================================");
        }

        public static void MostraColleccio<T>(IEnumerable<T> col)
        {
            foreach (var item in col)
                Console.Write(item + " ");

            Console.WriteLine();
        }

        public static void ControlMenu()
        {
            Console.WriteLine("prem enter per sortir");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
