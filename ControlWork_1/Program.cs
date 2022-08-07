
Console.WriteLine("Введите кол-во элементов (строк) массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] inputArray = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i + 1}-ю строку: ");
    inputArray[i] = Console.ReadLine();
}


string myArray(string[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            {
            result += array[i]+ " ";
            }
    }
    return result;
}

string[] outputArray = myArray(inputArray).Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine();
Console.WriteLine("[" + string.Join(", ", inputArray) + "]" + " ==> " + "[" + string.Join(", ", outputArray) + "]");
Console.WriteLine();
Console.ReadKey();

