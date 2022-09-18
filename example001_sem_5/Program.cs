// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[6];
FillArray(array); // Вызываем метод создания массива
PrintArray(array); // Выводим массив
Console.WriteLine(); // вывод счетчика на отделой строке
Console.WriteLine(FindNumber(array)); // Вывод  решения задачи
int FindNumber(int[] array) // Создания метода решения задачи
{
    int result = 0; // Счетчик четных чисел 
    for (int i = 0; i < array.Length; i++) // задаем цикл 
    {
        if (array[i] % 2 == 0) // условие при котором устанавливается четное или нечетное число.
        {
            result++;
        }
    }
    return result; // возвращает и записывает счетчик
}
void FillArray(int[] array) // Метод создания массива
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
}
void PrintArray(int[] array) // Метод вывода массива
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{array[index]}, ");
        index++;
    }
}