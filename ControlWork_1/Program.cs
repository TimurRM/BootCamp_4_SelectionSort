//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

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

