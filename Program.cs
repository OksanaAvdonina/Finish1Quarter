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
void PrintNewArr(string[] arr, int count)
{
    string[] newArr = new string[count];
    for (int i = 0, j = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            Console.Write($"|{newArr[j]}| ");
            j++;
        }
}
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] arr = CreateArray(length);
PrintNewArr(arr, CountElements(arr));



