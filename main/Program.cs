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
