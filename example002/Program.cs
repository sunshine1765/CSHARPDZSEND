// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputNum(string message)
{
   Console.WriteLine(message);
   return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray (int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(1, 100);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

int Checker(int[] newArray){
    int result = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if(i %2 == 1){
            result += newArray[i];
         }

    }
    return result;
}

int size = InputNum("Введите длину массива: ");

int[] array = CreateArray(size);

FillArray(array);

PrintArray(array);

int res = Checker(array);

System.Console.WriteLine(res);



