int a = Convert.ToInt32(Console.ReadLine());
int b = a % 10;
int c = a % 100;
if (b == 1 & c != 11)
{
    Console.WriteLine(a + " программист");
}
else if (b == 2 & c != 12)
{
    Console.WriteLine(a + " программиста");
}
else if (b == 3 & c != 13)
{
    Console.WriteLine(a + " программиста");
}
else if (b == 4 & c != 14)
{
    Console.WriteLine(a + " программиста");
}
else
{
    Console.WriteLine(a + " программистов");
}