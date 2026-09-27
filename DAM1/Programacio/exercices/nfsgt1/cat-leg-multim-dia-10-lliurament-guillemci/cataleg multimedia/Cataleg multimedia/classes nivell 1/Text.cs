using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.subsuperclasse
{
    public abstract class Text : Mitja
    {
        public string Idioma { get; set; } = "";
        public int NombreParaules { get; set; } = 0;

        public Text() {}
        public Text (string CSVlinea) : base (CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.Idioma = arrayDades[6];
            this.NombreParaules = Convert.ToInt32(arrayDades[7]);
        }

        public Text(string Id, string Titol, string Autor, int AnyCreacio, List<string> Etiquetes, 
            string RutaFitxer , string idioma, int nombreParaules) : base(Id, Titol, Autor, AnyCreacio, Etiquetes, RutaFitxer)
        {
            this.Idioma = idioma;
            this.NombreParaules = nombreParaules;
        }

        public abstract override string InformacioExtesa();

        public abstract string ObtenCitaBibliografica();
    }
}
