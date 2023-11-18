using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TypingSpeed
{
    public class Record
    {
        public Record()
        {

        }
        public Record(string name, int minute, float second)
        {
            this.Name = name;
            this.SymbolPerMinute = minute;
            this.SymbolPerSecond = second;
        }
        public string Name { get; set; }
        public int SymbolPerMinute { get; set; }
        public float SymbolPerSecond { get; set; }
    }
}
