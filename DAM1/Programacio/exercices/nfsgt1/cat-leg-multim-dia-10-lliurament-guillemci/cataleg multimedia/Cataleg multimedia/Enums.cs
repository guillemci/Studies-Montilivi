using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataleg_multimedia
{
    public enum BitRate //valors
    {
        Res = 0,
        Kbps64 = 64,
        Kbps96 = 96,
        Kbps128 = 128,
        Kbps192 = 192,
        Kbps360 = 360
    }
    
    [Flags]
    public enum Tema //flags
    {
        Res = 0,
        Hàbits = 1,
        Tecnologia = 2,
        Benestar = 4,
        Creativitat = 8,
        Futur = 16,
        Negocis = 32,
        Cultura = 64,
        Psicologia = 128,
        Productivitat = 256,
        Societat = 512
    }
}
