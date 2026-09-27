using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.classes_nivell_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes
{
    public class Logotip : Vectorial, IMostrable, IDescarregable
    {
        public string Empresa { get; set; } = "";
        public string ManualIdentitatUrl { get; set; } = "";

        public Logotip() { }
        public Logotip(string CSVlinea) : base(CSVlinea)
        {
            string[] arrayDades = CSVlinea.Split(';');

            this.Empresa = arrayDades[12];
            this.ManualIdentitatUrl = arrayDades[13];
        }

        public Logotip(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes,
            string rutaFitxer, int amplada, int alcada, string espaiColor,
            string versioSVG, int nombreVectors, bool teFonsTransparent,
            string empresa, string manualIdentitatUrl) 
            : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer,amplada,alcada,espaiColor,versioSVG, nombreVectors, teFonsTransparent)
        {
            this.Empresa = empresa;
            this.ManualIdentitatUrl = manualIdentitatUrl;
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

        public static Dictionary<string, Logotip> CarregarAmbCsvDictionary(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            Dictionary<string, Logotip> logotipDictionary = new Dictionary<string, Logotip>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Logotip temp = new Logotip(read1);
                string idOriginal = temp.Id;
                string idNou = idOriginal;

                // aquest bucle posara "_" mentres detecti una clau duplicada fix necesari per el funcionament
                while (logotipDictionary.ContainsKey(idNou))
                {
                    idNou += "_";
                }

                temp.Id = idNou;
                logotipDictionary.Add(idNou, temp);
            }

            sr.Close();
            return logotipDictionary;
        }

        public void Mostra()
        {
            Utilitats.ObreSVG(this.RutaFitxer);
        }

        public void Descarrega()
        {
            Utilitats.Descarrega(this.RutaFitxer);
        }
    }
}
