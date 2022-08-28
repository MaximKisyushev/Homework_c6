// ДОП.ЗАДАЧА:
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int arraySize = 0;
if (number == 0) Console.WriteLine($"Число {number} в двоичной системе -> {number} ");
else 
{
    for (int i = 0; Math.Pow(2, i) <= number; i++) arraySize = i + 1;
    int[] array = new int[arraySize];
    int size = arraySize - 1;
    double temp = number;
    for (int k = 0; k < arraySize; k++)
    {
        if (temp - Math.Pow(2, size) >= 0)
        {
            array[k] = 1;
            temp = temp - Math.Pow(2, size);
            size--;
        }
        else
        {
            array[k] = 0;
            size--;
        }
    }
Console.WriteLine($"Число {number} в двоичной системе -> {String.Join(" ", array)} ");
}
