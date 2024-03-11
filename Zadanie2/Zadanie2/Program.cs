class MyClass
{
    public static void Main(string[] args)
    {
        int[] tab = { 1, 2, 3, 4 };
        Console.WriteLine(tab.Average());

        foreach (int num in tab)
        {
            Console.WriteLine(num);
        }
    }
}
