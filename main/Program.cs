














string[] finalOutputArray = new string[count];

Array.Copy(outputArray, finalOutputArray, count);

Console.WriteLine("Результат:");
foreach (string str in finalOutputArray)
{
    Console.WriteLine(str);
}