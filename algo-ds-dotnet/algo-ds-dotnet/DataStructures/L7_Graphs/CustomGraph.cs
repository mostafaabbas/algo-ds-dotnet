using System;
using System.Collections.Generic;
using System.Linq;

namespace algo_ds_dotnet.DataStructures.L7_Graphs
{
    public class CustomGraph<T>
    {
        public Dictionary<T, List<T>> AdjacentList { get; }

        public CustomGraph()
        {
            AdjacentList = new Dictionary<T, List<T>>();
        }


        public void Print()
        {
            foreach (var item in AdjacentList)
                Console.WriteLine($"{item.Key} => {string.Join(", ", item.Value)}");
        }


        public void AddVertex(T vertex)
        {
            if (AdjacentList.ContainsKey(vertex) == false)
                AdjacentList[vertex] = new List<T>();
        }

        public void AddEdge(T vertex1, T vertex2)
        {
            AdjacentList[vertex1].Add(vertex2);
            AdjacentList[vertex2].Add(vertex1);
        }

        public void RemoveEdge(T vertex1, T vertex2)
        {
            AdjacentList[vertex1].Remove(vertex2);
            AdjacentList[vertex2].Remove(vertex1);
        }

        public void RemoveVertext(T vertex)
        {
            foreach (var item in AdjacentList)
                RemoveEdge(item.Key, vertex);

            AdjacentList.Remove(vertex);
        }


        public void DFS_Recursive(T vertex)
        {
            List<T> result = new List<T>();
            VisitVertex(vertex);

            void VisitVertex(T vertex)
            {
                if (result.Contains(vertex) == false)
                    result.Add(vertex);

                var neighbors = AdjacentList[vertex].Where(c => result.Contains(c) == false).ToList();
                if (neighbors == null || neighbors.Count == 0)
                    return;

                neighbors.ForEach(VisitVertex);
            }

            Console.WriteLine($"DFS_Recursive: {string.Join(" -> ", result)}");
        }

        public void DFS_Iterative(T vertex)
        {
            List<T> result = new List<T>();
            Stack<T> stack = new Stack<T>();

            stack.Push(vertex);

            while (stack.Count > 0)
            {
                var v = stack.Pop();
                if (result.Contains(v))
                    continue;
                result.Add(v);

                AdjacentList[v].Where(c => result.Contains(c) == false).ToList().ForEach(stack.Push);
            }

            Console.WriteLine($"DFS_Iterative: {string.Join(" -> ", result)}");
        }


        public void BFS_Iterative(T vertex)
        {
            List<T> result = new List<T>();
            Queue<T> queue = new Queue<T>();

            queue.Enqueue(vertex);

            while (queue.Count > 0)
            {
                var v = queue.Dequeue();
                if (result.Contains(v))
                    continue;
                result.Add(v);

                AdjacentList[v].Where(c => result.Contains(c) == false).ToList().ForEach(queue.Enqueue);
            }

            Console.WriteLine($"BFS_Iterative: {string.Join(" -> ", result)}");
        }

    }
}