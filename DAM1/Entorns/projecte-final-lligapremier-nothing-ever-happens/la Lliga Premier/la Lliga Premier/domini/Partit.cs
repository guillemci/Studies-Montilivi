using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_Lliga_Premier.domini
{
    public class Partit
    {
        public string Data { get; set; }
        public string LocalId { get; set; }
        public int GolsLocal { get; set; }
        public string VisitantId { get; set; }
        public int GolsVisitant { get; set; }
        public Partit(string lineaCsv)
        {
            string[] arrayLinea = lineaCsv.Split(';');
            this.Data = arrayLinea[0];
            this.LocalId = arrayLinea[1];
            this.GolsLocal = Convert.ToInt32(arrayLinea[2]);
            this.VisitantId = arrayLinea[3];
            this.GolsVisitant = Convert.ToInt32(arrayLinea[4]);
        }
    }
}
