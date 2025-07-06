//using System;

//interface ICalc
//{
//    int Less(int valueToCompare);
//    int Greater(int valueToCompare);
//}

//class MyArray : ICalc
//{
//    private int[] data;

//    public MyArray(int[] inputData)
//    {
//        data = inputData;
//    }

//    public int Less(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int item in data)
//            if (item < valueToCompare) count++;
//        return count;
//    }

//    public int Greater(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int item in data)
//            if (item > valueToCompare) count++;
//        return count;
//    }

//    public void ShowArray()
//    {
//        Console.WriteLine("Массив: " + string.Join(", ", data));
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MyArray arr = new MyArray(new int[] { 3, 7, 1, 9, 5, 7 });
//        arr.ShowArray();

//        Console.WriteLine(">6: " + arr.Less(6));
//        Console.WriteLine("<6: " + arr.Greater(6));
//    }
//}
