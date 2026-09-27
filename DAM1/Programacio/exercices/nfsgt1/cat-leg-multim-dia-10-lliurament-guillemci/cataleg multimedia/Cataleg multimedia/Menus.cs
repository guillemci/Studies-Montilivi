using Cataleg_multimedia.classe_nivell_0.IComparable;
using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cataleg_multimedia
{
    internal class Menus
    {
        public static void MainMeu(Cataleg biblio)
        {
            Console.Clear();
            Console.WriteLine("========= MENU =========");
            Console.WriteLine("1 -> Carregar CSV");
            Console.WriteLine("2 -> Carregar JSON");
            Console.WriteLine("3 -> Carregar XML");
            Console.WriteLine("4 -> Mostrar llista");
            Console.WriteLine("5 -> Guardar JSON");
            Console.WriteLine("6 -> Guardar XML");
            Console.WriteLine("7 -> Buidar llista");
            Console.WriteLine("8 -> Ordenar llista");
            Console.WriteLine("9 -> Consulta");
            Console.WriteLine("10 -> LINQ");
            Console.WriteLine("11 -> Sortir");

            Console.WriteLine();
            Console.WriteLine($"Elements a LlistaMitja: {biblio.Count}");
            Console.WriteLine("========================");
            Console.Write("tria que vols fer: ");
        }
        public static void OrdenarMenu(Cataleg biblio)
        {
            Console.Clear();
            Console.WriteLine("========= ORDENADOR =========");
            Console.WriteLine("1 -> Ordenar per titol");
            Console.WriteLine("2 -> Ordenar per any creacio");
            Console.WriteLine("3 -> Ordenar per autor");
            Console.WriteLine("4 -> Ordenar per etiquetes");
            Console.WriteLine("5 -> Sortir");
            Console.WriteLine("=============================");
            Console.Write("tria que vols fer: ");
            string opcio = Console.ReadLine();

            switch(opcio)
            {
                case "1":
                    biblio.OrdenarPerTitolMitja();
                    Console.WriteLine("ordenat per titol correctament");
                    break;
                case "2":
                    biblio.OrdenarMitja(new ComparaMitjansPerAnyDeCreacio());
                    Console.WriteLine("ordenat per any correctament");
                    break;
                case "3":
                    biblio.OrdenarMitja(new ComparaMitjansPerAutor());
                    Console.WriteLine("ordenat per autor correctament");
                    break;
                case "4":
                    biblio.OrdenarMitja(new ComparaMitjansPerQuantitatDEtiquetes());
                    Console.WriteLine("ordenat per numero d'etiquetes");
                    break;
                case "5":
                    return;
            }

            Console.WriteLine("======================");
            Console.WriteLine("prem enter per sortir");
            Console.ReadLine();
        }

        public static void Consulta(Cataleg biblio)
        {
            Console.Clear();
            Console.WriteLine("---CONSULTA---");
            Console.WriteLine("------------------------------");
            Console.WriteLine("--LLISTA DE TOTS ELS OBJECTS--");
            Mitja.ImprimeixCataleg(biblio);
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{biblio.Count}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"introdueix un numero entre el 1 i el {biblio.Count}");
            int numero = Convert.ToInt32(Console.ReadLine());
            int index = numero - 1;

            if (index >= 0 && index < biblio.Count)
            {
                Mitja seleccionat = biblio[index];

                if (seleccionat is IDescarregable)
                {
                    IDescarregable des = (IDescarregable)seleccionat;
                    des.Descarrega();
                }

                if (seleccionat is IMostrable)
                {
                    IMostrable mos = (IMostrable)seleccionat;
                    mos.Mostra();
                }
            }
            else
            {
                return;
            }
        }

        public static void MainMenuLinq(Cataleg biblio)
        {
            Console.Clear();
            Console.WriteLine("==============Menu LINQ==============");
            Console.WriteLine("tria quins metodes extesos provar");
            Console.WriteLine("1 Quantificadors i Cerca");
            Console.WriteLine("2 Filtratge");
            Console.WriteLine("3 Projecció");
            Console.WriteLine("4 Ordenació i Agrupació");
            Console.WriteLine("5 Operacions de Conjunts i Complexes");
            Console.WriteLine("=====================================");
            string opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    QuantificadorsiCerca(biblio);
                    break;
                case "2":
                    MenuFiltratge(biblio);
                    break;
                case "3":
                    MenuProjeccio(biblio);
                    break;
                case "4":
                    MenuOrdenacio(biblio);
                    break;
                case "5":
                    MenuConjunts(biblio);
                    break;
            }

            Console.WriteLine("======================");
            Console.WriteLine("prem enter per sortir");
            Console.ReadLine();
        }

        public static void QuantificadorsiCerca(Cataleg biblio)
        {
            Console.Clear();
            Console.WriteLine("======Quantificadors i Cerca======");
            Console.WriteLine("1. AlgunaPeliDUnaResolucioDonada");
            Console.WriteLine("2. TotesLesCanconsSonStereo");
            Console.WriteLine("3. PrimeraFotoMajorAUnaResolucio");
            Console.WriteLine("==================================");
            string opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    Console.Write("Resoluco: ");
                    string res = Console.ReadLine();
                    var trobat = biblio.AlgunaPeliDUnaResolucioDonada(res);
                    Console.WriteLine(trobat ? "existeix" : "No existeix");
                    break;
                case "2":
                    var sonStereo = biblio.TotesLesCanconsSonStereo();
                    Console.WriteLine(sonStereo ? "si, totes" : "No totes");
                    break;
                case "3":
                    Console.Write("Megapixels: ");
                    int mp = Convert.ToInt32(Console.ReadLine());
                    var foto = biblio.PrimeraFotoMajorAUnaResolucio(mp);
                    Console.WriteLine(foto != null ? $"trobada: {foto.Titol}" : "cap trovada");
                    break;
            }
        }

        public static void MenuFiltratge(Cataleg biblio)
        {
            Console.Clear();
            Console.WriteLine("================Filtratge================");
            Console.WriteLine("1. MitjansDespresDunAny");
            Console.WriteLine("2. LlibresEnunIdioma");
            Console.WriteLine("3. PeliculesDuradaMinimaIClassificacio");
            Console.WriteLine("4. MitjansAmbEtiqueta");
            Console.WriteLine("=========================================");
            string opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    Console.Write("Any: ");
                    int any = Convert.ToInt32(Console.ReadLine());
                    var llista = biblio.MitjansDespresDunAny(any);
                    foreach (var m in llista) Console.WriteLine(m.Titol);
                    break;
                case "2":
                    Console.Write("Idioma: ");
                    string id = Console.ReadLine();
                    var llibres = biblio.LlibresEnunIdioma(id);
                    foreach (var l in llibres) Console.WriteLine(l.Titol);
                    break;
                case "3":
                    Console.Write("Durada (segons): ");
                    int seg = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Classificació: ");
                    string cl = Console.ReadLine();
                    biblio.PeliculesDuradaMinimaIClassificacio(seg, cl);
                    break;
                case "4":
                    Console.Write("Etiqueta: ");
                    string tag = Console.ReadLine();
                    var resultats = biblio.MitjansAmbEtiqueta(tag);
                    foreach (var r in resultats) Console.WriteLine(r.Titol);
                    break;
            }
        }

        public static void MenuProjeccio(Cataleg biblio)
        {
            Console.Clear();
            Console.WriteLine("================Projecció================");
            Console.WriteLine("1. TítolsDelCatàleg");
            Console.WriteLine("2. ProjeccioDeCanco");
            Console.WriteLine("3. MegapixesITitolFotografies");
            Console.WriteLine("4. LlistaCitesBibliografiques");
            Console.WriteLine("=========================================");
            string opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    var titols = biblio.TítolsDelCataleg();
                    foreach (var t in titols) Console.WriteLine(t);
                    break;
                case "2":
                    biblio.ProjeccioDeCanco();
                    break;
                case "3":
                    biblio.MegapixesITitolFotografies();
                    break;
                case "4":
                    var cites = biblio.LlistaCitesBibliografiques();
                    foreach (var c in cites) Console.WriteLine(c);
                    break;
            }
        }

        public static void MenuOrdenacio(Cataleg biblio)
        {
            Console.Clear();
            Console.WriteLine("================Ordenació i Agrupació================");
            Console.WriteLine("1. OrdenaVideosDescendent");
            Console.WriteLine("2. MitjansPerAnyDeCreacio");
            Console.WriteLine("3. AgrupaPerTipus");
            Console.WriteLine("=====================================================");
            string opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    var videos = biblio.OrdenaVideosDescendent();
                    foreach (var v in videos) Console.WriteLine($"{v.AnyCreacio}: {v.Titol} i ({v.GetType().Name})");
                    break;
                case "2":
                    biblio.MitjansPerAnyDeCreacio();
                    break;
                case "3":
                    biblio.AgrupaPerTipus();
                    break;
            }
        }

        public static void MenuConjunts(Cataleg biblio)
        {
            Console.Clear();
            Console.WriteLine("================Operacions de Conjunts i Complexes================");
            Console.WriteLine("1. LlistaAutorsDeLLibresIRevistes");
            Console.WriteLine("2. EtiquetesUniques");
            Console.WriteLine("3. Top 3 Autors");
            Console.WriteLine("==================================================================");
            string opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    //podria haver-ho arreglat mes facilment fent que IEnumerable<string> pugui retornar null amb ? pero no es demana
                    var autors = biblio.LlistaAutorsDeLLibresIRevistes();
                    var autorsReals = autors.Where(a => !string.IsNullOrWhiteSpace(a));

                    if (autorsReals.Any())
                        foreach (var a in autorsReals)
                            Console.WriteLine($"- {a}");
                    else
                        Console.WriteLine("cap trovat");
                    break;
                case "2":
                    var tags = biblio.EtiquetesUniques();
                    var tagsReals = tags.Where(t => !string.IsNullOrWhiteSpace(t));

                    if (tagsReals.Any())
                        foreach (var t in tagsReals)
                            Console.WriteLine($"- {t}");
                    else
                        Console.WriteLine("cap trovat");
                    break;
                case "3":
                    biblio.Top3Autors();
                    break;
            }
        }
    }
}
