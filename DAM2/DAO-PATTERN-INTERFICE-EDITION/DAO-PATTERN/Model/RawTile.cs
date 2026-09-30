using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace DAO_PATTERN.Model
{
    public class RawTitle : IComparable<RawTitle>
    {
        public int _Index { get; set; }
        public string? _Id { get; set; }
        public string? _Title { get; set; }
        public string _Type { get; set; }
        //public DateTime _Release_year { get; set; }
        public int _Release_year { get; set; }
        public List<string> _Generes { get; set; }
        public double _Seasons { get; set; }
        public double _ImdbScore { get; set; }
        public double _Imdb_Votes { get; set; }

        public RawTitle(string registre)
        {
            string[] camps = Regex.Split(registre, @",(?=(?:[^""]*""[^""]*"")*[^""]*$)");
            this._Index = Convert.ToInt32(camps[0]);
            this._Id = camps[1];
            this._Title = camps[2];
            this._Type = camps[3];
            this._Release_year = Convert.ToInt32(camps[4]);
            //this._Release_year = new DateTime(Convert.ToInt32(camps[4]));
            this._Generes = camps[7]
                .Replace("\'", "")
                .Replace("\"", "")
                .Replace("]", "")
                .Replace("[", "")
                .Replace(" ", "")
                .Split(',')
                .ToList();
            string seasons = camps[9];
            if (seasons == "") seasons = null;
            this._Seasons = Convert.ToDouble(seasons, CultureInfo.InvariantCulture);
            string score = camps[11];
            if (score == "") score = null;
            this._ImdbScore = Convert.ToDouble(score, CultureInfo.InvariantCulture);
            string votes = camps[12];
            if (votes == "") votes = null;
            this._Imdb_Votes = Convert.ToDouble(votes, CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            StringBuilder sbGeneres = new StringBuilder();

            sbGeneres.Append("\"[");
            for (int i = 0; i < this._Generes.Count; i++)
            {
                sbGeneres.Append($"'{this._Generes[i]}'");
                if (i < this._Generes.Count - 1)
                    sbGeneres.Append(", ");
            }
            sbGeneres.Append("]\"");


            return $"{this._Index},{this._Id},{this._Title},{this._Type},{_Release_year}, , ,{sbGeneres}, ,{this._Seasons.ToString("0.0", CultureInfo.InvariantCulture)}, ,{this._ImdbScore.ToString("0.0", CultureInfo.InvariantCulture)},{this._Imdb_Votes.ToString("0.0", CultureInfo.InvariantCulture)}";
        }


        public int CompareTo(RawTitle other)
        {
            int numero;

            if (other is null)
                numero = 1;
            else
                numero = this._ImdbScore.CompareTo(other._ImdbScore);

            return numero;
        }
    }
}
