using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.HoteevaEV.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0;
            int[,] matr = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matr[i, j] = int.Parse(value.Substring(i * m + j, 1)); 
                }
            }
            for(int x = 0; x < n; x++)
            {
                for(int y = 0; y < m; y++)
                {
                    if (matr[x, y] % 2 != 0)
                    {
                        sum += matr[x, y];
                    }
                }
            }
            return sum;
        }
    }
}
