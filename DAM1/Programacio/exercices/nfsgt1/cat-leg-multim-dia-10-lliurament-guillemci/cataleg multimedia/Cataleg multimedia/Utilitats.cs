using Cataleg_multimedia.classes;
using Cataleg_multimedia.classes_nivell_2;
using Cataleg_multimedia.classes_nivell_minim.so;
using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cataleg_multimedia
{
    internal class Utilitats
    {
        //public static List<T1> ObtenTotsElsDunTipus<T1, T2>(List<T2> colleccio)
        //{
        //    List<T1> resultat = new List<T1>();

        //    foreach (var valor in colleccio)
        //        if (valor is T1 t) resultat.Add(t);

        //    return resultat;
        //}

        public static void SerialitzaXML<T>(List<T> llista, string nomFitxer)
        {
            const string NOMCARPETA = "XML";
            string directoriXml = Path.Combine(Directory.GetCurrentDirectory(), NOMCARPETA);

            if (!Directory.Exists(directoriXml))
                Directory.CreateDirectory(directoriXml);

            try
            {
                using TextWriter writer = new StreamWriter(Path.Combine(directoriXml, nomFitxer));
                XmlSerializer serialitzador = new XmlSerializer(typeof(List<T>));
                serialitzador.Serialize(writer, llista);
            }
            catch (IOException e)
            {
                Console.WriteLine($"S'ha produit un error: {e.Message}");
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fitxer d'origen mal format");
            }
        }

        public static void SerialitzaJSON<T>(List<T> llista, string nomFitxer)
        {
            const string nomCarpeta = "JSON";
            string directoriJson = Path.Combine(Directory.GetCurrentDirectory(), nomCarpeta);
            var opcions = new JsonSerializerOptions();
            opcions.WriteIndented = true;
            opcions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            opcions.PropertyNameCaseInsensitive = true;

            if (!Directory.Exists(directoriJson))
                Directory.CreateDirectory(directoriJson);

            try
            {
                string json = JsonSerializer.Serialize(llista, opcions);

                File.WriteAllText(Path.Combine(directoriJson, nomFitxer), json);
            }
            catch (IOException e)
            {
                Console.WriteLine($"S'ha produit un error: {e.Message}");
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fitxer d'origen mal format");
            }
        }

        public static List<T> DeserialitzarXML<T>(string nomFitxer)
        {
            const string NOMCARPETA = "XML";
            string directoriXml = Path.Combine(Directory.GetCurrentDirectory(), NOMCARPETA);

            try
            {
                using TextReader reader = new StreamReader(Path.Combine(directoriXml, nomFitxer));
                XmlSerializer serialitzador = new XmlSerializer(typeof(List<T>));
                return (List<T>)serialitzador.Deserialize(reader);
            }
            catch (IOException e)
            {
                Console.WriteLine($"S'ha produit un error: {e.Message}");
                return new List<T>();
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fitxer d'origen mal format");
                return new List<T>();
            }
        }

        public static List<T> DeserialitzarJSON<T>(string nomFitxer)
        {
            const string nomCarpeta = "JSON";
            string directoriJson = Path.Combine(Directory.GetCurrentDirectory(), nomCarpeta);
            var opcions = new JsonSerializerOptions();
            opcions.WriteIndented = true;
            opcions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            opcions.PropertyNameCaseInsensitive = true;

            try
            {
                using TextReader reader = new StreamReader(Path.Combine(directoriJson, nomFitxer));
                string json = reader.ReadToEnd();
                return JsonSerializer.Deserialize<List<T>>(json, opcions);
            }
            catch (IOException e)
            {
                Console.WriteLine($"S'ha produit un error: {e.Message}");
                return new List<T>();
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fitxer d'origen mal format");
                return new List<T>();
            }
        }

        public static void ObreImatge(string rutaUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Netegem i afegim capçaleres que simulen un navegador real complet
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");
                    client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9,ca;q=0.8,es;q=0.7");
                    client.DefaultRequestHeaders.Add("Referer", "https://www.google.com/"); // Simulem que venim de Google // 1. Descarreguem els bytes de forma síncrona (.Result)
                    // Això bloqueja el fil fins que la descàrrega acaba
                    byte[] imatgeBytes = client.GetByteArrayAsync(rutaUrl).Result;

                    // 2. Generem una ruta temporal única
                    string nomFitxer = $"temp_imatge_{Guid.NewGuid()}.jpg";
                    string camiTemporal = Path.Combine(Path.GetTempPath(), nomFitxer);

                    // 3. Guardem el fitxer al disc
                    File.WriteAllBytes(camiTemporal, imatgeBytes);

                    // 4. Obrim amb el visor del sistema
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = camiTemporal,
                        UseShellExecute = true
                    };

                    Process.Start(psi);
                }
            }
            catch (AggregateException ae)
            {
                // HttpClient llança AggregateException quan es fa servir .Result
                Console.WriteLine($"Error de xarxa: {ae.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void ObreImatgeAmbApiKey(string rutaUrl, string api_key = "")
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Netegem i afegim capçaleres que simulen un navegador real complet
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");
                    client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9,ca;q=0.8,es;q=0.7");
                    client.DefaultRequestHeaders.Add("Referer", "https://www.google.com/"); // Simulem que venim de Google // 1. Descarreguem els bytes de forma síncrona (.Result)
                    // Això bloqueja el fil fins que la descàrrega acaba
                    byte[] imatgeBytes = client.GetByteArrayAsync(rutaUrl + $"&api_key={api_key}").Result;

                    // 2. Generem una ruta temporal única
                    string nomFitxer = $"temp_imatge_{Guid.NewGuid()}.jpg";
                    string camiTemporal = Path.Combine(Path.GetTempPath(), nomFitxer);

                    // 3. Guardem el fitxer al disc
                    File.WriteAllBytes(camiTemporal, imatgeBytes);

                    // 4. Obrim amb el visor del sistema
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = camiTemporal,
                        UseShellExecute = true
                    };

                    Process.Start(psi);
                }
            }
            catch (AggregateException ae)
            {
                // HttpClient llança AggregateException quan es fa servir .Result
                Console.WriteLine($"Error de xarxa: {ae.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void ObreSVG(string rutaUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Netegem i afegim capçaleres que simulen un navegador real complet
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");
                    client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9,ca;q=0.8,es;q=0.7");
                    client.DefaultRequestHeaders.Add("Referer", "https://www.google.com/"); // Simulem que venim de Google // 1. Descarreguem els bytes de forma síncrona (.Result)
                    // Això bloqueja el fil fins que la descàrrega acaba
                    byte[] imatgeBytes = client.GetByteArrayAsync(rutaUrl).Result;

                    // 2. Generem una ruta temporal única
                    string nomFitxer = $"temp_imatge_{Guid.NewGuid()}.svg";
                    string camiTemporal = Path.Combine(Path.GetTempPath(), nomFitxer);

                    // 3. Guardem el fitxer al disc
                    File.WriteAllBytes(camiTemporal, imatgeBytes);

                    // 4. Obrim amb el visor del sistema
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = camiTemporal,
                        UseShellExecute = true
                    };

                    Process.Start(psi);
                }
            }
            catch (AggregateException ae)
            {
                // HttpClient llança AggregateException quan es fa servir .Result
                Console.WriteLine($"Error de xarxa: {ae.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void ObreMp3(string rutaUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Netegem i afegim capçaleres que simulen un navegador real complet
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");
                    client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9,ca;q=0.8,es;q=0.7");
                    client.DefaultRequestHeaders.Add("Referer", "https://www.google.com/"); // Simulem que venim de Google // 1. Descarreguem els bytes de forma síncrona (.Result)
                    // Això bloqueja el fil fins que la descàrrega acaba
                    byte[] imatgeBytes = client.GetByteArrayAsync(rutaUrl).Result;

                    // 2. Generem una ruta temporal única
                    string nomFitxer = $"temp_imatge_{Guid.NewGuid()}.mp3";
                    string camiTemporal = Path.Combine(Path.GetTempPath(), nomFitxer);

                    // 3. Guardem el fitxer al disc
                    File.WriteAllBytes(camiTemporal, imatgeBytes);

                    // 4. Obrim amb el visor del sistema
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = camiTemporal,
                        UseShellExecute = true
                    };

                    Process.Start(psi);
                }
            }
            catch (AggregateException ae)
            {
                // HttpClient llança AggregateException quan es fa servir .Result
                Console.WriteLine($"Error de xarxa: {ae.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void ObreEnNavegador(string rutaUrl)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = rutaUrl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obrir el navegador: {ex.Message}");
            }
        }

        public static void Descarrega(string rutaUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(15);

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");

                    Console.WriteLine("Connectant amb el servidor...");

                    var response = client.GetAsync(rutaUrl).GetAwaiter().GetResult();

                    Console.WriteLine($"Status: {response.StatusCode}");

                    response.EnsureSuccessStatusCode();

                    byte[] fitxerBytes = response.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();

                    string carpetaDownloads = Path.Combine(Directory.GetCurrentDirectory(), "descarregues");
                    Directory.CreateDirectory(carpetaDownloads);

                    string extensio = Path.GetExtension(rutaUrl);
                    if (string.IsNullOrEmpty(extensio))
                        extensio = ".dat";

                    string nomFitxer = $"fitxer_{DateTime.Now:yyyyMMdd_HHmmss_fff}{extensio}";
                    string rutaDesti = Path.Combine(carpetaDownloads, nomFitxer);

                    File.WriteAllBytes(rutaDesti, fitxerBytes);

                    Console.WriteLine($"Èxit! Fitxer guardat a: {rutaDesti}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"La descàrrega ha fallat: {ex.Message}");
            }
        }
    }
}
