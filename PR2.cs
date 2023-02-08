using System;

namespace PR1
{
    class Program
    {
        static Random rand = new Random(DateTime.UtcNow.Second);
        static void Main(string[] args)
        {
            char input;
            while (true)
            {
                Console.WriteLine(
                    "Выберете программу, которую хотите запустить\n" +
                    "1. Угадай число\n" +
                    "2. Таблица умножения\n" +
                    "3. Вывод делителей числа\n" +
                    "4. Закрыть программу");
                input = Console.ReadLine()[0];
                switch (input)
                {
                    case '1':
                        GuessNumber();
                        break;
                    case '2':
                        MultiplicationTable();
                        break;
                    case '3':
                        NumberDivisors();
                        break;
                    case '4':
                        return;
                }
            }
        }

        static void GuessNumber()
        {
            int number = rand.Next(0, 101);
            Console.WriteLine("Угадай число от 0 до 100!");
            while (true)
            {
                int userNum = Convert.ToInt32(Console.ReadLine());

                if (number < userNum)
                    Console.WriteLine("Надо меньше");
                else if (number > userNum)
                    Console.WriteLine("Надо больше");
                else
                    break;
            }
            Console.WriteLine("Угадал");
        }

        static void MultiplicationTable()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                    Console.Write((i*j).ToString() + '\t');
                Console.WriteLine();
            }
        }

        static void NumberDivisors()
        {
            Console.WriteLine("Чтобы выйти, введите слово \'выйти\'");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "выйти")
                    return;
                int userNum = Convert.ToInt32(input);
                for (int i = 1; i <= userNum; i++)
                    if (userNum % i == 0)
                        Console.Write(i.ToString() + '\t');
                Console.WriteLine();
            }
        }
    }
}
