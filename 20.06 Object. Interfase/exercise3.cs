using System;
using System.Linq; 

interface ICalc2
{
    int CountDistinct(); 
    int EqualToValue(int valueToCompare); 
}

class MyArray3 : ICalc2
{
    private int[] data;

    public MyArray3(int[] inputData)
    {
        data = inputData;
    }

    public int CountDistinct()
    {
        return data.Distinct().Count();
    }

    public int EqualToValue(int valueToCompare)
    {
        return data.Count(x => x == valueToCompare);
    }

    public void ShowArray()
    {
        Console.WriteLine("Масив: " + string.Join(", ", data));
    }
}

class Program
{
    static void Main()
    {
        MyArray3 arr = new MyArray3(new int[] { 1, 3, 3, 4, 5, 1, 6 });
        arr.ShowArray();

        Console.WriteLine("Кількість унікальних значень: " + arr.CountDistinct());
        Console.WriteLine("Кількість значень, рівних 3: " + arr.EqualToValue(3));
    }
}
