Console.Write("Введите и нажмите клавишу Enter: ");

string n_str = Console.ReadLine();
int len = n_str.Length;
int n = Convert.ToInt32(n_str);
int i = 0;

if (len <= 2)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    while (i < (len - 3))

    {
        n = n / 10;
        i++;
    }
    Console.WriteLine(n % 10);
}
