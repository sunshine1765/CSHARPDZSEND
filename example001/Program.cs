// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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
        arr[i] = rnd.Next(100, 1000 );
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
        if(newArray[i] %2 == 0){
            result += 1;
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



