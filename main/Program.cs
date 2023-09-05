object[] mixedArray = new object[5];

mixedArray[0] = "Hello";
mixedArray[1] = 2;
mixedArray[2] = "world";
mixedArray[3] = ":-)";

int[] arr = {1,2,3};

int[] numbers = { 123, 22, 3222, 411, 51 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == arr.Length)
        System.Console.WriteLine(numbers[i]);
    System.Console.WriteLine();
}
var mix = string.Join(" ", mixedArray);
Console.WriteLine(mix);


// int[] arr = { 1, 2, 4, 6, 7, 8, 8 };

// System.Console.WriteLine(arr);

// int[] array = new int[] { 1, 2, 3 };
// var str = string.Join(" ", array);
// Console.WriteLine(str);

// int[] arr = {123, 22, 3222, 411, 51};
// int ar = arr[0];
// int sd = ar.

// public static int StringLength(string input)
//         {
//             int counter = 0;
//             if (input is null)
//             {
//                 return 0;
//             }
 
//             foreach (var c in input)
//             {
//                 //Console.WriteLine(c);
//                 counter++;
//             }
 
//             //Console.WriteLine($"The following string has {counter} characters in it.");
//             //Console.WriteLine($"{input}");
//             return counter;
//         }