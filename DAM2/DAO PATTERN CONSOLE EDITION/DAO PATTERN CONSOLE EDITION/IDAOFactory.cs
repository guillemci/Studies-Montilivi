using DAO_PATTERN_CONSOLE_EDITION.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO_PATTERN_CONSOLE_EDITION
{
    public class IDAOFactory
    {
        public static IDAO GetDAOService(EnumDTOImplementacio enumerable, string connexio)
        {
            if (enumerable == EnumDTOImplementacio.CSV)
                return new DAOCSV() { Filename = connexio };
            else
                throw new NotImplementedException();
        }
    }
}
