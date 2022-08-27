// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] col)
{
    for (int count = 0; count < col.Length; count++)
    {
        Console.Write($"{col[count]}\t");
    }
}

int count=0;
Console.WriteLine("Ведите числа: ");
int[] array = new int[new Random().Next(1, 10)];
FillArray(array);
PrintArray(array);
for (int i = 0, size = array.Length; i < size; i++)
{
    if (array[i]>0) count ++;
}

Console.WriteLine($"\nКоличество чисел > 0 = {count}");
