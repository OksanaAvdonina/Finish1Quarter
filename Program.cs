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


