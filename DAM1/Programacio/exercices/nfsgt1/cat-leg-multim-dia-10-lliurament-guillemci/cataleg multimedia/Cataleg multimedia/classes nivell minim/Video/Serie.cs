using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.classes_nivell_2;

namespace Cataleg_multimedia.classes;

public class Serie : Video, IMostrable, IDescarregable
{
    public string Director { get; set; }
    public string ClassificacioEdat { get; set; }

    public Serie(string CSVlinea) : base(CSVlinea)
    {
        //string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");
        string[] arrayDades = CSVlinea.Split(';');

        this.Director = arrayDades[9];
        this.ClassificacioEdat = arrayDades[10];
    }

    public Serie() {}
    public Serie(string id, string titol, string autor, int anyCreacio,
        List<string> etiquetes, string rutaFitxer,
        string resolucio, string frameRate, TimeSpan durada, string director,
        string classificacioEdat) : base(id,titol,autor,anyCreacio,etiquetes,rutaFitxer,resolucio,frameRate,durada)
    {
        this.Director = director;
        this.ClassificacioEdat = classificacioEdat;
    }

    public static List<Serie> CarregarAmbCSV(string rutacsv)
    {
        StreamReader sr = new StreamReader(rutacsv);
        string read1 = sr.ReadLine();

        List<Serie> series = new List<Serie>();

        while ((read1 = sr.ReadLine()) != null)
        {
            Serie temp = new Serie(read1);
            series.Add(temp);
        }

        sr.Close();

        return series;
    }

    public static Dictionary<string, Serie> CarregarAmbCsvDictionary(string rutacsv)
    {
        StreamReader sr = new StreamReader(rutacsv);
        string read1 = sr.ReadLine();

        Dictionary<string, Serie> series = new Dictionary<string, Serie>();

        while ((read1 = sr.ReadLine()) != null)
        {
            Serie temp = new Serie(read1);
            series.Add(temp.Id, temp);
        }

        sr.Close();

        return series;
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