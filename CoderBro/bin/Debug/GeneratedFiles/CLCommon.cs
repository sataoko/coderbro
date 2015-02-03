using System;
using System.Collections.Generic;
using System.Text;

namespace TeklifTakip
{
    class CLCommon
    {
        public static string RemoveNonSQLChars(string input)
        {
            char[] trim = { '=', ';', ':', ',', (char)39 };  
            int pos;
            string v = input;
            while ((pos = v.IndexOfAny(trim)) >= 0)
            {
                v = v.Remove(pos, 1);
            }
            return v;
        }

    }
}
