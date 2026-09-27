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
    public class Podcast : So, IMostrable
    {
        public string Presentador { get; set; } = "";
        public int NumeroEpisodi { get; set; } = 0;
        public Tema Tema { get; set; } = Tema.Res;
        public Podcast(string CSVlinea) : base (CSVlinea)
        {
            string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");

            this.Presentador = arrayDades[10];
            this.NumeroEpisodi = Convert.ToInt32(arrayDades[11]);

            List<string> possiblesTemes = new List<string>(arrayDades[12].Split('|'));
            this.Tema = Tema.Res;

            foreach (string tema in possiblesTemes)
            {
                if (tema != "") this.Tema |= Enum.Parse<Tema>(tema);
            }

        }

        public Podcast() {}
        public Podcast(string id, string titol, string autor, int anyCreacio, List<string> etiquetes,
            string rutaFitxer, string genere, BitRate bitRateKbps, bool esStereo, TimeSpan duradaSegons,
            string presentador, int numeroEpisodi, Tema tema) : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer,genere,bitRateKbps,esStereo,duradaSegons)
        {
            this.Presentador = presentador;
            this.NumeroEpisodi = numeroEpisodi;
            this.Tema = tema;
        }
        public static List<Podcast> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Podcast> podcasts = new List<Podcast>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Podcast temp = new Podcast(read1);
                podcasts.Add(temp);
            }

            sr.Close();

            return podcasts;
        }

        public override string InformacioExtesa()
        {
            return $"[{Titol}] - [{Autor}] - [{Presentador}] - [{NumeroEpisodi}] - [{Tema}]";
        }

        public void Mostra()
        {
            Utilitats.ObreMp3(this.RutaFitxer);
        }
    }
}
