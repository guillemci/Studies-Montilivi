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
    public class Fotografia : BitMap, IDescarregable, IMostrable
    {
        public string ModelCamera { get; set; } = "";
        public string OberturaDiafgrama { get; set; } = "";
        public string Iso { get; set; } = "";

        public Fotografia() { }
        public Fotografia(string CSVlinea) : base(CSVlinea)
        {
            //string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");
            string[] arrayDades = CSVlinea.Split(';');

            this.ModelCamera = arrayDades[11];
            this.OberturaDiafgrama = arrayDades[12];
            this.Iso = arrayDades[13];
        }

        public Fotografia(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes, string rutaFitxer, int amplada,
            int alcada, string espaiColor, string resolucioDPI, string tipusCompressio,
            string modelCamera, string oberturaDiafgrama, string iso)
            : base(id, titol, autor, anyCreacio, etiquetes, rutaFitxer, amplada, alcada, espaiColor, resolucioDPI, tipusCompressio)
        {
            this.ModelCamera = modelCamera;
            this.OberturaDiafgrama = oberturaDiafgrama;
            this.Iso = iso;
        }


        public static List<Fotografia> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Fotografia> fotografia = new List<Fotografia>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Fotografia temp = new Fotografia(read1);
                fotografia.Add(temp);
            }

            sr.Close();

            return fotografia;
        }

        public static Dictionary<string, Fotografia> CarregarAmbCsvDictionary(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            Dictionary<string, Fotografia> fotografiaDictionary = new Dictionary<string, Fotografia>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Fotografia temp = new Fotografia(read1);
                fotografiaDictionary.Add(temp.Id, temp);
            }

            sr.Close();

            return fotografiaDictionary;
        }

        public void Descarrega()
        {
            Utilitats.Descarrega(this.RutaFitxer);
        }

        public void Mostra()
        {
            Utilitats.ObreImatge(this.RutaFitxer);
        }
    }
}