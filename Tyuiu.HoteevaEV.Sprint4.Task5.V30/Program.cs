using Tyuiu.HoteevaEV.Sprint4.Task5.V30.Lib;
namespace Tyuiu.HoteevaEV.Sprint4.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Хотеева Е. В. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Хотеева Елена Вячеславовна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -2 до 4. Найти сумму положительных *");
            Console.WriteLine("* элементов.                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matr = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matr[i, j] = rnd.Next(-2, 4);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Массив: \n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0, 3:d}", matr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(matr);

            Console.WriteLine("Сумма положительных элементов массива: " + res);

            Console.ReadKey();
        }
    }
}
