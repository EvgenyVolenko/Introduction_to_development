Console.Clear();

string str = String.Empty;

str = FillString();

string[] array = str.Split(' ');

Console.Write("Задайте длинну строки для поиска в виде числа >= 1: ");
int countSimbols = vvod();

string[] newArray = new string[CountingNumbers(array, countSimbols)];

FillNewArray(newArray, array, countSimbols);

Console.WriteLine($"У нас получился следующий массив [{string.Join(", ", newArray)}]");

string FillString()
{
    Console.WriteLine("Вводите строки. Ввод 'stop' прерывает ввод");
    string entStr = String.Empty;
    string fullStr = String.Empty;
    while (entStr != "stop")
    {
       entStr = Console.ReadLine();
       fullStr = fullStr + entStr + " ";
    }
    fullStr=fullStr.Remove(fullStr.Length-1);
    return fullStr;
}

void FillNewArray(string[] newArr, string[] col, int countS)
{
    int positionNewArr = 0;
    int n = col.Length;
    for (int i = 0; i < n; i++)
    {
        if (col[i].Length <= countS)
        {
            newArr[positionNewArr] = col[i];
            positionNewArr++;
        }
    }
}

int CountingNumbers(string[] arr, int countS)
{
    int countOccur = 0;
    int n = arr.Length;
    for (int i = 0; i < n; i++)
    {
        if (arr[i].Length <= countS)
        {
            countOccur++;
        }
    }
    return countOccur;
}

int vvod()
{
    int digit;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out digit))
        {
            if (digit >= 1) break;
            else Console.Write("Число должно быть >= 1: ");
        }
        else Console.Write("Ну просил же число! ");
    }
    return digit;
}