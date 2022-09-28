int QuestVarI = 1;
while (1 <= QuestVarI && QuestVarI <= 4) 
{
    Console.WriteLine("Выберите программу, которую хотите запустить");
    Console.WriteLine("1. Угадай число от 1 до 100");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Закрыть программу");
    Console.Write("Введите номер: ");
    QuestVarI = Convert.ToInt32(Console.ReadLine());
    if (QuestVarI == 1)
    {
        Random rnd = new Random();
        int value, CycleVar;
        value = rnd.Next(1, 101);
        CycleVar = 1;
        Console.Write("Введите предполагаемое число: ");
        while (CycleVar != value)
        {
            int UserAnsw = Convert.ToInt32(Console.ReadLine());
            CycleVar = UserAnsw;
            if (UserAnsw < value)
            {
                Console.WriteLine("Больше");
            }
            else if (UserAnsw > value)
            {
                Console.WriteLine("Меньше");
            }
            else
            {
                Console.WriteLine("Ура, ты угадал");
            }
        }
    }
    else if (QuestVarI == 2)
    {
        int[,] matrica = new int[10, 10];
        for (int vertI = 1; vertI < 10; vertI++)
            for (int gorI = 1; gorI < 10; gorI++)
                matrica[vertI, gorI] = vertI*gorI;
        for (int vertI = 1; vertI < 10; vertI++)
        {
            Console.WriteLine();
            for (int gorI = 1; gorI < 10; gorI++)
                Console.Write("{0,3}", matrica[vertI, gorI]);
                Console.WriteLine("");
        }
    }
    else if (QuestVarI == 3)
    {
        Console.Write("Введите число для проверки: ");
        int DelVar = Convert.ToInt32(Console.ReadLine());
        for (int check = 1; check < (DelVar+1); check++ )
        {
            if (DelVar % check == 0)
            {
                Console.WriteLine(check);
            }
        }
    }
    else if (QuestVarI == 4)
    {
        break;
    }
    else
    {
        Console.WriteLine("Не та команда 0_о");
        QuestVarI = 1;
    }
}