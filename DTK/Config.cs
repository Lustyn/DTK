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

        public Config()
        {
            PythonPath = "python";
            FunKeyCIAPath = "FunKeyCIA.py";
        }
    }
}
