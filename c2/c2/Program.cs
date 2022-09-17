/*
    1.Сложить 2 числа
2.Вычесть первое из второго
3. Перемножить два числа
4. Разделить первое на второе
5. Возвести в степень N первое число
6. Найти квадратный корень из числа
7. Найти 1 процент от числа
8. Найти факториал из числа
9. Выйти из программы
    */

Console.WriteLine("напишите 'да' если хотите начать");
string? im = Console.ReadLine();
while (im == "да" || im == "ДА" || im == "Да")
{
    Console.WriteLine("ВЫБИРИТЕ ОПЕРАЦИЮ КОТОРУЮ ХОТИТЕ ВЫПОЛНИТЬ");
    Console.WriteLine("1. Сложить два числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");

    int deictvie = Convert.ToInt32(Console.ReadLine());
    int end = deictvie - 1;
    if (deictvie <= 9)
    {
        if (deictvie == 1)
        {
            Console.WriteLine("введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат " + (a + b));
        }

        else if (deictvie == 2)
        {
            Console.WriteLine("введите первое число");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат " + (d - c));

        }
        else if (deictvie == 3)
        {
            Console.WriteLine("введите первое число");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат " + (f * n));
        }
        else if (deictvie == 4)
        {
            Console.WriteLine("введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат " + (x / y));
        }
        else if (deictvie == 5)
        {
            Console.WriteLine("введите первое число");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат " + Math.Pow(z, q));
        }
        else if (deictvie == 6)
        {
            Console.WriteLine("введите число");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат " + Math.Sqrt(l));
        }
        else if (deictvie == 7)
        {
            Console.WriteLine("введите число");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("результат " + (i / 100) * 1);
        }
        else if (deictvie == 8)
        {
            Console.WriteLine("введите число");
            int w = 1;
            for (int o = Convert.ToInt32(Console.ReadLine()); o > 0; o--)
            {
                w = w * o;
            }
            Console.WriteLine("результат " + (w));
        }
if (deictvie == 9)
{
            Console.WriteLine("конец");
            break;
}
}
}







