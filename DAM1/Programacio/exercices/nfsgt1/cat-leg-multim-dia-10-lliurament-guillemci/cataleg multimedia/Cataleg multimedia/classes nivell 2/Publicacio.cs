using Cataleg_multimedia.subsuperclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.superclasse
{
    public abstract class Publicacio : Text
    {
        public string Editorial { get; set; } = "";
        public string ISBN_ISSN { get; set; } = "";
        public int Pagines { get; set; } = 0;

        public Publicacio() {}
        public Publicacio (string id, string titol, 
            string autor, int anyCreacio, List<string> 
            Etiquetes, string RutaFitxer, string idioma, int nombreParaules, 
            string Editorial, string ISBN_ISSN, int pagines) 
            : base(id, titol, autor, anyCreacio, Etiquetes, RutaFitxer, idioma, nombreParaules)
        {
            this.Editorial = Editorial;
            this.ISBN_ISSN = ISBN_ISSN;
            this.Pagines = pagines;
        }

        public Publicacio (string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");

            this.Editorial = arrayDades[8];
            this.ISBN_ISSN = arrayDades[9];
            this.Pagines = Convert.ToInt32(arrayDades[10]);
        }

        public override string InformacioExtesa()
        {
            return $"[{Titol} - {Editorial} - {ISBN_ISSN} - {Pagines} - [{Idioma}]";
        }
    }
}
