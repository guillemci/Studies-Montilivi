using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classe_nivell_0
{
    public abstract class Imatge : Mitja
    {
        public double Alcada { get; set; } = 0;
        public double Amplada { get; set; } = 0;
        public string EspaiColor { get; set; } = "";
        public abstract double Megapixels { get; }

        public Imatge() {}
        public Imatge(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.Alcada = Convert.ToInt32(arrayDades[6]);
            this.Amplada = Convert.ToInt32(arrayDades[7]);
            this.EspaiColor = arrayDades[8];
        }

        public Imatge (string id, string titol, string autor, int anyCreacio, List<string>
            etiquetes, string rutaFitxer, double Alçada, double Amplada, string EspaiColor) 
            : base(id, titol, autor, anyCreacio, etiquetes, rutaFitxer)
        {
            this.Alcada = Alçada;
            this.Amplada = Amplada;
            this.EspaiColor = EspaiColor;

        }

        public override string InformacioExtesa()
        {
            return $"{Titol} ({AnyCreacio}) - {Amplada}x{Alcada}px, espai de color: {EspaiColor}";
        }
    }
}
