using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skolniProjektPVA
{
    class User
    {
        internal static int mis;
        internal static int ok;
        internal static int easy;
        internal static int hard;
        internal static List<string> badHira = new List<string>();
        private static string outp;

        internal static string xxxxxx()
        {
            badHira.Sort();
            
            foreach (string ssss in badHira)
            {
                outp += ssss;
            }

            return outp;
        }
    }

    
}
