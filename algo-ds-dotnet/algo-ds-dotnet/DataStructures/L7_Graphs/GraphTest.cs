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
            graph.Print();
            Console.WriteLine("********* add edges ********");
            graph.AddEdge("cairo", "tanta");
            graph.AddEdge("cairo", "benha");
            graph.AddEdge("cairo", "alex");
            graph.AddEdge("tanta", "alex");
            graph.AddEdge("benha", "tanta");
            graph.AddEdge("benha", "alex");
            graph.Print();
            Console.WriteLine("********* remove edges ********");
            graph.RemoveEdge("benha", "alex");
            graph.Print();
            Console.WriteLine("********* remove vertex ********");
            graph.RemoveVertext("cairo");
            graph.Print();



            Console.WriteLine("********* Traversal ********");
            CustomGraph<string> graph2 = new CustomGraph<string>();
            graph2.AddVertex("A");
            graph2.AddVertex("B");
            graph2.AddVertex("C");
            graph2.AddVertex("D");
            graph2.AddVertex("E");
            graph2.AddVertex("F");
            graph2.AddEdge("A", "B");
            graph2.AddEdge("A", "C");
            graph2.AddEdge("B", "D");
            graph2.AddEdge("C", "E");
            graph2.AddEdge("D", "E");
            graph2.AddEdge("D", "F");
            graph2.AddEdge("E", "F");
            graph2.Print();
            graph2.DFS_Recursive("A");
            graph2.DFS_Iterative_Stack("A");
        }
    }
}