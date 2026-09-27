using Cataleg_multimedia.classes_nivell_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes_nivell_2
{
    public class Partitura : Audio
    {
        public string instrumentPrincipal { get; set; } = "";
        public string tonalitat { get; set; } = "";
        public int nombrePagines { get; set; } = 0;
        public string editorial { get; set; } = "";
        public override double MidaArxiuMB
        {
            get
            {
                return nombrePagines * 2.5;
            }
        }

        public override bool esDigital
        {
            get { return false; } 
        }

        public Partitura() {}
        public Partitura(string CSVlinea) : base (CSVlinea)
        {
            string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");

            this.instrumentPrincipal = arrayDades[7];
            this.tonalitat = arrayDades[8];
            this.nombrePagines = Convert.ToInt32(arrayDades[9]);
            this.editorial = arrayDades[10];
        }

        public Partitura(string id = "", string titol = "", string autor = "", int anyCreacio = 0, List<string> etiquetes = null,
            string rutaFitxer = "", string genere = "", string instrumentPrincipal = "", string tonalitat = "",
            int nombrePagines = 0, string editorial = "") : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer,genere)
        {
            this.instrumentPrincipal = instrumentPrincipal;
            this.tonalitat = tonalitat;
            this.nombrePagines = nombrePagines;
            this.editorial = editorial;
        }

        public static List<Partitura> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Partitura> partitures = new List<Partitura>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Partitura temp = new Partitura(read1);
                partitures.Add(temp);
            }

            sr.Close();

            return partitures;
        }
        
        public override string InformacioExtesa()
        {
            return $"[{Titol}] - [{Autor}] - [{instrumentPrincipal}] - [{tonalitat}]";
        }
    }
}
