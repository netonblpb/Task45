// Показать числа Фибоначчи.

Console.Clear();

Console.Write("Сколько чисел показать? ");
int count = int.Parse(Console.ReadLine());
int fur = 0;
int fur2 = 1;
int change = 0;
for (int i = 0; i < count; i++)
{    
    Console.Write(fur + fur2 + "   ");
    change = fur2;
    fur2 = fur + fur2;
    fur = change;
}