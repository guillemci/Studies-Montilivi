using Cataleg_multimedia.classe_nivell_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes_nivell_2
{
    public abstract class Vectorial : Imatge
    {
        public int NombreVectors { get; set; } = 0;
        public bool TeFonsTransparent { get; set; } = false;
        public string VersioSVG { get; set; } = "";
        public override double Megapixels
        {
            get
            {
                return NombreVectors / 10000;
            }
        }

        //this.NombreVectors = nombreVectors;
        //this.TeFonsTransparent = teFonsTransparent;
        //this.VersioSvg = versioSvg;

        public Vectorial() {}
        public Vectorial(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.VersioSVG = arrayDades[9];
            this.NombreVectors = Convert.ToInt32(arrayDades[10]);
            this.TeFonsTransparent = Convert.ToBoolean(arrayDades[11]);
        }

        public Vectorial(string id, string titol, string autor, int anyCreacio, List<string> etiquetes, 
            string rutaFitxer, int Alcada, int Amplada, string EspaiColor, 
            string VersioSvg, int NombreVectors, bool TeFonsTransparent) 
            : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer, Alcada, Amplada,EspaiColor)
        {
            this.VersioSVG = VersioSvg;
            this.NombreVectors = NombreVectors;
            this.TeFonsTransparent = TeFonsTransparent;
        }
    }
}
