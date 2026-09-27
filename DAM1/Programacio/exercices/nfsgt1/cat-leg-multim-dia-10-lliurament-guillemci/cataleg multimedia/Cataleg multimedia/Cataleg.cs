using Cataleg_multimedia.classes;
using Cataleg_multimedia.classes_nivell_2;
using Cataleg_multimedia.classes_nivell_minim.so;
using Cataleg_multimedia.superclasse;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia
{
    public class Cataleg : IList<Mitja>
    {
        private const string pathPeli = "Pelicules.csv";
        private const string pathLlibres = "Llibres.csv";
        private const string pathCansons = "Cansons.csv";
        private const string pathGravats = "Gravats.csv";
        private const string pathAudioLlibres = "Audiollibres.csv";
        private const string pathManuscrits = "Manuscrits.csv";
        private const string pathMapes = "Mapes.csv";
        private const string pathPocast = "Podcats.csv";
        private const string pathRevistes = "Revistes.csv";
        private const string pathPartitures = "Partitures.csv";
        private const string pathSons = "Sons.csv";
        private const string pathLogos = "Logos.csv";
        private const string pathDiagrames = "Diagrames.csv";
        private const string pathFotos = "Fotos.csv";
        private const string pathArtDigital = "ArtDigital.csv";
        private const string pathDocumental = "Documentals.csv";
        private const string pathSeries = "Series.csv";

        private const string xmlPeli = "Pelicules.xml";
        private const string xmlLlibres = "Llibres.xml";
        private const string xmlCansons = "Cansons.xml";
        private const string xmlGravats = "Gravats.xml";
        private const string xmlAudioLlibres = "AudioLlibres.xml";
        private const string xmlManuscrits = "Manuscrits.xml";
        private const string xmlMapes = "Mapes.xml";
        private const string xmlPodcasts = "Podcasts.xml";
        private const string xmlRevistes = "Revistes.xml";
        private const string xmlPartitures = "Partitures.xml";
        private const string xmlSons = "EfectesSonors.xml";
        private const string xmlLogos = "Logos.xml";
        private const string xmlDiagrames = "Diagrames.xml";
        private const string xmlFotos = "Fotografies.xml";
        private const string xmlArtDigital = "ArtDigital.xml";
        private const string xmlDocumental = "Documentals.xml";
        private const string xmlSeries = "Series.xml";

        private const string jsonPeli = "Pelicules.json";
        private const string jsonLlibres = "Llibres.json";
        private const string jsonCansons = "Cansons.json";
        private const string jsonGravats = "Gravats.json";
        private const string jsonAudioLlibres = "AudioLlibres.json";
        private const string jsonManuscrits = "Manuscrits.json";
        private const string jsonMapes = "Mapes.json";
        private const string jsonPodcasts = "Podcasts.json";
        private const string jsonRevistes = "Revistes.json";
        private const string jsonPartitures = "Partitures.json";
        private const string jsonSons = "EfectesSonors.json";
        private const string jsonLogos = "Logos.json";
        private const string jsonDiagrames = "Diagrames.json";
        private const string jsonFotos = "Fotografies.json";
        private const string jsonArtDigital = "ArtDigital.json";
        private const string jsonDocumental = "Documentals.json";
        private const string jsonSeries = "Series.json";

        private List<Mitja> LlistaMitja = new List<Mitja>();

        public IEnumerable<Mitja> MitjansSenseEtiquetes
        {
            get
            {
                foreach (Mitja element in this)
                {
                    if (element.Etiquetes.Count == 0)
                        yield return element;
                }
            }
        }

        public IEnumerable<So> MitjansEstereo
        {
            get
            {
                foreach (So element in ObtenTotsElsDUnTipus<So>())
                {
                    yield return element;
                }
            }
        }

        public int Capacity
        {
            get { return this.LlistaMitja.Capacity; }
        }

        public int Count
        {
            get { return this.LlistaMitja.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public Mitja this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                    throw new ArgumentOutOfRangeException("index");

                return this.LlistaMitja[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                    throw new ArgumentOutOfRangeException("index");

                this.LlistaMitja[index] = value;
            }
        }

        public void Add(Mitja element)
        {
            this.LlistaMitja.Add(element);
        }

        public void Clear()
        {
            this.LlistaMitja.Clear();
        }

        public bool Contains(Mitja element)
        {
            return this.LlistaMitja.Contains(element);
        }

        public void CopyTo(Mitja[] array, int arrayIndex)
        {
            this.LlistaMitja.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Mitja> GetEnumerator()
        {
            foreach (var element in this.LlistaMitja)
                yield return element;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(Mitja element)
        {
            return this.LlistaMitja.IndexOf(element);
        }

        public void Insert(int index, Mitja element)
        {
            this.LlistaMitja.Insert(index, element);
        }

        public bool Remove(Mitja element)
        {
            return this.LlistaMitja.Remove(element);
        }

        public void RemoveAt(int index)
        {
            this.LlistaMitja.RemoveAt(index);
        }

        public void CarregarCSV()
        {
            this.LlistaMitja.AddRange(Pelicula.CarregarAmbCSV(pathPeli));
            this.LlistaMitja.AddRange(Llibre.CarregarAmbCSV(pathLlibres));
            this.LlistaMitja.AddRange(Canço.CarregarAmbCSV(pathCansons));
            this.LlistaMitja.AddRange(Gravat.CarregarAmbCSV(pathGravats));
            this.LlistaMitja.AddRange(AudioLlibre.CarregarAmbCSV(pathAudioLlibres));
            this.LlistaMitja.AddRange(Manuscrit.CarregarAmbCSV(pathManuscrits));
            this.LlistaMitja.AddRange(Map.CarregarAmbCSV(pathMapes));
            this.LlistaMitja.AddRange(Podcast.CarregarAmbCSV(pathPocast));
            this.LlistaMitja.AddRange(Revista.CarregarAmbCSV(pathRevistes));
            this.LlistaMitja.AddRange(Partitura.CarregarAmbCSV(pathPartitures));
            this.LlistaMitja.AddRange(EfecteSonor.CarregarAmbCSV(pathSons));
            this.LlistaMitja.AddRange(Logotip.CarregarAmbCSV(pathLogos));
            this.LlistaMitja.AddRange(Diagrama.CarregarAmbCSV(pathDiagrames));
            this.LlistaMitja.AddRange(Fotografia.CarregarAmbCSV(pathFotos));
            this.LlistaMitja.AddRange(ArtDigital.CarregarAmbCSV(pathArtDigital));
            this.LlistaMitja.AddRange(Documental.CarregarAmbCSV(pathDocumental));
            this.LlistaMitja.AddRange(Serie.CarregarAmbCSV(pathSeries));
        }
        public void SerialitzarXML()
        {
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Pelicula>().ToList(), xmlPeli);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Llibre>().ToList(), xmlLlibres);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Canço>().ToList(), xmlCansons);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Gravat>().ToList(), xmlGravats);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<AudioLlibre>().ToList(), xmlAudioLlibres);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Manuscrit>().ToList(), xmlManuscrits);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Map>().ToList(), xmlMapes);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Podcast>().ToList(), xmlPodcasts);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Revista>().ToList(), xmlRevistes);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Partitura>().ToList(), xmlPartitures);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<EfecteSonor>().ToList(), xmlSons);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Logotip>().ToList(), xmlLogos);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Diagrama>().ToList(), xmlDiagrames);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Fotografia>().ToList(), xmlFotos);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<ArtDigital>().ToList(), xmlArtDigital);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Documental>().ToList(), xmlDocumental);
            Utilitats.SerialitzaXML(this.ObtenTotsElsDUnTipus<Serie>().ToList(), xmlSeries);
        }
        public void SerialitzarJSON()
        {
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Pelicula>().ToList(), jsonPeli);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Llibre>().ToList(), jsonLlibres);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Canço>().ToList(), jsonCansons);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Gravat>().ToList(), jsonGravats);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<AudioLlibre>().ToList(), jsonAudioLlibres);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Manuscrit>().ToList(), jsonManuscrits);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Map>().ToList(), jsonMapes);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Podcast>().ToList(), jsonPodcasts);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Revista>().ToList(), jsonRevistes);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Partitura>().ToList(), jsonPartitures);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<EfecteSonor>().ToList(), jsonSons);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Logotip>().ToList(), jsonLogos);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Diagrama>().ToList(), jsonDiagrames);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Fotografia>().ToList(), jsonFotos);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<ArtDigital>().ToList(), jsonArtDigital);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Documental>().ToList(), jsonDocumental);
            Utilitats.SerialitzaJSON(this.ObtenTotsElsDUnTipus<Serie>().ToList(), jsonSeries);
        }
        public void DeserialitzarJSON()
        {
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Pelicula>(jsonPeli));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Llibre>(jsonLlibres));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Canço>(jsonCansons));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Gravat>(jsonGravats));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<AudioLlibre>(jsonAudioLlibres));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Manuscrit>(jsonManuscrits));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Map>(jsonMapes));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Podcast>(jsonPodcasts));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Revista>(jsonRevistes));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Partitura>(jsonPartitures));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<EfecteSonor>(jsonSons));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Logotip>(jsonLogos));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Diagrama>(jsonDiagrames));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Fotografia>(jsonFotos));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<ArtDigital>(jsonArtDigital));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Documental>(jsonDocumental));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarJSON<Serie>(jsonSeries));
        }
        public void DeserialitzarXML()
        {
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Pelicula>(xmlPeli));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Llibre>(xmlLlibres));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Canço>(xmlCansons));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Gravat>(xmlGravats));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<AudioLlibre>(xmlAudioLlibres));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Manuscrit>(xmlManuscrits));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Map>(xmlMapes));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Podcast>(xmlPodcasts));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Revista>(xmlRevistes));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Partitura>(xmlPartitures));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<EfecteSonor>(xmlSons));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Logotip>(xmlLogos));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Diagrama>(xmlDiagrames));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Fotografia>(xmlFotos));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<ArtDigital>(xmlArtDigital));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Documental>(xmlDocumental));
            this.LlistaMitja.AddRange(Utilitats.DeserialitzarXML<Serie>(xmlSeries));
        }

        public IEnumerable<T> ObtenTotsElsDUnTipus<T>()
        {
            foreach (Mitja element in this)
            {
                if (element is T e_)
                    yield return e_;
            }
        }

        public IEnumerable<Mitja> ObtenElsAnteriorsAUnAny(int anyDeCreacio)
        {
            foreach (Mitja element in this)
            {
                if (element.AnyCreacio < anyDeCreacio)
                {
                    yield return element;
                }
            }
        }

        public void OrdenarPerTitolMitja()
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                for (int j = i + 1; j < this.Count; j++)
                {
                    if (this[i].CompareTo(this[j]) < 0)
                    {
                        Mitja temp = this[j];
                        this[j] = this[i];
                        this[i] = temp;
                    }
                }
            }
        }
        public void OrdenarMitja(IComparer<Mitja> comparador)
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                for (int j = i + 1; j < this.Count; j++)
                {
                    if (comparador.Compare(this[i], this[j]) < 0)
                    {
                        Mitja temp = this[j];
                        this[j] = this[i];
                        this[i] = temp;
                    }
                }
            }
        }

        public void BuidarLlista()
        {
            this.LlistaMitja.Clear();
        }
    }
}
