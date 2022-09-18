// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19            [-4, -6, 89, 6] -> 0
int[] array = new int[4];
FillArray(array); // Вызываем метод создания массива
PrintArray(array); //  Выводим массив
Console.WriteLine(); // 
Console.WriteLine(FindSumNumber(array)); // Вывод  решения задачи
int FindSumNumber(int[] array) // Создания метода решения задачи
{
    int result = 0; // Счетчик суммы элементов на нечетных позициях  
    for (int i = 0; i < array.Length; i++) // задаем цикл 
    {
        if (i % 2 == 1) // условие при котором устанавливается четное или нечетная позиция.
        {
            result = array[i] + result;
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
        array[index] = new Random().Next(-10, 10);
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