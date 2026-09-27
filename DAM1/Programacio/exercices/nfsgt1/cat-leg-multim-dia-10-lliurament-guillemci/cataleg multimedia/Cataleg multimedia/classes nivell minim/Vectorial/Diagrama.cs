using Cataleg_multimedia.classes_nivell_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes
{
    public class Diagrama : Vectorial
    {
        public string TipusDiagrama { get; set; }
        public string SoftwareCreacio { get; set; }

        // Constructors
        public Diagrama() {}
        public Diagrama(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.TipusDiagrama = arrayDades[12];
            this.SoftwareCreacio = arrayDades[13];
        }

        public Diagrama(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes,
            string rutaFitxer, int amplada, int alcada, string espaiColor,
            string versioSvg, int nombreVectors, bool teFonsTransparent,
            string tipusDiagrama, string softwareCreacio) 
            : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer,amplada,alcada,espaiColor,versioSvg,nombreVectors,teFonsTransparent )
        {
            this.TipusDiagrama = tipusDiagrama;
            this.SoftwareCreacio = softwareCreacio;
        }

        public static List<Logotip> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Logotip> logotips = new List<Logotip>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Logotip temp = new Logotip(read1);
                logotips.Add(temp);
            }

            sr.Close();
            return logotips;
        }

        public static Dictionary<string, Diagrama> CarregarAmbCsvDictionary(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            Dictionary<string, Diagrama> diagramaDictionary = new Dictionary<string, Diagrama>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Diagrama temp = new Diagrama(read1);
                string idOriginal = temp.Id;
                string idNou = idOriginal;

                while (diagramaDictionary.ContainsKey(idNou))
                {
                    idNou += "_";
                }

                temp.Id = idNou;
                diagramaDictionary.Add(idNou, temp);
            }

            sr.Close();
            return diagramaDictionary;
        }
    }
}
