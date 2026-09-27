using Cataleg_multimedia.classes_nivell_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes_nivell_2
{
    public abstract class So : Audio
    {
        public BitRate BitRateKbps { get; set; } = BitRate.Res;
        public bool EsStereo { get; set; } = false;
        public TimeSpan DuradaSegons { get; set; } = default;

        public override double MidaArxiuMB
        {
            get
            {
                return (double)BitRateKbps * DuradaSegons.TotalSeconds / 1000;
            }
        }

        public override bool esDigital
        {
            get { return true; }
        }

        public So() { }
        public So (string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");

            this.BitRateKbps = Enum.Parse<BitRate>(arrayDades[7]);
            this.EsStereo = Convert.ToBoolean(arrayDades[8]);
            this.DuradaSegons = TimeSpan.FromSeconds(Convert.ToDouble(arrayDades[9]));
        }
        public So (string id, string titol, string autor, int anyCreacio, List<string> etiquetes,
            string rutaFitxer, string genere, BitRate bitRateKbps, bool esStereo, TimeSpan duradaSegons) 
            : base(id, titol, autor, anyCreacio, etiquetes, rutaFitxer, genere)
        {
            this.BitRateKbps = bitRateKbps;
            this.EsStereo = esStereo;
            this.DuradaSegons = duradaSegons;
        }

        public override string InformacioExtesa()
        {
            return $"So: {Titol} - gènere {Genere}, bitrate {BitRateKbps} kbps, {(EsStereo ? "estèreo" : "mono")}, durada {DuradaSegons}";
        }
    }
}
