// Задание 2. Работа в сессионных залах
// Задайте массив из 10 элементов, заполненный числами из 
// промежутка [-10, 10]. Замените отрицательные элементы на 
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int[] array = new int[10] { -10, -7 - 5, -4, -1, 0, 1, 4, 5, 7, 10 };
// int length = array.Length;
// int index = 0;

// while (index < length)
// {
//     // array[index] = array[index] * -1; // возможное написание
//     array[index] *= -1;
//     Console.Write(array[index] + " ");
//     index++;
// }
//-------усовершенственное решение-------//
int[] array = new int[10] { -10, -7, -5, -4, -1, 0, 4, 5, 7, 10 };
int index = 0;
int length = array.Length;

for (int i = 0; i < array.Length; i++) // Печатаем массив с ',' и последний элемент без ','
{
    if (i < length - 1)
        Console.Write($"{array[i]}, ");
    else
        Console.Write(array[i]);
}
Console.WriteLine();

while (index < length)
{
    // array[index] = array[index] * -1;
    array[index] *= -1;
    Console.Write(array[index] + " ");
    index++;
}