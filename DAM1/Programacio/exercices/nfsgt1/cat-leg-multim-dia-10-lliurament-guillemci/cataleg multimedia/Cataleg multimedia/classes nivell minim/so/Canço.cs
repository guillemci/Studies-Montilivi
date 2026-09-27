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
    public class Canço : So, IMostrable
    {
        public string Album { get; set; } = "";
        public int NumeroPista { get; set; } = 0;

        public Canço() { }
        public Canço(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");

            this.Album = arrayDades[10];
            this.NumeroPista = Convert.ToInt32(arrayDades[11]);
        }

        public Canço(string id, string titol, string autor, int anyCreacio, List<string> etiquetes,
            string rutaFitxer, string genere, BitRate bitrateKbps, bool esStereo, TimeSpan duradaSegons,
            string album, int numeroPista) : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer,genere, bitrateKbps, esStereo,duradaSegons)
        {
            this.Album = album;
            this.NumeroPista = numeroPista;
        }

        public static List<Canço> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Canço> cançons = new List<Canço>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Canço temp = new Canço(read1);
                cançons.Add(temp);
            }

            sr.Close();

            return cançons;
        }

        public override string InformacioExtesa()
        {
            return $"[{Titol}] - [{Autor}] - [{Album}] - [{NumeroPista}]";
        }

        public void Mostra()
        {
            Utilitats.ObreEnNavegador(this.RutaFitxer);
        }
    }
}
