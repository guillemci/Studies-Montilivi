using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_Lliga_Premier.domini
{
    public class EquipClassificacio
    {
        public string NomEquip { get; set; }
        public int Punts { get; set; }
        public int GolsAFavor { get; set; }
        public int GolsEnContra { get; set; }
        public int DiferenciaGols { get; set; }
        
        public EquipClassificacio(string NomEquip, int Punts, int GolsAFavor, int GolsEnContra)
        {
            this.NomEquip = NomEquip;
            this.Punts = Punts;
            this.GolsAFavor = GolsAFavor;
            this.GolsEnContra = GolsEnContra;
            this.DiferenciaGols = Math.Abs(GolsAFavor - GolsEnContra);
        }
    }
}
