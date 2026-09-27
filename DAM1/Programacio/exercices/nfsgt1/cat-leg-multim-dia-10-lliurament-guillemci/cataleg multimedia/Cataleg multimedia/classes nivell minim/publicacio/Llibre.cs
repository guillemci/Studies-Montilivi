using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes
{
    public class Llibre : Publicacio, IMostrable
    {
        private string genereLiterari = "";
        private bool tapaDura = false;

        public string GenereLiterari
        {
            get { return this.genereLiterari; }
            set { this.genereLiterari = value; }
        }

        public bool TapaDura
        {
            get { return this.tapaDura; }
            set { this.tapaDura = value; }
        }

        public Llibre() {}
        public Llibre(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.genereLiterari = arrayDades[11];
            this.tapaDura = Convert.ToBoolean(arrayDades[12]);
        }

        public Llibre(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes, string rutaFitxer, string idioma, int nombreParaules,
            string editorial, string ISBN_ISSN, int pagines, string genereLiterari, bool tapaDura)
            : base(id, titol, autor, anyCreacio, etiquetes, rutaFitxer, idioma, nombreParaules, editorial, ISBN_ISSN, pagines)
        {
            this.genereLiterari = genereLiterari;
            this.tapaDura = tapaDura;
        }

        public static List<Llibre> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Llibre> llibres = new List<Llibre>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Llibre temp = new Llibre(read1);
                llibres.Add(temp);
            }

            sr.Close();

            return llibres;
        }

        public override string ObtenCitaBibliografica()
        {
            return $"[{Autor} ({AnyCreacio}) - {Titol} ({Editorial}) - ISBN: {ISBN_ISSN}]";
        }

        public void Mostra()
        {
            Utilitats.ObreEnNavegador(this.RutaFitxer);
        }
    }
}
