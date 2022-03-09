// Показать числа Фибоначчи.

Console.Clear();

Console.Write("Сколько чисел показать? ");
int count = int.Parse(Console.ReadLine());
int fur = 0;
int fur2 = 1;


void Change(int x, int y, int z)
{
    int change = 0;
    for (int i = 0; i < z; i++)
    {
        Console.Write(x + y + "   ");
        change = y;
        y = x + y;
        x = change;
    }
}

Change(fur, fur2, count);