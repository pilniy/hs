using System;
using System.IO;


namespace hs
{
    [Serializable]
    public class appConfig
    {
        public string dbHost { get; set; }
        public string dbDB { get; set; }
        public string dbUser { get; set; }
        public string dbPasswd { get; set; }
        public string dbPort { get; set; }
        public string dbSchema { get; set; }
        [NonSerialized]
        static public string cfgFileName;


    } // class appConfig
}
