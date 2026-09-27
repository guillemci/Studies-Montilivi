using Cataleg_multimedia.classe_nivell_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes_nivell_2
{
    public abstract class BitMap : Imatge
    {
        public string ResolucioDpi { get; set; } = "";
        public string TipusCompressio { get; set; } = "";
        public override double Megapixels
        {
            get
            {
                return (Alcada * Amplada) / 1000000.0;
            }
        }

        public BitMap(){}
        public BitMap (string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.ResolucioDpi = arrayDades[9];
            this.TipusCompressio = arrayDades[10];
        }

        public BitMap (string id,string titol, string autor, int AnyCreacio, List<string> Etiquetes, 
            string RutaFitxer, int Amplada, int Alcada, string EspaiColor, string ResolucioDpi, string TipusCompressio) 
            : base(id, titol, autor , AnyCreacio, Etiquetes, RutaFitxer, Alcada, Amplada, EspaiColor)
        {
            this.ResolucioDpi = ResolucioDpi;
            this.TipusCompressio = TipusCompressio;
        }
    }
}
