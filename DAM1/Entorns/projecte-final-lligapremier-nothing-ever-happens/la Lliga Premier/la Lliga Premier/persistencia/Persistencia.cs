using la_Lliga_Premier.domini;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_Lliga_Premier.persistencia
{
    public class Persistencia
    {
        public static List<Equip> CarregarEquips(string fitxerEquips)
        {
            List<Equip> llistaEquips = new List<Equip>();
            if (!File.Exists(fitxerEquips)) return llistaEquips;
            StreamReader sr = new StreamReader(fitxerEquips);
            sr.ReadLine();
            string linea;

            while((linea = sr.ReadLine()) != null)
            {
                if(!string.IsNullOrWhiteSpace(linea))
                    llistaEquips.Add(new Equip(linea));
            }
            sr.Close();

            return llistaEquips;
        }

        public static List<Partit> CarregarPartits(string fitxerEquips)
        {
            List<Partit> llistaPartits = new List<Partit>();
            if (!File.Exists(fitxerEquips)) return llistaPartits;
            StreamReader sr = new StreamReader(fitxerEquips);
            sr.ReadLine();
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                    llistaPartits.Add(new Partit(linea));
            }
            sr.Close();

            return llistaPartits;
        }
    }
}
