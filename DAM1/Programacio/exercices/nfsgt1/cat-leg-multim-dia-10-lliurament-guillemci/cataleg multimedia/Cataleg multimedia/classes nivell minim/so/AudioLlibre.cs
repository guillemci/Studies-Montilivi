using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.classes_nivell_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes
{
    public class AudioLlibre : So, IMostrable, IDescarregable
    {
        public string Narrador { get; set; } = "";
        public string Idioma { get; set; } = "";
        public int Capitols { get; set; } = 0;

        public AudioLlibre() {}
        public AudioLlibre(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.Narrador = arrayDades[10];
            this.Idioma = arrayDades[11];
            this.Capitols = Convert.ToInt32(arrayDades[12]);
        }

        public AudioLlibre(string id, string titol, string autor, int anyCreacio, List<string> etiquetes,
            string rutaFitxer, string genere, BitRate bitrateKbps, bool esStereo, TimeSpan duradaSegons,
            string narrador, string idioma, int capitols) : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer,genere, bitrateKbps, esStereo, duradaSegons)
        {
            this.Narrador = narrador;
            this.Idioma = idioma;
            this.Capitols = capitols;
        }

        public static List<AudioLlibre> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<AudioLlibre> audioLlibres = new List<AudioLlibre>();

            while ((read1 = sr.ReadLine()) != null)
            {
                AudioLlibre temp = new AudioLlibre(read1);
                audioLlibres.Add(temp);
            }

            sr.Close();

            return audioLlibres;
        }

        public override string InformacioExtesa()
        {
            return $"[{Autor}] - [{Titol}] - [{Capitols}] - [{Idioma}]";
        }

        public void Mostra()
        {
            Utilitats.ObreMp3(this.RutaFitxer);
        }

        public void Descarrega()
        {
            Utilitats.Descarrega(this.RutaFitxer);
        }
    }
}
