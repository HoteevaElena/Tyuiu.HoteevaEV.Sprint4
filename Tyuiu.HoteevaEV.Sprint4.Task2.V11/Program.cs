using Tyuiu.HoteevaEV.Sprint4.Task2.V11.Lib;
namespace Tyuiu.HoteevaEV.Sprint4.Task2.V11
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
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Хотеева Елена Вячеславовна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от 3 до 8. Подсчитать сумму четных    *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество элементов массивa: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] mass = new int[len];

            for (int i = 0; i < len; i++)
            {
                mass[i] = rnd.Next(3, 8);
            }

            Console.WriteLine();

            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(mass[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mass);

            Console.WriteLine("Сумма четных элементов в массиве: " + res);

            Console.ReadKey();
        }
    }
}
