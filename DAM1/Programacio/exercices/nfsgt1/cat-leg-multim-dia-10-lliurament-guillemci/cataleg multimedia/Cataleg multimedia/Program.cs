using Cataleg_multimedia.classes;
using Cataleg_multimedia.classes_nivell_2;
using Cataleg_multimedia.classes_nivell_minim.so;
using Cataleg_multimedia.superclasse;

namespace Cataleg_multimedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cataleg biblio = new Cataleg();
            bool sortir = false;

            while (!sortir)
            {
                Menus.MainMeu(biblio);

                string opcio = Console.ReadLine();

                switch (opcio)
                {
                    case "1":
                        Console.Clear();
                        biblio.CarregarCSV();
                        Console.WriteLine("CSV Deserialitzat, dona enter per continuar");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Clear();
                        biblio.DeserialitzarJSON();
                        Console.WriteLine("JSON Deserialitzat, dona enter per continuar");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        biblio.DeserialitzarXML();
                        Console.WriteLine("XML Deserialitzat, dona enter per continuar");
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.Clear();
                        Mitja.ImprimeixCataleg(biblio);
                        Console.WriteLine("Llista llegida, dona enter per continuar");
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.Clear();
                        biblio.SerialitzarJSON();
                        Console.WriteLine("JSON Serialitzat, dona enter per continuar");
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.Clear();
                        biblio.SerialitzarXML();
                        Console.WriteLine("XML Serialitzat, dona enter per continuar");
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.Clear();
                        biblio.BuidarLlista();
                        Console.WriteLine("Llista buidada, dona enter per continuar");
                        Console.ReadLine();
                        break;
                    case "8":
                        Console.Clear();
                        Menus.OrdenarMenu(biblio);
                        break;
                    case "9":
                        Console.Clear();
                        Menus.Consulta(biblio);
                        break;
                    case "10":
                        Console.Clear();
                        Menus.MainMenuLinq(biblio);
                        break;
                    case "11":
                        sortir = true;
                        break;
                }
            }
        }
    }
}
