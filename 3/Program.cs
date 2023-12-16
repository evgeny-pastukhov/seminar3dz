int[] array = new int[10];


void CreateArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");

    }
    System.Console.WriteLine();
}

void FindElementArray()
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[(array.Length - i - 1)];
        array[(array.Length - i - 1)] = temp;

    }
}


CreateArray();
PrintArray();
FindElementArray();
PrintArray();