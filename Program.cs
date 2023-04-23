string[] CreateArray(int length)
{
    string[] arr = new string[length];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите слово: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
int CountElements(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3) count++;
    return count;
}



