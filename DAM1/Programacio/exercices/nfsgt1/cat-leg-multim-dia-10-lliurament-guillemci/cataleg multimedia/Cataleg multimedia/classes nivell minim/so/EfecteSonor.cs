using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.classes_nivell_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes_nivell_minim.so
{
    public class EfecteSonor : So, IMostrable
    {
        public EfecteSonor() { }
        public EfecteSonor(string CSVlinea) : base(CSVlinea) {}

        public EfecteSonor(string id, string titol, string autor, int anyCreacio, List<string> etiquetes,
            string rutaFitxer, string genere, BitRate bitRateKbps, bool esStereo, TimeSpan duradaSegons) 
            : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer,genere,bitRateKbps,esStereo,duradaSegons) {}

        public override string ToString()
        {
            return $"[{GetType().Name}] {Titol} ({AnyCreacio}) - {Autor}";
        }

        public static List<EfecteSonor> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<EfecteSonor> efectesonors = new List<EfecteSonor>();

            while ((read1 = sr.ReadLine()) != null)
            {
                EfecteSonor temp = new EfecteSonor(read1);
                efectesonors.Add(temp);
            }

            sr.Close();

            return efectesonors;
        }

        public override string InformacioExtesa()
        {
            return $"[{Titol}] - [{Autor}] - [{EsStereo}] - [{BitRateKbps}] - [{DuradaSegons}]";
        }

        public void Mostra()
        {
            Utilitats.ObreMp3(this.RutaFitxer);
        }
    }
}
