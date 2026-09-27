using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes
{
    public class Gravat : Publicacio, IMostrable
    {
        private string tecnica = "";
        private int numeroSerie = 0;
        private string dimensionsFisiques = "";

        public string Tecnica
        {
            get { return this.tecnica; }
            set { this.tecnica = value; }
        }

        public int NumeroSerie
        {
            get { return this.numeroSerie; }
            set { this.numeroSerie = value; }
        }

        public string DimensionsFisiques
        {
            get { return this.dimensionsFisiques; }
            set { this.dimensionsFisiques = value; }
        }

        public Gravat() {}
        public Gravat(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");

            this.tecnica = arrayDades[11];
            this.numeroSerie = Convert.ToInt32(arrayDades[12]);
            this.dimensionsFisiques = arrayDades[13];
        }

        public Gravat(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes, string rutaFitxer, string idioma, int nombreParaules,
            string editorial, string ISBN_ISSN, int pagines, string tecnica,
            int numeroSerie, string dimensionsFisiques) : base(id, titol, autor, anyCreacio, etiquetes, rutaFitxer, idioma, nombreParaules, editorial, ISBN_ISSN, pagines)
        {
            this.tecnica = tecnica;
            this.numeroSerie = numeroSerie;
            this.dimensionsFisiques = dimensionsFisiques;
        }

        public static List<Gravat> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Gravat> gravats = new List<Gravat>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Gravat temp = new Gravat(read1);
                gravats.Add(temp);
            }

            sr.Close();

            return gravats;
        }

        public override string ObtenCitaBibliografica()
        {
            return $"[{Autor} ({AnyCreacio}) - {Titol} (´{Tecnica}) - N. Sèrie: {NumeroSerie}]";
        }

        public void Mostra()
        {
            Utilitats.ObreEnNavegador(this.RutaFitxer);
        }
    }
}
