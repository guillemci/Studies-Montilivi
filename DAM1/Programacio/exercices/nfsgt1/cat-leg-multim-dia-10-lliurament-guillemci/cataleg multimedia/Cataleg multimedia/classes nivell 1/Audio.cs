using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes_nivell_1
{
    public abstract class Audio : Mitja
    {
        public string Genere { get; set; } = "";
        public abstract double MidaArxiuMB { get; }
        public abstract bool esDigital { get; }

        public Audio() {}
        public Audio(string CSVlinea) : base (CSVlinea)
        {
            string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");

            this.Genere = arrayDades[6];
        }

        public Audio(string id, string titol, string autor, int anyCreacio, List<string> etiquetes,
            string rutaFitxer, string genere) : base(id, titol, autor, anyCreacio, etiquetes, rutaFitxer)
        {
            this.Genere = genere;
        }
    }
}
