string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

int countSimbols = 4;
int countOccur = 0;
int n = array.Length;


for (int i = 0; i < n; i++)
{
    if(array[i].Length < countSimbols)
    {
        countOccur++;
    }
}

string[] newArray = new string[countOccur];
int positionNewArray = 0;

for (int i = 0; i < n; i++)
{
    if(array[i].Length < countSimbols)
    {
        newArray[positionNewArray] = array[i];
        positionNewArray++;
    }
}

Console.WriteLine($"У нас получился следующий массив [{string.Join(", ", newArray)}]");