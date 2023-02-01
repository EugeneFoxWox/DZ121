class Doma
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение первой переменной А: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение второй переменной B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int tmp;
        tmp = a; 
        a = b;
        b = tmp;

        Console.WriteLine("Поздравляю, Вы успешно поменяли их значения!\nТеперь A = {0},\nпеременная B = {1}\n Конец программы!", a, b);
    }
}
