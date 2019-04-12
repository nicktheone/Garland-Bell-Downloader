using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarlandBellDownloader
{
    class Nodes
    {
        #region JSON
        public class Reduce
        {
            public string item { get; set; }
            public int icon { get; set; }
        }

        public class Item
        {
            public string item { get; set; }
            public int icon { get; set; }
            public int id { get; set; }
            public string slot { get; set; }
            public string scrip { get; set; }
            public Reduce reduce { get; set; }
        }

        public class Node
        {
            public string type { get; set; }
            public string func { get; set; }
            public List<Item> items { get; set; }
            public int stars { get; set; }
            public List<int> time { get; set; }
            public string title { get; set; }
            public string zone { get; set; }
            public List<int> coords { get; set; }
            public string name { get; set; }
            public int uptime { get; set; }
            public int lvl { get; set; }
            public int id { get; set; }
            public double patch { get; set; }
            public string condition { get; set; }
            public string bonus { get; set; }
        }
        #endregion

        #region Methods
        //Get the nodes from the JSON file and return a list of nodes
        public static List<Node> GetNodes()
        {
            using (StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Nodes.json"))
            {
                string s = streamReader.ReadToEnd();
                List<Node> nodes = JsonConvert.DeserializeObject<List<Node>>(s);

                return nodes;
            }
        }
        #endregion
    }
}
