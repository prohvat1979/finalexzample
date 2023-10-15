﻿string[] FillArray(int sizeArray)
{
    string[] array = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        System.Console.Write("введите значения массива: ");
        array[i] = Convert.ToString(Console.ReadLine()!);
        if (array[i].Trim() == string.Empty)
        {
            System.Console.WriteLine("введено пустое значение");
            break;
        }
    }
    return array;
}

int CountValueLessThreeChar(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillNewArray(string[] array, int count)
{
    string[] newArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newArray.Length - count] = array[i];
            count--;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    System.Console.Write("]");
}

Console.Write("введите количество значений и массиве:  ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = FillArray(sizeArray);
PrintArray(array);
System.Console.Write(" -> ");
string[] newArray = FillNewArray(array, CountValueLessThreeChar(array));
PrintArray(newArray);
