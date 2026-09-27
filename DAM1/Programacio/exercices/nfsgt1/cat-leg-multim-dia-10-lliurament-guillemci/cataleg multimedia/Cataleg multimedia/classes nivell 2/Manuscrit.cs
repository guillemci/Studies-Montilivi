using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.subsuperclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes
{
    public class Manuscrit : Text, IMostrable
    {
        private string tipusCaligrafia = "";
        private string estatConservacio = "";
        private string materialSuport = "";
        private int pagines = 0;

        public string TipusCaligrafia
        {
            get { return this.tipusCaligrafia; }
            set { this.tipusCaligrafia = value; }
        }

        public string EstatConservacio
        {
            get { return this.estatConservacio; }
            set { this.estatConservacio = value; }
        }

        public string MaterialSuport
        {
            get { return this.materialSuport; }
            set { this.materialSuport = value; }
        }

        public int Pagines
        {
            get { return this.pagines; }
            set { this.pagines = value; }
        }

        public Manuscrit() {}
        public Manuscrit(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.tipusCaligrafia = arrayDades[8];
            this.estatConservacio = arrayDades[9];
            this.materialSuport = arrayDades[10];
            this.pagines = Convert.ToInt32(arrayDades[11]);
        }

        public Manuscrit(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes, string rutaFitxer, string idioma, int nombreParaules,
            string tipusCaligrafia, string estatConservacio, string materialSuport, int pagines)
            : base(id,titol,autor,anyCreacio, etiquetes, rutaFitxer,idioma,nombreParaules)
        {
            this.tipusCaligrafia = tipusCaligrafia;
            this.estatConservacio = estatConservacio;
            this.materialSuport = materialSuport;
            this.pagines = pagines;
        }

        public static List<Manuscrit> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Manuscrit> manuscrits = new List<Manuscrit>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Manuscrit temp = new Manuscrit(read1);
                manuscrits.Add(temp);
            }

            sr.Close();

            return manuscrits;
        }

        public override string InformacioExtesa()
        {
            return $"Manuscrit: {Titol} - cal·ligrafia {TipusCaligrafia}, estat {EstatConservacio}, suport {MaterialSuport}, {Pagines} pàgines";
        }

        public override string ObtenCitaBibliografica()
        {
            return $"[{Titol} ({AnyCreacio}) - Suport: {MaterialSuport} - Enllaç: {RutaFitxer}]";
        }

        public void Mostra()
        {
            Utilitats.ObreEnNavegador(this.RutaFitxer);
        }
    }
}
