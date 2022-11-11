// int[] array = {645};

// int n = array.Length;
// int find = 2;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

void PrintArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

string [] array = {"hel3lo wor2ld"};
PrintArray(array);

