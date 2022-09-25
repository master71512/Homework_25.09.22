// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
int[] arr = new int[8];
for (int i=0; i < 8; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[");
for (int i=0; i < 8; i++)
{
    Console.Write(arr[i]);
    if (i < 7) Console.Write(", ");
}
Console.WriteLine("]");