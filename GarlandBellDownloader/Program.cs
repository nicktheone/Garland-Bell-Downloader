using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Extensions;
using Newtonsoft.Json;
using System.IO;

namespace GarlandBellDownloader
{
    class Program
    {
        static void Main(string[] args)
        {

        }

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
