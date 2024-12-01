using Tyuiu.HoteevaEV.Sprint4.Task3.V8.Lib;
namespace Tyuiu.HoteevaEV.Sprint4.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Хотеева Е. В. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Хотеева Елена Вячеславовна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 8. Найдите минимальный      *");
            Console.WriteLine("* элемент в четвертом столбце массива.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mass = { { 4, 8, 3, 4, 8 },
                            { 5, 3, 5, 7, 8 },
                            { 3, 7, 2, 7, 7 },
                            { 5, 2, 4, 6, 4 },
                            { 4, 4, 6, 7, 2 } };
            Console.WriteLine("Массив: ");
            for(int i = 0; i < mass.GetLength(0); i++)
            {
                for(int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + "  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mass);

            Console.WriteLine("Минимальный элемент в четвертом столбце массива: " + res);

            Console.ReadKey();
        }
    }
}
