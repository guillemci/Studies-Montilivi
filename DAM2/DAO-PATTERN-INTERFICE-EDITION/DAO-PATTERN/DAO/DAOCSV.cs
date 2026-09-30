using DAO_PATTERN.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DAO_PATTERN.DAO
{
    public class DAOCSV : IDAO
    {
        private string filename = null;
        private StreamReader sr1 = null;
        private StreamReader sr2 = null;
        private StreamWriter sw = null;
        public string Filename
        {
            set
            {
                if (File.Exists(value))
                    filename = value;
                else
                    throw new Exception("filename inexistent");
            }
        }

        public int SelectByGenre(string genre, string outputFile)
        {
            if (filename == null)
                throw new ArgumentNullException("filename a de fer referencia a un ftxer");

            int contador = 0;

            File.Create(outputFile).Close();

            using (this.sr1 = new StreamReader(filename))
            using (this.sw = new StreamWriter(outputFile))
            {
                sw.WriteLine("index;id;title;genres");
                sr1.ReadLine();
                string? linea = sr1.ReadLine();

                while (linea != null)
                {
                    RawTitle peli = new RawTitle(linea);
                    if (peli._Generes.MeuContains(genre))
                    {
                        sw.WriteLine(
                            $"{peli._Index};{peli._Id};{peli._Title};[{formatArray(peli._Generes)}]"
                        );
                        contador++;
                    }
                    linea = sr1.ReadLine();
                }
            }

            return contador;
        }

        private string formatArray(List<string> array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < array.Count; i++)
            {
                sb.Append($"'{array[i]}'");
                if (i < array.Count - 1)
                    sb.Append(", ");
            }
            sb.Append("]");
            return sb.ToString();
        }

        public RawTitle? SelectByIndex(int index)
        {
            if (filename == null)
                throw new ArgumentNullException("filename a de fer referencia a un ftxer");

            RawTitle? peli = null;
            using (this.sr1 = new StreamReader(filename))
            {
                sr1.ReadLine();
                string? linea = sr1.ReadLine();
                bool trovat = false;
                bool pasatDeRang = false;

                while (!trovat && !pasatDeRang && linea != null)
                {
                    peli = new RawTitle(linea);
                    if (peli._Index == index)
                        trovat = true;
                    else if (peli._Index > index)
                        pasatDeRang = true;
                    else
                        linea = sr1.ReadLine();
                }

                if (linea is null || pasatDeRang)
                    peli = null;
            }

            return peli;
        }

        public RawTitle? SelectById(string id)
        {
            if (filename == null)
                throw new ArgumentNullException("filename a de fer referencia a un ftxer");

            RawTitle? peli = null;
            using (this.sr1 = new StreamReader(filename))
            {
                sr1.ReadLine();
                string? linea = sr1.ReadLine();
                bool trovat = false;

                while (!trovat && linea != null)
                {
                    peli = new RawTitle(linea);
                    if (peli._Id == id)
                        trovat = true;
                    else linea = sr1.ReadLine();
                }

                if (linea is null)
                    peli = null;
            }

            return peli;
        }

        public RawTitle[] ReadTitles(int index, int length)
        {

            if (filename == null)
                throw new ArgumentNullException("filename a de fer referencia a un ftxer");

            if (length < 1)
                throw new ArgumentException("un array necesita tenir un espai de 1 al menys");

            RawTitle[] array = new RawTitle[length];

            RawTitle? peli = null;
            bool finalLength = false;
            int indexArray = 0;

            using (this.sr1 = new StreamReader(filename))
            {
                sr1.ReadLine();
                string? linea = sr1.ReadLine();

                while (!finalLength && linea != null)
                {
                    peli = new RawTitle(linea);
                    if (peli._Index >= index)
                    {
                        if (peli._Index < index + length)
                        {
                            array[indexArray] = peli;
                            indexArray++;
                        }
                        else
                        {
                            finalLength = true;
                        }
                    }
                    linea = sr1.ReadLine();
                }
            }

            if (indexArray < length)
            {
                RawTitle[] arrayBackup = new RawTitle[indexArray];
                for (int i = 0; i < arrayBackup.Length; i++)
                {
                    arrayBackup[i] = array[i];
                }
                array = arrayBackup;
            }

            return array;
        }

        public void PreMerge(RawTitle[] titles, string outputFileName)
        {
            if (!File.Exists($"{outputFileName}.csv"))
                File.Create($"{outputFileName}.csv").Close();

            titles.Sort();

            using (this.sw = new StreamWriter($"{outputFileName}.csv"))
            {
                sw.WriteLine("index,id,title,type,release_year,age_certification,runtime,genres,production_countries,seasons,imdb_id,imdb_score,imdb_votes");
                for (int i = 0; i < titles.Length; i++)
                    sw.WriteLine(titles[i]);
            }
        }

        public int Merge(string inputFileName1, string inputFilename2, string outputFileName)
        {

            if (!File.Exists($"{outputFileName}.csv"))
                File.Create($"{outputFileName}.csv").Close();

            int count = 0;
            using (this.sw = new StreamWriter($"{outputFileName}.csv"))
            {
                using (this.sr1 = new StreamReader(inputFileName1))
                using (this.sr2 = new StreamReader(inputFilename2))
                {
                    sw.WriteLine("index,id,title,type,release_year,age_certification,runtime,genres,production_countries,seasons,imdb_id,imdb_score,imdb_votes");
                    sr1.ReadLine();
                    sr2.ReadLine();
                    string linea1 = sr1.ReadLine();
                    string linea2 = sr2.ReadLine();
                    RawTitle peli1 = null;
                    RawTitle peli2 = null;

                    while (linea1 is not null && linea2 is not null)
                    {
                        peli1 = new RawTitle(linea1);
                        peli2 = new RawTitle(linea2);

                        if (peli1._ImdbScore > peli2._ImdbScore)
                        {
                            sw.WriteLine(linea2);
                            linea2 = sr2.ReadLine();
                        }
                        else if (peli1._ImdbScore < peli2._ImdbScore)
                        {
                            sw.WriteLine(linea1);
                            linea1 = sr1.ReadLine();
                        }
                        else
                        {
                            sw.WriteLine(linea1);
                            sw.WriteLine(linea2);
                            linea1 = sr1.ReadLine();
                            linea2 = sr2.ReadLine();
                            count++;
                        }
                        count++;
                    }

                    while (linea1 is not null)
                    {
                        sw.WriteLine(linea1);
                        linea1 = sr1.ReadLine();
                        count++;
                    }

                    while (linea2 is not null)
                    {
                        sw.WriteLine(linea2);
                        linea2 = sr2.ReadLine();
                        count++;
                    }
                }
                return count;
            }

        }
    }
}
