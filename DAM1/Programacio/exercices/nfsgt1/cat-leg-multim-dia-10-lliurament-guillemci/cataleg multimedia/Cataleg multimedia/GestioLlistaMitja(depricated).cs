//using Cataleg_multimedia.classes;
//using Cataleg_multimedia.classes_nivell_2;
//using Cataleg_multimedia.classes_nivell_minim.so;
//using Cataleg_multimedia.superclasse;
//using System.Text.Json;
//using System.Xml.Serialization;

//namespace Cataleg_multimedia
//{
//    internal class GestioLlistaMitja
//    {
//        public List<Mitja> LlistaMitja { get; set; } = new List<Mitja>();
//        public void BuidarLlista()
//        {
//            this.LlistaMitja.Clear();
//        }
//        public void CarregarCSV()
//        {
//            this.LlistaMitja.AddRange(Pelicula.CarregarAmbCSV("Pelicules.csv"));
//            this.LlistaMitja.AddRange(Llibre.CarregarAmbCSV("Llibres.csv"));
//            this.LlistaMitja.AddRange(Canço.CarregarAmbCSV("Cansons.csv"));
//            this.LlistaMitja.AddRange(Gravat.CarregarAmbCSV("Gravats.csv"));
//            this.LlistaMitja.AddRange(AudioLlibre.CarregarAmbCSV("Audiollibres.csv"));
//            this.LlistaMitja.AddRange(Manuscrit.CarregarAmbCSV("Manuscrits.csv"));
//            this.LlistaMitja.AddRange(Map.CarregarAmbCSV("Mapes.csv"));
//            this.LlistaMitja.AddRange(Podcast.CarregarAmbCSV("Podcats.csv"));
//            this.LlistaMitja.AddRange(Revista.CarregarAmbCSV("Revistes.csv"));
//            this.LlistaMitja.AddRange(Partitura.CarregarAmbCSV("Partitures.csv"));
//            this.LlistaMitja.AddRange(EfecteSonor.CarregarAmbCSV("Sons.csv"));
//            this.LlistaMitja.AddRange(Logotip.CarregarAmbCSV("Logos.csv"));
//            this.LlistaMitja.AddRange(Diagrama.CarregarAmbCSV("Diagrames.csv"));
//            this.LlistaMitja.AddRange(Fotografia.CarregarAmbCSV("Fotos.csv"));
//            this.LlistaMitja.AddRange(ArtDigital.CarregarAmbCSV("ArtDigital.csv"));
//            this.LlistaMitja.AddRange(Documental.CarregarAmbCSV("Documentals.csv"));
//            this.LlistaMitja.AddRange(Serie.CarregarAmbCSV("Series.csv"));
//        }
//        public void SerialitzarXML()
//        {
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Pelicula, Mitja>(this.LlistaMitja), "Pelicules.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Llibre, Mitja>(this.LlistaMitja), "Llibres.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Canço, Mitja>(this.LlistaMitja), "Cansons.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Gravat, Mitja>(this.LlistaMitja), "Gravats.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<AudioLlibre, Mitja>(this.LlistaMitja), "AudioLlibres.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Manuscrit, Mitja>(this.LlistaMitja), "Manuscrits.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Map, Mitja>(this.LlistaMitja), "Mapes.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Podcast, Mitja>(this.LlistaMitja), "Podcasts.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Revista, Mitja>(this.LlistaMitja), "Revistes.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Partitura, Mitja>(this.LlistaMitja), "Partitures.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<EfecteSonor, Mitja>(this.LlistaMitja), "EfectesSonors.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Logotip, Mitja>(this.LlistaMitja), "Logos.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Diagrama, Mitja>(this.LlistaMitja), "Diagrames.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Fotografia, Mitja>(this.LlistaMitja), "Fotografies.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<ArtDigital, Mitja>(this.LlistaMitja), "ArtDigital.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Documental, Mitja>(this.LlistaMitja), "Documentals.xml");
//            Utilitats.SerialitzaXML(Utilitats.ObtenTotsElsDunTipus<Serie, Mitja>(this.LlistaMitja), "Series.xml");
//        }
//        public void SerialitzarJSON()
//        {
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Pelicula, Mitja>(this.LlistaMitja), "Pelicules.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Llibre, Mitja>(this.LlistaMitja), "Llibres.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Canço, Mitja>(this.LlistaMitja), "Cansons.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Gravat, Mitja>(this.LlistaMitja), "Gravats.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<AudioLlibre, Mitja>(this.LlistaMitja), "AudioLlibres.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Manuscrit, Mitja>(this.LlistaMitja), "Manuscrits.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Map, Mitja>(this.LlistaMitja), "Mapes.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Podcast, Mitja>(this.LlistaMitja), "Podcasts.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Revista, Mitja>(this.LlistaMitja), "Revistes.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Partitura, Mitja>(this.LlistaMitja), "Partitures.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<EfecteSonor, Mitja>(this.LlistaMitja), "EfectesSonors.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Logotip, Mitja>(this.LlistaMitja), "Logos.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Diagrama, Mitja>(this.LlistaMitja), "Diagrames.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Fotografia, Mitja>(this.LlistaMitja), "Fotografies.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<ArtDigital, Mitja>(this.LlistaMitja), "ArtDigital.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Documental, Mitja>(this.LlistaMitja), "Documentals.json");
//            Utilitats.SerialitzaJSON(Utilitats.ObtenTotsElsDunTipus<Serie, Mitja>(this.LlistaMitja), "Series.json");
//        }
//        public void DeserialitzarJSON()
//        {
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Pelicula>("Pelicules.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Llibre>("Llibres.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Canço>("Cansons.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Gravat>("Gravats.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<AudioLlibre>("AudioLlibres.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Manuscrit>("Manuscrits.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Map>("Mapes.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Podcast>("Podcasts.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Revista>("Revistes.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Partitura>("Partitures.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<EfecteSonor>("EfectesSonors.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Logotip>("Logos.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Diagrama>("Diagrames.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Fotografia>("Fotografies.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<ArtDigital>("ArtDigital.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Documental>("Documentals.json"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Serie>("Series.json"));
//        }
//        public void DeserialitzarXML()
//        {
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Pelicula>("Pelicules.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Llibre>("Llibres.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Canço>("Cansons.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Gravat>("Gravats.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<AudioLlibre>("AudioLlibres.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Manuscrit>("Manuscrits.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Map>("Mapes.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Podcast>("Podcasts.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Revista>("Revistes.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Partitura>("Partitures.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<EfecteSonor>("EfectesSonors.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Logotip>("Logos.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Diagrama>("Diagrames.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Fotografia>("Fotografies.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<ArtDigital>("ArtDigital.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Documental>("Documentals.xml"));
//            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Serie>("Series.xml"));
//        }
//        public static void OrdenarPerTitolMitja(List<Mitja> llistaMitja)
//        {
//            for (int i = 0; i < llistaMitja.Count - 1; i++)
//            {
//                for (int j = i + 1; j < llistaMitja.Count; j++)
//                {
//                    if (llistaMitja[i].CompareTo(llistaMitja[j]) < 0)
//                    {
//                        Mitja temp = llistaMitja[j];
//                        llistaMitja[j] = llistaMitja[i];
//                        llistaMitja[i] = temp;
//                    }
//                }
//            }
//        }
//        public static void OrdenarMitja(List<Mitja> llistaMitja, IComparer<Mitja> comparador)
//        {
//            for (int i = 0; i < llistaMitja.Count - 1; i++)
//            {
//                for (int j = i + 1; j < llistaMitja.Count; j++)
//                {
//                    if (comparador.Compare(llistaMitja[i], llistaMitja[j]) < 0)
//                    {
//                        Mitja temp = llistaMitja[j];
//                        llistaMitja[j] = llistaMitja[i];
//                        llistaMitja[i] = temp;
//                    }
//                }
//            }
//        }
//    }
//}
