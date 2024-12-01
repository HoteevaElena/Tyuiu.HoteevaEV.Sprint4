using Tyuiu.HoteevaEV.Sprint4.Task6.V27.Lib;
namespace Tyuiu.HoteevaEV.Sprint4.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Хотеева Е. В. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Хотеева Елена Вячеславовна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array, подсчитайте         *");
            Console.WriteLine("* количество элементов, длина которых меньше 7.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] words = {"Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник",
                                "Восьмиугольник"};

            Console.WriteLine("Массив: \n");
            foreach(string i in words)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(words);

            Console.WriteLine("Количество элементов массива, длина которых меньше 7: " + res);

            Console.ReadKey();
        }
    }
}
