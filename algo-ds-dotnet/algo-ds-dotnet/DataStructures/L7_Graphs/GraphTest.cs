using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.DataStructures.L7_Graphs
{
    public static class GraphTest
    {
        public static void Run()
        {
            CustomGraph<string> graph = new CustomGraph<string>();
            graph.AddVertex("cairo");
            graph.AddVertex("alex");
            graph.AddVertex("tanta");
            graph.AddVertex("benha");
            graph.Traverse();
            Console.WriteLine("********* add edges ********");
            graph.AddEdge("cairo", "tanta");
            graph.AddEdge("cairo", "benha");
            graph.AddEdge("cairo", "alex");
            graph.AddEdge("tanta", "alex");
            graph.AddEdge("benha", "tanta");
            graph.AddEdge("benha", "alex");
            graph.Traverse();
            Console.WriteLine("********* remove edges ********");
            graph.RemoveEdge("benha", "alex");
            graph.Traverse();
            Console.WriteLine("********* remove vertex ********");
            graph.RemoveVertext("cairo");
            graph.Traverse();

        }
    }
}