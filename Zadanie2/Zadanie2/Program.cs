class MyClass
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
            suma += num;
        }

        return (double)suma / tab.Length;
    }
}
