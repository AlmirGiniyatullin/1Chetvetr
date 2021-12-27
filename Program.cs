// int[] array = { 1, 2, 3, 4 };
// int[] array = { 1, 3, 14, 5, 7, 1, 23};
// int[] array = { 2, -4, 16};
int[] array = { 11, 9, 8, 15};
// [1, 3, 14, 5, 7, 1, 23] -> [14, 23]
// [2, -4, 16] -> [16]
// [11, 9, 8, 15]

void PrintArray(int[] arr)
{
    int count = arr.Length;

    if (count == 0) Console.WriteLine("Пустой массив");
    else
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

}

int[] SelectionArr(int[] arr, int find)
{
    int[] arrayNew = new int[arr.Length]; ;
    int m = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > find)
        {
            arrayNew[i] = arr[i];
            m++;
        }
    }
    return arrayNew;
}


//Array.ForEach(array, Console.WriteLine);
PrintArray(array);

int[] arrayRez = SelectionArr(array, 8);

arrayRez = arrayRez.Where(x => x != 0).ToArray();

Console.WriteLine("Новый массив");

PrintArray(arrayRez);
