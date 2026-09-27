using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.classes_nivell_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes
{
    public class Documental : Video, IMostrable, IDescarregable
    {
        public string Tema { get; set; } = "";

        public Documental(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.Tema = arrayDades[9];
        }
        public Documental() { }
        public Documental(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes,
            string rutaFitxer, string resolucio, string frameRate,
            TimeSpan durada, string tema) : base(id, titol, autor, anyCreacio, etiquetes, rutaFitxer, resolucio, frameRate, durada)
        {
            this.Tema = tema;
        }

        public static List<Documental> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Documental> documentals = new List<Documental>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Documental temp = new Documental(read1);
                documentals.Add(temp);
            }

            sr.Close();
            return documentals;
        }

        public static Dictionary<string, Documental> CarregarAmbCsvDictionary(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            Dictionary<string, Documental> documentalDictionary = new Dictionary<string, Documental>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Documental temp = new Documental(read1);
                documentalDictionary.Add(temp.Id, temp);
            }

            sr.Close();
            return documentalDictionary;
        }

        public void Mostra()
        {
            Utilitats.ObreEnNavegador(this.RutaFitxer);
        }
        public void Descarrega()
        {
            Utilitats.Descarrega(this.RutaFitxer);
        }
    }
}
