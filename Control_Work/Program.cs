string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

int countSimbols = 3;

string[] newArray = new string[CountingNumbers(array, countSimbols)];
FillNewArray(newArray, array, countSimbols);

Console.WriteLine($"У нас получился следующий массив [{string.Join(", ", newArray)}]");

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