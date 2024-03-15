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


