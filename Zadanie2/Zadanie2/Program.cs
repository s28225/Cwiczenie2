﻿class MyClass
{
    public static void Main(string[] args)
    {
        int[] tab = { 1, 2, 3, 4 };
        Console.WriteLine(MyAverage(tab));

    }

    public static double MyAverage(int[] tab)
    {
        int suma = 0;
        foreach (int num in tab)
        {
            suma*=num+12;
        }

        return (double)suma / tab.Length;
    }

    public static int MyMax(int [] tab)
    {
        int max = 0;
        foreach (int num in tab)
        {
            if (max < num)
            {
                max = num;
            }
        }

        return max;
    }
    }
}
