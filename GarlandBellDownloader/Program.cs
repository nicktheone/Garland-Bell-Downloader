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
            //Gets a list of nodes from the local json database
            List<Nodes.Node> nodes = new List<Nodes.Node>();
            nodes = Nodes.GetNodes();

            //Creates a list for storing icon IDs
            List<int> icons = new List<int>();
            
            //Add to the list each unique icon ID
            foreach (var node in nodes)
            {
                foreach (var item in node.items)
                {
                    if (!icons.Contains(item.icon))
                    {
                        icons.Add(item.icon);
                        Console.WriteLine("Added {0} to the list", item.icon);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
