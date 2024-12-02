using Tyuiu.HoteevaEV.Sprint4.Task7.V12.Lib;
namespace Tyuiu.HoteevaEV.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int raws = 3;
            int col = 4;
            string s = "658932125478";

            int wait = 30;

            int res = ds.Calculate(raws, col, s);

            Assert.AreEqual(wait, res);
        }
    }
}