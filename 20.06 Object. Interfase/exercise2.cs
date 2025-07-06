//using System;

//interface IOutput2
//{
//    void ShowEven(); 
//    void ShowOdd();  
//}

//class MyArray2 : IOutput2
//{
//    private int[] data; 

//    public MyArray2(int[] inputData)
//    {
//        data = inputData;
//    }

//    public void ShowEven()
//    {
//        Console.Write("Парні числа: ");
//        foreach (int item in data)
//        {
//            if (item % 2 == 0)
//                Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }

//    public void ShowOdd()
//    {
//        Console.Write("Непарні числа: ");
//        foreach (int item in data)
//        {
//            if (item % 2 != 0)
//                Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }
//    public void ShowArray()
//    {
//        Console.WriteLine("Масив: " + string.Join(", ", data));
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MyArray2 arr = new MyArray2(new int[] { 2, 5, 8, 9, 3, 4 });
//        arr.ShowArray();     
//        arr.ShowEven();      
//        arr.ShowOdd();       
//    }
//}
