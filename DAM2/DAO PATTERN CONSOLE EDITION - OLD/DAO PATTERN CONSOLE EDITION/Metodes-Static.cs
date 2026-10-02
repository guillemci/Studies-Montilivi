using System;
using System.Collections.Generic;
using System.Text;

namespace DAO_PATTERN_CONSOLE_EDITION
{
    public static class Metodes_Static
    {
        public static bool MeuContains<TSource>(this IEnumerable<TSource> enumer, TSource tractar)
        {
            bool trovat = false;
            IEnumerator<TSource> rator = enumer.GetEnumerator();
            while (rator.MoveNext() && !trovat)
            {
                if(rator.Current.Equals(tractar))
                {
                    trovat = true;
                } 
            }

            return trovat;
        }
    }
}
