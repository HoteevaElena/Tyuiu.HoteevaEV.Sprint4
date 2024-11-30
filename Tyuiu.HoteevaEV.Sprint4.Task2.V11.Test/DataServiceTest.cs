using Tyuiu.HoteevaEV.Sprint4.Task2.V11.Lib;
namespace Tyuiu.HoteevaEV.Sprint4.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] nums = { 3, 5, 6, 4, 8, 8 };

            int wait = 26;
            int res = ds.Calculate(nums);

            Assert.AreEqual(wait, res);
        }
    }
}