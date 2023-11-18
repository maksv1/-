using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TypingSpeed
{
    public class Table
    {
        static List<Record> records = new List<Record>();

        public void AddItem(Record record)
        {
            records.Add(record);
        }
        static void AddRecords(Record record)
        {
            records.Add(record);
        }

        public void Serialize()
        {
            string json = JsonConvert.SerializeObject(records);
            File.WriteAllText($"{Environment.CurrentDirectory}\\Рекорд.json", json);
        }


        public void WriteReccord()
        {
            foreach (Record record in records)
            {
                Console.WriteLine("имя: " + record.Name, "скорость в минутах: " + record.SymbolPerMinute, "скорость в секундах" + record.SymbolPerSecond);
            }
        }
    }
}
