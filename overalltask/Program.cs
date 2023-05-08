Console.WriteLine("Укажите размер массива");
bool isparse = int.TryParse(Console.ReadLine(), out int size);

if (!isparse)
{
    return;
}

string[] array = GenerateArray(size);
PrintArray(array);
int readkey = FindSizeArray(array);
string[] resultarray = Result(array, readkey);
PrintArray(resultarray);
string[] GenerateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0;i < size; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        array[i] = Console.ReadLine();
    }
    return array;
}
// Метод вывода массива в консоль
void PrintArray(string[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}

int FindSizeArray(string[] array)
{
    int count = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
string[] Result(string[] array, int readkey)
{
    string[] resultarray = new string[readkey];
    for (int i=0; i < readkey; )
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j].Length <=3)
            {
                resultarray[i] = array[j];
                i++;
            }
        }
    }
    
    return resultarray;

    

}
