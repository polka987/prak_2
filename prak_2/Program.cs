class Program
{
    private static void Main() => menu();

    private static void menu()
    {
        Console.WriteLine("Выберите подпрограмму, которую хотите выполнить:\n1.Угадай число\n2.Таблица умножения\n3.Вывод делителей числа");
        switch (Console.ReadLine())
        {
            case "1":
                program1();
                break;
            case "2":
                program2();
                break;
            case "3":
                program3();
                break;
        }
        pause();
    }

    private static void program3()
    {
        Console.Clear();
        Console.WriteLine("Введите число, делители котого хотите узнать:");
        List<int> rezult = new List<int>();
        string a = Console.ReadLine();
        int tmp = int_in_string(a);
        for (int i = 1; i < tmp + 1; i++)
            if (tmp % i == 0)
                rezult.Add(i);
        Console.WriteLine($"Делите числа {tmp}:\n");
        foreach(int i in rezult)
            Console.Write(i+" ");
        pause();
    }

    private static void program2()
    {
        Console.Clear();
        List<List<int>> ints = new List<List<int>>();
        for (int i = 0; i < 9; i++)
        {
            ints.Add(new List<int>());
            for (int j = 0; j < 9; j++)
            {
                ints[i].Add((i + 1) * (j + 1));
            }
        }
        foreach (var i in ints)
        {
            foreach (var j in i)
            {
                Console.Write($"{j}\t");
            }
            Console.WriteLine();
        }
    }

    private static void program1()
    {
        Console.Clear();
        Console.WriteLine("Дано число, которое меньше 100, но больше 0, необходимо его угадать, при неправильном ответе будет указано - больше число введенного или меньше");
        int rnd = new Random().Next(100);
        while (true)
        {
            string a = Console.ReadLine();
            int tmp = int_in_string(a);
            if (tmp > rnd)
                Console.WriteLine("Введенное число больше искомого");
            else if (tmp < rnd)
                Console.WriteLine("Введенное число меньше искомого");
            else
            {
                Console.WriteLine("Вы угадали!");
                break;
            }
        }
        pause();

    }
    static int int_in_string(string a) => Convert.ToInt32(string.Join("", a.Where(c => char.IsDigit(c))));
    static void pause()
    {
        Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить");
        Console.ReadKey();
        Console.Clear();
        menu();
    }
}