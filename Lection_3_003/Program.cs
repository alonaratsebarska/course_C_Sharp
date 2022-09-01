int[] arr = { 8, 11, 3, 7, 4, 57, 35, 84445 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");

    }
    Console.WriteLine();
}

void SelectionSort(int[] ar)
{
    for (int i = 0; i < ar.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < ar.Length; j++)
        {
            if (ar[j] < ar[minPosition]) minPosition = j;
            Console.WriteLine(ar[minPosition]);
        }

        int temporary = ar[i];
        ar[i] = ar[minPosition];
        ar[minPosition] = temporary;

    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);
