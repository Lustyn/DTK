using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTK
{
    public class Config
    {
        public string PythonPath { get; set; }
        public string MakeCDNCIAPath { get; set; }
        public string FunKeyCIAPath { get; set; }
        public string CIAsFolder { get; set; }
        public string DSDBPath { get; set; }
        public string GroovyCIAPath { get; set; }
        public string KeyDBPath { get; set; }
        public bool AutoLoad { get; set; }
        public string AutoLoadPath { get; set; }
        public string KeyDBUrl { get; set; }

        public Config()
        {
            PythonPath = "python";
            MakeCDNCIAPath = "make_cdn_cia.exe";
            FunKeyCIAPath = "FunKeyCIA.py";
            DSDBPath = "3dsreleases.xml";
            GroovyCIAPath = "groovyreleases.xml";
            KeyDBPath = "db.ebin";
            AutoLoad = false;
            AutoLoadPath = "db.ebin";
            KeyDBUrl = "undefined";
        }

        public string GetCIAFolder()
        {
            return Path.Combine(Path.GetDirectoryName(FunKeyCIAPath), "cia");
        }
    }
}
