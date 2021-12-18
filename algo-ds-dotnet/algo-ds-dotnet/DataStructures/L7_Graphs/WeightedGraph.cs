using System;
using System.Collections.Generic;
using System.Linq;

namespace algo_ds_dotnet.DataStructures.L7_Graphs
{
    public class WeightedGraph<TVertex, TWeight>
    {
        public Dictionary<TVertex, List<WeightedGraphNode<TVertex, TWeight>>> AdjacentList { get; }

        public WeightedGraph()
        {
            AdjacentList = new Dictionary<TVertex, List<WeightedGraphNode<TVertex, TWeight>>>();
        }


        public void Print()
        {
            foreach (var item in AdjacentList)
                Console.WriteLine($"{item.Key} => {string.Join(", ", item.Value.Select(c => $"[{c.Vertex}:{c.Weight}]"))}");
        }


        public void AddVertex(TVertex vertex)
        {
            if (AdjacentList.ContainsKey(vertex) == false)
                AdjacentList[vertex] = new List<WeightedGraphNode<TVertex, TWeight>>();
        }

        public void AddEdge(TVertex vertex1, TVertex vertex2, TWeight weight)
        {
            AdjacentList[vertex1].Add(new WeightedGraphNode<TVertex, TWeight>(vertex2, weight));
            AdjacentList[vertex2].Add(new WeightedGraphNode<TVertex, TWeight>(vertex1, weight));
        }

    }
}