using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dispatch_System
{
    public class Configure_Item
    {
        public string Data_Source { get; set; }
        public string Initial_Catalog { get; set; }
        public string User_ID { get; set; }
        public string Password { get; set; }
    }
    public class Dispatch_System_Configure
    {
        private Configure_Item Cit;
        public string Configure_filePath = @"Dispatch_System_Configure";
        public Dispatch_System_Configure()
        {
            try
            {
                Read();
            }
            catch
            {
                Cit = new Configure_Item() { Data_Source =}
            }
        }
        public void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(Cit, options);
            File.WriteAllText(Configure_filePath, jsonString);
        }

        public void Read()
        {
            using FileStream createStream = File.Create(Configure_filePath);
            JsonSerializer.SerializeAsync(createStream, Cit);
            createStream.DisposeAsync();
        }

    }
}
