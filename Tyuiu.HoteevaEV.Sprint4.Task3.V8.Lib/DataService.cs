using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.HoteevaEV.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int min = 10;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if(j == 3)
                    {
                        if(array[i, j] < min)
                        {
                            min = array[i, j];
                        }
                    }
                }
            }
            return min;
        }
    }
}
