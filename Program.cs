void Task1()
/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
{
    Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь \n");
    Console.Write($"Введи число М(количество чисел): ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] massiveNumbers = new int[m];

    void InputNumbers(int m)
    {
        for (int i = 0; i < m; i++)
        {
            Console.Write($"Введи {i + 1} число: ");
            massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }
    }


    int Comparison(int[] massiveNumbers)
    {
        int count = 0;
        for (int i = 0; i < massiveNumbers.Length; i++)
        {
            if (massiveNumbers[i] > 0) count += 1;
        }
        return count;
    }

    InputNumbers(m);

    Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");
}

void Task2()
/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
{
    Console.Write("Введите b1: ");
    var b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    var k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    var b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    var k2 = Convert.ToDouble(Console.ReadLine());


    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}
Task2();