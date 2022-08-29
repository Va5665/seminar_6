// Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2 -1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы(через запятую и пробел): ");
string input = Console.ReadLine();
string[] numberStrings = input.Split(",");
int[] arr = Array.ConvertAll(numberStrings, int.Parse);

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Кол-во элементов > 0: {count}");
