namespace SE1202223ProfileTDD
{
    public class EdgeSet
    {
        public static double ComputeNormalizedAverage(List<double> distances)
        {
            return distances.Average(d => d / distances.Max());
        }
    }
}