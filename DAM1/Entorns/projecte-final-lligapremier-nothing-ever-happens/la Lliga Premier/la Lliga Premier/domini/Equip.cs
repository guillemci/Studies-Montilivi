using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_Lliga_Premier.domini
{
    public class Equip
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public List<Partit> Partits { get; set; }

        public Equip(string lineaCsv)
        {
            string[] arrayLinea = lineaCsv.Split(';');
            this.Id = arrayLinea[0];
            this.Nom = arrayLinea[1];
            this.Partits = new List<Partit>();
        }
    }
}
