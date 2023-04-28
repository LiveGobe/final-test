using System;

class Program
{
    static void Main(string[] args)
    {
        // Вводим исходный массив строк
        Console.Write("Введите массив строк через запятую: ");
        string[] arr = Console.ReadLine().Split(',');

        // Создаем пустой массив для хранения результатов
        string[] new_arr = new string[0];

        // Проходим по каждой строке в исходном массиве
        foreach (string s in arr)
        {
            // Если длина строки меньше или равна 3 символам, добавляем ее в новый массив
            if (s.Length <= 3)
            {
                Array.Resize(ref new_arr, new_arr.Length + 1);
                new_arr[new_arr.Length - 1] = s;
            }
        }

        // Выводим новый массив строк
        Console.WriteLine(string.Join(",", new_arr));
    }
}