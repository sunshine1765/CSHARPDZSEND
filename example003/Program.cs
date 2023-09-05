
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNum(string message)
{
   Console.WriteLine(message);
   return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray (double[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Math.Round(1+ rnd.NextDouble() * 100, 2);

}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

double MaxMin(double[] arr){
    double maxNum = double.NegativeInfinity;
    double minNum = double.PositiveInfinity;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > maxNum){
            maxNum = arr[i];
        }
        if(arr[i] < minNum){
            minNum = arr[i];
        }
    }
    return Math.Round(maxNum - minNum, 2);
}

int size = InputNum("Введите длину массива: ");

double[] array = CreateArray(size);

FillArray(array);

PrintArray(array);

System.Console.WriteLine(MaxMin(array));


