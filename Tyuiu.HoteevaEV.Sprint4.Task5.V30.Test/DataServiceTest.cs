using Tyuiu.HoteevaEV.Sprint4.Task5.V30.Lib;
namespace Tyuiu.HoteevaEV.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] nums = { { 2, -5, -3 },
                            {1, 6, 2 },
                            {0, 4, -7 } };
            int wait = 15;
            int res = ds.Calculate(nums);

            Assert.AreEqual(wait, res);
        }
    }
}