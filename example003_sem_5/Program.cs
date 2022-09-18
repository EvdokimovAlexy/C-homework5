// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double[5];
FillArray(array); // Вызываем метод создания массива
PrintArray(array); //  Выводим массив
Console.WriteLine(); // новая строка
double max = array[0]; // задаем максимальную переменную для сравнения
double min = array[0]; // задаем минимальную переменную для сравнения.
for (int i = 0; i < array.Length; i++) // задаем цикл 
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
void FillArray(double[] array) // Метод создания массива
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        index++;
    }
}
void PrintArray(double[] array) // Метод вывода массива
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{array[index]}, ");
        index++;
    }
}