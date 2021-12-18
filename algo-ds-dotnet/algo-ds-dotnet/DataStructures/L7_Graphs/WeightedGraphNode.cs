namespace algo_ds_dotnet.DataStructures.L7_Graphs
{
    public class WeightedGraphNode<TVertex, TWeight>
    {
        public WeightedGraphNode(TVertex vertex2, TWeight weight)
        {
            Vertex = vertex2;
            Weight = weight;
        }

        public TVertex Vertex { get; set; }

        public TWeight Weight { get; set; }
    }
}