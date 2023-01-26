for (int i = 10; i >= 0; i--)
{
    for (int j = i; j >= 0; j--)
    {
        Console.Write(Convert.ToString(j).PadLeft(2) + " ");
    }
    Console.WriteLine();
}