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
    public class Map : Publicacio, IMostrable
    {
        private string tipusProjeccio = "";
        private string escala = "";
        private string regioGeografica = "";
        private string dimensionsFisiques = "";
        public string TipusProjeccio
        {
            get { return this.tipusProjeccio; }
            set { this.tipusProjeccio = value; }
        }

        public string Escala
        {
            get { return this.escala; }
            set { this.escala = value; }
        }

        public string RegioGeografica
        {
            get { return this.regioGeografica; }
            set { this.regioGeografica = value; }
        }

        public string DimensionsFisiques
        {
            get { return this.dimensionsFisiques; }
            set { this.dimensionsFisiques = value; }
        }

        public Map() { }
        public Map(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");

            this.tipusProjeccio = arrayDades[11];
            this.escala = arrayDades[12];
            this.regioGeografica = arrayDades[13];
            this.dimensionsFisiques = arrayDades[14];
        }

        public Map(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes, string rutaFitxer, string idioma,
            int nombreParaules,
            string editorial, string ISBN_ISSN, int pagines, string tipusProjeccio,
            string escala, string regioGeografica, string dimensionsFisiques) : base(id, titol, autor, anyCreacio, etiquetes,
                rutaFitxer, idioma, nombreParaules, editorial, ISBN_ISSN, pagines)
        {
            this.tipusProjeccio = tipusProjeccio;
            this.escala = escala;
            this.regioGeografica = regioGeografica;
            this.dimensionsFisiques = dimensionsFisiques;
        }

        public static List<Map> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Map> mapes = new List<Map>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Map temp = new Map(read1);
                mapes.Add(temp);
            }

            sr.Close();

            return mapes;
        }

        public override string ObtenCitaBibliografica()
        {
            return $"[{Autor} ({AnyCreacio}) - {Titol} [Mapa] - Escala:{Escala} - Zona: {RegioGeografica}]";
        }

        public void Mostra()
        {
            Utilitats.ObreImatge(this.RutaFitxer);
        }
    }
}
