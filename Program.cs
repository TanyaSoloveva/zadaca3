/// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
/// Найдите разницу между максимальным и минимальным элементов массива
Console.Write("Введите количетво элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
    array[i] = Math.Round(rand.Next(i) + rand.NextDouble(), 2);

for (int i = 0; i < size; i++)
    Console.Write(array[i] + " ");

Console.WriteLine();
double max = array[0];
double min = array[0];
for (int i = 0; i < size; i++)
{
    if    (max < array[i])
{
    max = array[i];
}
   if    (min > array[i])
{
    min = array[i];
}
}
Console.WriteLine($"Массив из {array.Length} чисел. Максимальный элемент массива = {max}, минимальный элемент массива = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {Math.Round((max - min), 2)}");
// 