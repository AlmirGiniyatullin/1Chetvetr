void PrintArray(string[] arrString)
{
    int count = arrString.Length;

    if (count == 0) Console.WriteLine("Пустой массив");
    else
    {
        for (int i = 0; i < arrString.Length; i++)
        {
        Console.WriteLine("array[{0}] = {1}", i, arrString[i]);
        }   
    }

}


string[] Selection (string[] arr, int strLength)  //предварительный подсчет элементов результирующего массива
{
    int m = 0; //длина результирующего массива
    string text = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        text = arr[i];
        if (text.Length <= strLength) m++;
    }
    
    string[] arrayNew = new string[m];
    
    m = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        text = arr[i];
        if (text.Length <= strLength)
        {
            arrayNew[m] = arr[i];
            m++;
        }
    }
    return arrayNew;
}

//["hello", "2", "world", ":-)"] -> ["2", ":-)"]

//["1234", "1567", "-2", "computer science"] -> ["-2"]

//["Russia", "Denmark", "Kazan"] -> []

string[] a1 = {"hello", "2", "world", ":-)"};
string[] a2 = {"1234", "1567", "-2", "computer science"};
string[] a3 = {"Russia", "Denmark", "Kazan"};

string[] arrayStr = a3;

PrintArray(arrayStr);

string[] arrayRez = Selection(arrayStr, 3);

Console.WriteLine("Новый массив с предварительным подсчетом элементов результирующего массива");

PrintArray(arrayRez);


