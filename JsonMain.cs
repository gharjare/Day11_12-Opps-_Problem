using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProblem
{
    public class JsonMain
    {
        Model Inventory = new Model();
        List<Model> InventoryList = new List<Model>();

        public void convert(string jFilePath)
        {
            using(StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Model>>(json);
                Console.WriteLine("Name weight price Total value");
                foreach(var item in items)
                {
                    double value = item.price * item.weight;
                    Console.WriteLine(item.name + " " + item.weight + " " + item.price + " " + value);
                }
            }
        }
    }
}
