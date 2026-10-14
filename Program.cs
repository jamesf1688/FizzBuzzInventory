for (int item = 1; item <= 50; item++)
{
    string status;

    if (item % 3 == 0 && item % 5 == 0)
    {
        status = "Critical Alert";
    }
    else if (item % 3 == 0)
    {
        status = "Restock";
    }
    else if (item % 5 == 0)
    {
        status = "Overstock";
    }
    else
    {
        status = "OK";
    }

    Console.WriteLine($"Item [{item}]: {status}");
}
