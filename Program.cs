string[] Main()
{
  int count = 0; // текущее количество строк в массиве
  string[] AS = new string[count]; // выделить память для 0 строк
  string s;
  string[] AS2; // дополнительная переменная-ссылка - сохраняет старый массив строк

  Console.WriteLine("Enter strings:");

  do
  {
    s = Console.ReadLine();
    if (s!="")
    {
      count++;
      AS2 = new string[count];
      for (int i = 0; i < AS.Length; i++) // Если использовать AS.Length не работает
        {
          AS2[i] = AS[i];
        }
        
        // добавить последнюю введенную строку в массив AS2
        AS2[count - 1] = s;
        
        // перенаправить ссылку AS на AS2
        AS = AS2;
    }
  }while (s != "");
return AS;
} 


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
// для тестирования
// string[] a1 = {"hello", "2", "world", ":-)"};
// string[] a2 = {"1234", "1567", "-2", "computer science"};
// string[] a3 = {"Russia", "Denmark", "Kazan"};
//string[] arrayStr = a3;

string[] arrayStr = Main();

PrintArray(arrayStr);

Console.Write("Введите максимальную длину строк в массиве: ");

int stringLeng = int.Parse(Console.ReadLine());

string[] arrayRez = Selection(arrayStr, stringLeng);

Console.WriteLine("Новый массив с предварительным подсчетом элементов результирующего массива");

PrintArray(arrayRez);


