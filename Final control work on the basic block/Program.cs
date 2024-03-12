using System;

class Program
{
    static void Main()
    {
        string[] initialArray = { "Jaw", "444", "2222", "888" };

        string[] newArray = FilterArray(initialArray);

        Console.WriteLine("Новый массив:");
        foreach (string item in newArray)
        {
            Console.WriteLine(item);
        }
    }

    static string[] FilterArray(string[] initialArray)
    {
        int count = 0;
        foreach (string item in initialArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        foreach (string item in initialArray)
        {
            if (item.Length <= 3)
            {
                newArray[index] = item;
                index++;
            }
        }

        return newArray;
    }
}