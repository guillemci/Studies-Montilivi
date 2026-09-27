using Cataleg_multimedia.classe_nivell_0.interficies.IComparer;
using Cataleg_multimedia.classes_nivell_2;

namespace Cataleg_multimedia.classes;

public class ArtDigital : BitMap, IDescarregable, IMostrable
{
    public string SoftwareUtilitzat { get; set; } = "";

    public ArtDigital() {}
    public ArtDigital(string CSVlinea) : base(CSVlinea)
    {
        //string[] arrayDades = Regex.Split(CSVlinea, @";(?! )");        
        string[] arrayDades = CSVlinea.Split(';');

        this.SoftwareUtilitzat = arrayDades[11];
    }

    public ArtDigital(string id, string titol, string autor, int anyCreacio,
        List<string> etiquetes, string rutaFitxer, int amplada,
        int alcada, string espaiColor, string resolucioDPI, string tipusCompressio,
        string softwareUtilitzat) : base(id, titol, autor, anyCreacio, etiquetes, rutaFitxer, amplada, alcada, espaiColor, resolucioDPI, tipusCompressio)
    {
        this.SoftwareUtilitzat = softwareUtilitzat;
    }
    
    public static List<ArtDigital> CarregarAmbCSV(string rutacsv)
    {
        StreamReader sr = new StreamReader(rutacsv);
        string read1 = sr.ReadLine();

        List<ArtDigital> artDigital = new List<ArtDigital>();

        while ((read1 = sr.ReadLine()) != null)
        {
            ArtDigital temp = new ArtDigital(read1);
            artDigital.Add(temp);
        }

        sr.Close();

        return artDigital;
    }

    public static Dictionary<string, ArtDigital> CarregarAmbCsvDictionary(string rutacsv)
    {
        StreamReader sr = new StreamReader(rutacsv);
        string read1 = sr.ReadLine();

        Dictionary<string, ArtDigital> logotipDictionary = new Dictionary<string, ArtDigital>();

        while ((read1 = sr.ReadLine()) != null)
        {
            ArtDigital temp = new ArtDigital(read1);
            logotipDictionary.Add(temp.Id, temp);
        }

        sr.Close();
        return logotipDictionary;
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