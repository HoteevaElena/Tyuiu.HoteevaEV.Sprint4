using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.HoteevaEV.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            int c = array.Count(x => x.Length < 7);
            return c;
        }
    }
}
