Console.Write("Введите трехзначное и нажмите клавишу Enter: ");

int a = int.Parse(Console.ReadLine());
int b = 0;


if (99 < a & a < 1000 )
{
    b = a / 10 % 10;
    Console.WriteLine(b);
}
else 
{
    Console.WriteLine("Введено не трехзначное число!");
}
