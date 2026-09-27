using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.classes_nivell_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classes
{
    public class Pelicula : Video, IMostrable, IDescarregable
    {
        public string Director { get; set; } = "";
        public string ClassificacioEdat { get; set; } = "";

        public Pelicula() { }
        public Pelicula(string CSVlinea) : base(CSVlinea)
        {
            //string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");
            string[] arrayDades = CSVlinea.Split(';');

            this.Director = arrayDades[9];
            this.ClassificacioEdat = arrayDades[10];
        }

        public Pelicula(string id, string titol, string autor, int anyCreacio,
            List<string> etiquetes, string rutaFitxer,
            string resolucio, string frameRate, TimeSpan durada, string director,
            string classificacioEdat) : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer,resolucio,frameRate,durada)
        {
            this.Director = director;
            this.ClassificacioEdat = classificacioEdat;
        }

        public static List<Pelicula> CarregarAmbCSV(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            List<Pelicula> pelicules = new List<Pelicula>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Pelicula temp = new Pelicula(read1);
                pelicules.Add(temp);
            }

            sr.Close();

            return pelicules;
        }

        public static Dictionary<string, Pelicula> CarregarAmbCsvDictionary(string rutacsv)
        {
            StreamReader sr = new StreamReader(rutacsv);
            string read1 = sr.ReadLine();

            Dictionary<string, Pelicula> PeliculaDictionary = new Dictionary<string, Pelicula>();

            while ((read1 = sr.ReadLine()) != null)
            {
                Pelicula temp = new Pelicula(read1);
                PeliculaDictionary.Add(temp.Id, temp);
            }

            sr.Close();

            return PeliculaDictionary;
        }

        public void Mostra()
        {
            Utilitats.ObreEnNavegador(this.RutaFitxer);
        }

        public void Descarrega()
        {
            Utilitats.Descarrega(this.RutaFitxer);
        }
    }
}