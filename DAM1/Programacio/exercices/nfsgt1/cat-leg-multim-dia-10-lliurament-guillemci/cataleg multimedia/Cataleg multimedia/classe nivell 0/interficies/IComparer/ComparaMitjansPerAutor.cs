using Cataleg_multimedia.superclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia.classe_nivell_0.IComparable
{
    internal class ComparaMitjansPerAutor : IComparer<Cataleg_multimedia.superclasse.Mitja>
    {
        public int Compare(Mitja obj1, Mitja obj2)
        {
            if (obj1 == null && obj2 == null) return 0;
            else if (obj1 == null) return -1;
            else if (obj2 == null) return 1;
            else return obj1.Autor.CompareTo(obj2.Autor);
        }
    }
}
