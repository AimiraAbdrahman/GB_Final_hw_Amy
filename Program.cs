string[] GetFinalArrayWithSelectedElements(string input)
{
string[] InitialArray = input.Split(" ");
string[] FinalArray = new string[InitialArray.Length];
for (int i = 0; i < InitialArray.Length; i++)
{
if (InitialArray[i].Length <= 3)
{
FinalArray[i] = InitialArray[i];
}
}
return FinalArray;
}
Console.Write("Введите строки через пробел: ");
string inputStr = Console.ReadLine();
string[] result = GetFinalArrayWithSelectedElements(inputStr);
Console.WriteLine($"Массив: [{string.Join("; ", result)}]");


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите элементы массива через запятую:");
//         string input = Console.ReadLine();
//         string[] inputArray = input.Split(',');

//         string[] newArray = inputArray.Where(s => s.Length <= 3).ToArray();

//         Console.WriteLine("Новый массив с элементами длиной не более 3:");
//         foreach (var item in newArray)
//         {
//             Console.WriteLine(item);
//         }
//         Console.WriteLine($"Массив: [{string.Join("; ", newArray)}]");
//     }
// }
