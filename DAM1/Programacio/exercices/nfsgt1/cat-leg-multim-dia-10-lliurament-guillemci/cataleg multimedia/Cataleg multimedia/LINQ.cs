using Cataleg_multimedia.classes;
using Cataleg_multimedia.classes_nivell_2;
using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia
{
    public static class LINQ
    {
        //Quantificadors i Cerca
        public static bool AlgunaPeliDUnaResolucioDonada(this Cataleg cataleg, string resolucio)
        {
            return cataleg.OfType<Pelicula>().Any(p => p.Resolucio == resolucio);
        }

        public static bool TotesLesCanconsSonStereo(this Cataleg cataleg)
        {
            return cataleg.OfType<Canço>().All(c => c.EsStereo);
        }

        public static Fotografia? PrimeraFotoMajorAUnaResolucio(this Cataleg cataleg, int resolucio)
        {
            return cataleg.OfType<Fotografia>().FirstOrDefault(p => p.Megapixels > resolucio);
        }

        //Filtratge (Where)
        public static IEnumerable<Mitja> MitjansDespresDunAny(this Cataleg cataleg, int any)
        {
            return cataleg.Where(c => c.AnyCreacio > any);
        }

        public static IEnumerable<Mitja> LlibresEnunIdioma(this Cataleg cataleg, string idioma)
        {
            return cataleg.OfType<Llibre>().Where(l => l.Idioma == idioma);
        }

        public static void PeliculesDuradaMinimaIClassificacio(this Cataleg cataleg, int duradaSegons, string classificacio)
        {
            var trovades = cataleg.OfType<Pelicula>().Where(p => p.Durada >= TimeSpan.FromSeconds(duradaSegons) && p.ClassificacioEdat == classificacio);

            foreach (var element in trovades)
                Console.WriteLine(element);
        }

        public static IEnumerable<Mitja> MitjansAmbEtiqueta(this Cataleg cataleg, string etiqueta)
        {
            return cataleg.Where(c => c.Etiquetes.Any(e => e.ToLower() == etiqueta.ToLower()));

            //
        }

        //Projecció (Select)
        public static IEnumerable<string> TítolsDelCataleg(this Cataleg cataleg)
        {
            return cataleg.Select(c => c.Titol);
        }

        public static void ProjeccioDeCanco(this Cataleg cataleg)
        {
            var variable = cataleg.OfType<Canço>().Select(c => new
            {
                titol = c.Titol,
                autor = c.Autor,
                Any = c.AnyCreacio,
                Album = c.Album
            });

            foreach (var element in variable)
            {
                Console.WriteLine(element);
            }
        }

        public static void MegapixesITitolFotografies(this Cataleg cataleg)
        {
            var variable = cataleg.OfType<Fotografia>().Select(f => new
            {
                titol = f.Titol,
                megapixels = f.Megapixels
            });

            foreach (var element in variable)
            {
                Console.WriteLine(element);
            }
        }

        public static IEnumerable<string> LlistaCitesBibliografiques(this Cataleg cataleg)
        {
            return cataleg.OfType<Llibre>().Select(l => l.ObtenCitaBibliografica());
        }

        //Ordenació i Agrupació
        public static IEnumerable<Video> OrdenaVideosDescendent(this Cataleg cataleg)
        {
            return cataleg.OfType<Video>().OrderByDescending(v => v.AnyCreacio).ThenBy(v => v.Titol);
        }

        public static void MitjansPerAnyDeCreacio(this Cataleg cataleg)
        {
            var variable = cataleg.GroupBy(c => c.AnyCreacio).Select(d => new
            {
                any = d.Key,
                numero = d.Count()
            }).OrderBy(d => d.any);


            foreach (var element in variable)
            {
                Console.WriteLine($"{element.any}: {element.numero}");
            }
        }

        public static void AgrupaPerTipus(this Cataleg cataleg)
        {
            var variable = cataleg.GroupBy(c => c.GetType().Name).Select(d => new {
                clau = d.Key,
                total = d.Count()
            }).OrderBy(d => d.total);

            foreach (var element in variable)
            {
                Console.WriteLine($"{element.clau}: {element.total}");
            }
        }

        //Operacions de Conjunts i Complexes
        public static IEnumerable<string> LlistaAutorsDeLLibresIRevistes(this Cataleg cataleg)
        {
            return cataleg.OfType<Llibre>().Select(l => l.Autor).Intersect(cataleg.OfType<Revista>().Select(r => r.Autor));
        }

        public static IEnumerable<string> EtiquetesUniques(this Cataleg cataleg)
        {
            return cataleg.SelectMany(c => c.Etiquetes).Distinct().OrderBy(e => e);
        }

        public static void Top3Autors(this Cataleg cataleg)
        {
            var variable = cataleg.Where(c => !string.IsNullOrWhiteSpace(c.Autor)).GroupBy(c => c.Autor).Select(d => new {
                Autor = d.Key,
                Obres = d.Select(c => c.Titol).ToArray(),
                total = d.Count()
            }).OrderByDescending(d => d.total).Take(3);

            if (!variable.Any())
                Console.WriteLine("cap trovat");
            else
            {
                foreach (var element in variable)
                {
                    Console.WriteLine($"autor: {element.Autor}");
                    Console.WriteLine($"obres: ({element.total})");
                    foreach (var titol in element.Obres)
                    {
                        Console.WriteLine($"- {titol}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}