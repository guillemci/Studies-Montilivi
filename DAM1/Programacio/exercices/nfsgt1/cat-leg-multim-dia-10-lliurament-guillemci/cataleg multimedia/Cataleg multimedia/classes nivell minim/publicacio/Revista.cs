using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes
{
    public class Revista : Publicacio
    {
        private string periodicitat = "";
        private int numeroVolum = 0;
        private int numeroExemplar = 0;
        private string mes = "";

        public string Periodicitat
        {
            get { return this.periodicitat; }
            set { this.periodicitat = value; }
        }

        public int NumeroVolum
        {
            get { return this.numeroVolum; }
            set { this.numeroVolum = value; }
        }

        public int NumeroExemplar
        {
            get { return this.numeroExemplar; }
            set { this.numeroExemplar = value; }
        }

        public string Mes
        {
            get { return this.mes; }
            set { this.mes = value; }
        }

        public Revista() {}
        public Revista(string CSVlinea) : base (CSVlinea)
        {
            string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");

            this.periodicitat = arrayDades[11];
            this.numeroVolum = Convert.ToInt32(arrayDades[12]);
            this.numeroExemplar = Convert.ToInt32(arrayDades[13]);
            this.mes = arrayDades[14];
        }

        public Revista(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes, string rutaFitxer, string idioma, int nombreParaules,
            string editorial, string ISBN_ISSN, int pagines, string periodicitat,
            int numeroVolum, int numeroExemplar, string mes) : base(id, titol, 
                autor, anyCreacio, etiquetes, 
                rutaFitxer, idioma, nombreParaules, editorial, ISBN_ISSN, pagines)
        {
            this.periodicitat = periodicitat;
            this.numeroVolum = numeroVolum;
            this.numeroExemplar = numeroExemplar;
            this.mes = mes;
        }

        public static List<Revista> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Revista> revistes = new List<Revista>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Revista temp = new Revista(read1);
                revistes.Add(temp);
            }

            sr.Close();

            return revistes;
        }

        public override string ObtenCitaBibliografica()
        {
            return $"[{Titol}, Número {NumeroExemplar}), Volum {NumeroVolum}({Mes} - {AnyCreacio})]";
        }
    }
}
