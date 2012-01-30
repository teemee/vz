using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //Definition Globaler Variablen, die Programmübergreifend nutzbar sind
    //Muss wohl so kompliziert sein, der Sicherheit wegen. Am Arsch Harald...
    public static class vars
    {
        private static string p_crawlerPath = "";

        public static String crawlerPath
        {
            get { return p_crawlerPath; }
            set { p_crawlerPath = value; }
        }

        private static string p_crawlerFile = "";

        public static String crawlerFile
        {
            get { return p_crawlerFile; }
            set { p_crawlerFile = value; }

        }
    }

}
