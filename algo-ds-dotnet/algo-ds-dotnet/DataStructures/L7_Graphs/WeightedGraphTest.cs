using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.DataStructures.L7_Graphs
{
    public static class WeightedGraphTest
    {
        public static void Run()
        {
            WeightedGraph<string, int> graph = new WeightedGraph<string, int>();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            graph.AddEdge("A", "B", 9);
            graph.AddEdge("A", "C", 5);
            graph.AddEdge("B", "C", 7);

            graph.Print();
        }
    }
}