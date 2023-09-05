Console.WriteLine("Введите строки через пробел:");
string[] inputArray = Console.ReadLine().Split();

string[] outputArray = new string[inputArray.Length];

int count = 0;
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        outputArray[count] = str;
        count++;
    }
}

string[] finalOutputArray = new string[count];

Array.Copy(outputArray, finalOutputArray, count);

Console.WriteLine("Результат:");
foreach (string str in finalOutputArray)
{
    Console.WriteLine(str);
}
