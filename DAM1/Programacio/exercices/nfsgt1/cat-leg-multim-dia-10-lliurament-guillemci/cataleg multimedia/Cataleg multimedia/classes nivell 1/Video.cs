using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes_nivell_2
{
    public abstract class Video : Mitja
    {
        public TimeSpan Durada { get; set; } = default;
        public string FrameRate { get; set; } = "";
        public string Resolucio { get; set; } = "";

        public Video() {}
        public Video(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.Resolucio = arrayDades[6];
            this.FrameRate = arrayDades[7];
            this.Durada = TimeSpan.FromSeconds(Convert.ToDouble(arrayDades[8]));
        }

        public Video(string id, string titol, string autor, int anyCreacio,
        List<string> etiquetes, string rutaFitxer,
        string resolucio, string frameRate, TimeSpan durada) : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer)
        {
            this.Durada = durada;
            this.FrameRate = frameRate;
            this.Resolucio = resolucio;
        }

        public override string InformacioExtesa()
        {
            return $"[{Titol}] - [{Autor}] - [{Resolucio}] - [{FrameRate}] - [{Durada}]";
        }
    }
}
