for (int item = 1; item <= 50; item++)
{
    if (item % 3 == 0 && item % 5 == 0)
    {
        Console.WriteLine($"Item [{item}]: Critical Alert");
    }
    else if (item % 3 == 0)
    {
        Console.WriteLine($"Item [{item}]: Restock");
    }
    else if (item % 5 == 0)
    {
        Console.WriteLine($"Item [{item}]: Overstock");
    }
    else
    {
        Console.WriteLine($"Item [{item}]: OK");
    }
}
