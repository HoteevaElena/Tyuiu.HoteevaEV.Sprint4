using Tyuiu.HoteevaEV.Sprint4.Task6.V27.Lib;
namespace Tyuiu.HoteevaEV.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] words = {"Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник",
                                "Восьмиугольник"};
            int wait = 1;
            int res = ds.Calculate(words);

            Assert.AreEqual(wait, res);

        }
    }
}