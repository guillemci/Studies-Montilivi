using Cataleg_multimedia.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Cataleg_multimedia.superclasse
{
    public abstract class Mitja : IComparable<Mitja>
    {
        [XmlAttribute("Codi")]
        public string Id { get; set; } = "";
        public string Titol { get; set; } = "";
        public string Autor { get; set; } = "";
        public int AnyCreacio { get; set; } = 0;
        public List<string> Etiquetes { get; set; } = new List<string>();
        public string RutaFitxer { get; set; } = "";

        public Mitja() {}
        public Mitja (string CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.Id = arrayDades[0];
            this.Titol = arrayDades[1];
            this.Autor = arrayDades[2];
            this.AnyCreacio = Convert.ToInt32(arrayDades[3]);
            this.Etiquetes = new List<string>(arrayDades[4].Split('|'));
            this.RutaFitxer = arrayDades[5];
        }

        public Mitja (string Id, string Titol, string Autor, int AnyCreacio, List<string> Etiquetes, string RutaFitxer)
        {
            this.Id = Id;
            this.Titol = Titol;
            this.Autor = Autor;
            this.AnyCreacio = AnyCreacio;
            this.Etiquetes = Etiquetes;
            this.RutaFitxer = RutaFitxer;
        }

        public override string ToString()
        {
            return $"[{GetType().Name}] {Titol} ({AnyCreacio}) - {Autor}";
        }

        public override bool Equals(object? obj)
        {
            bool iguals;

            if (obj == null) iguals = this.GetType() == obj.GetType();
            else if (obj.GetType() != this.GetType()) iguals = false;
            else iguals = Id == ((Mitja)obj).Id;

            return iguals;
        }

        public static void ImprimeixLlista<T>(List<T> llista)
        {
            if (llista is null)
                throw new ArgumentNullException("llista");

            for (int i = 0; i < llista.Count; i++)
                Console.WriteLine($"{i + 1}. {llista[i]}");
        }

        public static void ImprimeixCataleg(Cataleg biblio)
        {
            if (biblio is null)
                throw new ArgumentNullException("llista");

            for (int i = 0; i < biblio.Count; i++)
                Console.WriteLine($"{i + 1}. {biblio[i]}");
        }

        public static void ImprimirDiccionari<T>(Dictionary<String, T> diccionari)
        {
            if (diccionari is null)
                throw new ArgumentNullException("diccionari");

            //var ens permet tenir un metode generic mes net,
            //s'ens va explicar per sobre a la classe juntament amb diccionaris
            foreach (var valor in diccionari.Values)
                Console.WriteLine(valor);
        }

        public static void ImprimirDiccionaryExtes(Dictionary<String, Mitja> diccionary)
        {
            if (diccionary is null)
                throw new ArgumentNullException("diccionary");

            foreach (var valor in diccionary.Values)
                Console.WriteLine(valor.InformacioExtesa());
        }

        public static void ImprimirDiccionaryExtesRetallat(Dictionary<String, Mitja> diccionary)
        {
            if (diccionary is null)
                throw new ArgumentNullException("diccionary");

            int midabloc = 50;

            for (int i = 0; i < diccionary.Count; i += midabloc)
            {
                var bloc = diccionary.Values.Skip(i).Take(midabloc);

                foreach (var valor in bloc)
                    Console.WriteLine(valor.InformacioExtesa());
            }
        }

        public static void ImprimeixLlistaRetallat<T>(List<T> llista)
        {
            if (llista is null)
                throw new ArgumentNullException("llista");

            int midabloc = 50;
            for (int i = 0; i < llista.Count; i+= midabloc)
             {
                var bloc = llista.Skip(i).Take(midabloc);
                foreach (var valor in bloc)
                    Console.WriteLine(valor);
            }
        }

        public abstract string InformacioExtesa();

        public int CompareTo(Mitja other)
        {
            if (other == null) return 1;

            return this.Titol.CompareTo(other.Titol);
        }
    }
}
