
Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
for (int i = 0; i < n; i++)


{
    Console.Write($"Введите {i+1}-e слово: ");
    array[i] = Console.ReadLine();
}

Console.Write("[" + string.Join(", ", array) + "] -> ");


for (int i = 0; i < n; i++)
{
    int MinIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[j].Length < array[MinIndex].Length)
            MinIndex = j; 
    }
    string temp;
    temp = array[MinIndex];
    array[MinIndex] = array[i]; 
    array[i] = temp;
}
Console.WriteLine(" [" + string.Join(", ", array) + "]");