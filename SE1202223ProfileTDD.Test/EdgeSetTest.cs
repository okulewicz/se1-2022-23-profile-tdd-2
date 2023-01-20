namespace SE1202223ProfileTDD.Test
{
    [TestClass]
    public class EdgeSetTest
    {
        private const double AcceptablePrecision = 1e-8;

        [TestMethod]
        public void TestNormalizedAverageComputations()
        {
            List<double> distances = new List<double>();
            distances.Add(1.0);
            distances.Add(1.0);
            distances.Add(2.0);
            double expectedAverage = 2.0 / 3;
            double realAverage = EdgeSet.ComputeNormalizedAverage(distances);
            Assert.AreEqual(expectedAverage, realAverage, AcceptablePrecision);
        }
    }
}