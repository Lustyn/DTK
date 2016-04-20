using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTK
{
    public class Config
    {
        public string PythonPath { get; set; }
        public string FunKeyCIAPath { get; set; }
        public string keyDBPath { get; set; }
        public bool autoLoad { get; set; }
        public string autoLoadPath { get; set; }

        public Config()
        {
            PythonPath = "python";
            FunKeyCIAPath = "FunKeyCIA.py";
            keyDBPath = "db.ebin";
            autoLoad = true;
            autoLoadPath = "db.ebin";
        }
    }
}
