Console.WriteLine("Введите строки через ',':");
string[] array = Console.ReadLine().Split(' ',',');
string[] newarray = new string[array.Length];

void FillArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"{array[i]} ");
    }
}

FillArray (array, newarray);
PrintArray(newarray);
