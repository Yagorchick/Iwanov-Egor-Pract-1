namespace Iwanov_Egor_Pract_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите номер задания:\n" +
                    "0. Завершить Программу. \n" +
                    "1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними.\n" +
                    "2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:\n" +
                    "   a. сложение\n   b. вычитание\n   c. умножение\n   d. деление\n   e. нахождение остатка (оператор %)\n" +
                    "3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта.\n" +
                    "4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути.\n" +
                    "5. Разработайте программу для нахождения самого длинного слова в предложении.\n" +
                    "6. Разработайте программу, которая может перемножить два массива значений.\n" +
                    "7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных.\n" +
                    "8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем.\n" +
                    "9. Напечатать полную таблицу умножения.");

                Console.Write("\nВаш выбор: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 9)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите 0, 1, 2, 3, 4, 5, 6, 7, 8 или 9.");
                    Console.Clear();
                    continue;
                }

                if (choice == 0)
                {
                    return;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Task_1();
                        break;
                    case 2:
                        Task_2();
                        break;
                    case 3:
                        Task_3();
                        break;
                    case 4:
                        Task_4();
                        break;
                    case 5:
                        Task_5();
                        break;
                    case 6:
                        Task_6();
                        break;
                    case 7:
                        Task_7();
                        break;
                    case 8:
                        Task_8_1();
                        break;
                    case 9:
                        Task_8_2();
                        break;
                }
                Console.Clear();
            }
        }


        static void Task_1()
        {
            Console.WriteLine("Задача 1. Нахождение Среднего значения между Числами.");

            double num1, num2, num3, num4;

            Console.WriteLine("\nВведите Первое Число: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число");
            }

            Console.WriteLine("\nВведите Второе Число: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            Console.WriteLine("\nВведите Третье Число: ");
            while (!double.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            Console.WriteLine("\nВведите Четвертое Число: ");
            while (!double.TryParse(Console.ReadLine(), out num4))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            double MeanOfNum = (num1 + num2 + num3 + num4) / 4.0;

            Console.WriteLine($"\nСреднее значение между числами - {num1}, {num2}, {num3}, {num4} - это: {MeanOfNum}");
            Console.WriteLine("\nЗадача завершена, нажмите любую Клавишу, чтобы вернуться к списку Заданий!");
            Console.ReadKey();
        }

        static void Task_2()
        {
            Console.WriteLine("Задача 2. Калькулятор для двух Чисел (Сложение, Вычитание, Умножение, Деление, Нахождение Остатка - %) - числа вводите через Пробел!");

            Console.Write("\nВведите Два Числа: ");
            double [] array = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            double NumA = array[0];
            double NumB = array[1];

            while (true)
            {
                Console.WriteLine($"\nВы ввели числа: {NumA} и {NumB} \n\nКакое действие выполнить?\n" +
                    $"0. Выход\n" +
                    $"1. Сложение\n" +
                    $"2. Вычитание\n" +
                    $"3. Умножение\n" +
                    $"4. Деление\n" +
                    $"5. Нахождение остатка");

                Console.Write("\nВаш выбор: ");
                int UserChoice;

                if (!int.TryParse(Console.ReadLine(), out UserChoice) || UserChoice < 0 || UserChoice > 5)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите 0, 1, 2, 3, 4 или 5.");
                    continue;
                }

                switch (UserChoice)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine($"\nРезультат: {NumA} + {NumB} = {NumA + NumB}");
                        Console.WriteLine("\nЗадача проработана, чтобы продолжить - нажмите любую Клавишу!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine($"\nРезультат: {NumA} - {NumB} = {NumA - NumB}");
                        Console.WriteLine("\nЗадача проработана, чтобы продолжить - нажмите любую Клавишу!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine($"\nРезультат: {NumA} * {NumB} = {NumA * NumB}");
                        Console.WriteLine("\nЗадача проработана, чтобы продолжить - нажмите любую Клавишу!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        if (NumB != 0)
                        {
                            Console.WriteLine($"\nРезультат: {NumA} / {NumB} = {NumA / NumB}");
                            Console.WriteLine("\nЗадача проработана, чтобы продолжить - нажмите любую Клавишу!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nОшибка, на ноль делить нельзя!");
                        }
                        break;
                    case 5:
                        Console.WriteLine($"\nРезультат: {NumA} % {NumB} = {NumA % NumB}");
                        Console.WriteLine("\nЗадача проработана, чтобы продолжить - нажмите любую Клавишу!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("\nНеверный выбор, попробуйте снова!");
                        break;
                }
                Console.WriteLine("\nЗадача проработана, можете выбрать другую! Если хотите выйти, нажмите 0!");
            }
        }


        static void Task_3()
        {
            Console.WriteLine("Задача 3. Конвертация Температуры между типов Шкал (Цельсия, Кельвина, Фаренгейта)");

            while (true)
            {
                Console.WriteLine("\nВыберите шкалу вводимой температуры (Если хотите выйти, нажмите 0): \n" +
                   "0. Выход\n" +
                   "1. Цельсий\n" +
                   "2. Кельвин\n" +
                   "3. Фаренгейт");

                Console.Write("\nВаш выбор: ");
                int ChoiceOfType;

                if (!int.TryParse(Console.ReadLine(), out ChoiceOfType) || ChoiceOfType < 0 || ChoiceOfType > 3)
                {
                    Console.WriteLine("\nНекорректный ввод. Пожалуйста, выберите 0, 1, 2 или 3.");
                    continue;
                }

                if (ChoiceOfType == 0)
                {
                    Console.WriteLine("Выход из программы.");
                    return;
                }

                Console.Write("\nВведите показатель Температуры: ");
                double Temperature;
                if (!double.TryParse(Console.ReadLine(), out Temperature))
                {
                    Console.WriteLine("\nНекорректный ввод температуры. Пожалуйста, введите числовое значение.");
                    continue;
                }

                Console.WriteLine("\nВыберите тип шкалы для конвертации: \n" +
                    "1. Цельсий\n" +
                    "2. Кельвин\n" +
                    "3. Фаренгейт");

                Console.Write("\nВаш выбор: ");
                int ChoiceOfConvert;

                if (!int.TryParse(Console.ReadLine(), out ChoiceOfConvert) || ChoiceOfConvert < 1 || ChoiceOfConvert > 3)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите 1, 2 или 3.");
                    continue;
                }

                string Type = "";
                string ConvertToType = "";

                switch (ChoiceOfType)
                {
                    case 1:
                        Type = "Цельсий";
                        break;
                    case 2:
                        Type = "Кельвин";
                        break;
                    case 3:
                        Type = "Фаренгейт";
                        break;
                }
                switch (ChoiceOfConvert)
                {
                    case 1:
                        if (ChoiceOfType == 2)
                        {
                            Temperature = Temperature - 273.15;
                        }
                        else if (ChoiceOfType == 3)
                        {
                            Temperature = (Temperature - 32) * (5 / 9.0);
                        }
                        ConvertToType = "Цельсий";
                        break;
                    case 2:
                        if (ChoiceOfType == 1)
                        {
                            Temperature = Temperature + 273.15;
                        }
                        else if (ChoiceOfType == 3)
                        {
                            Temperature = (Temperature - 32) * (5 / 9.0) + 273.15;
                        }
                        ConvertToType = "Кельвин";
                        break;
                    case 3:
                        if (ChoiceOfType == 1)
                        {
                            Temperature = Temperature * (9 / 5.0) + 32;
                        }
                        else if (ChoiceOfType == 2)
                        {
                            Temperature = (Temperature - 273.15) * (9 / 5.0) + 32;
                        }
                        ConvertToType = "Фаренгейт";
                        break;
                }

                Console.WriteLine($"\nВы выбрали: {Type} -> {ConvertToType}\n" +
                    $"Результат конвертации: {Math.Round(Temperature, 1)}");
                Console.WriteLine("\nЗадача проработана, чтобы продолжить - нажмите любую Клавишу!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void Task_4()
        {
            Console.WriteLine("Задача 4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути.");

            Console.Write("\nВведите путь до файла: ");
            string? route = Console.ReadLine();

            if (!string.IsNullOrEmpty(route) && File.Exists(route))
            {
                string[] substrings = route.Split(Path.DirectorySeparatorChar);
                string fileName = substrings[substrings.Length - 1];
                Console.WriteLine($"\nИмя файла: {fileName}");
            }
            else
            {
                Console.WriteLine("\nФайл не найден по указанному пути или путь не был введен.");
            }

            Console.WriteLine("\nЗадача завершена, нажмите любую клавишу, чтобы вернуться к списку задач!");
            Console.ReadKey();
        }
        static void Task_5()
        {
            Console.WriteLine("Задача 5. Нахождение самого длинного слова в предложении.");

            Console.Write("\nВведите предложение: ");
            string str = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("\nВы ввели пустую строку. Пожалуйста, введите предложение.");
                Console.WriteLine("\nЗадача завершена, нажмите любую Клавишу, чтобы вернуться к списку Заданий!");
                Console.ReadKey();
                return;
            }

            string[] Substring = str.Split(" ");
            string longWord = Substring[0];

            foreach (string word in Substring)
            {
                if (word.Length > longWord.Length)
                {
                    longWord = word;
                }
            }
            Console.WriteLine($"\nСамое длинное слово: {longWord}");
            Console.WriteLine("\nЗадача завершена, нажмите любую Клавишу, чтобы вернуться к списку Заданий!");
            Console.ReadKey();
        }

        static void Task_6()
        {
            Console.WriteLine("Задача 6. Перемножение значений двух Массивов (Вводите через Пробел).");

            Console.Write("\nВведите значения для Первого Массива: ");
            int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Console.Write("\nВведите значения для Второго Массива: ");
            int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Console.Write("\nРезультат: ");

            for (int i = 0; i < arr1.Length; i++)
            {
                try
                {
                    Console.Write($"{arr1[i] * arr2[i]} ");
                }
                catch
                {
                    Console.WriteLine("\nОшибка, Массивы не могут быть разных Размеров!");
                }
            }

            Console.WriteLine("\n\nЗадача завершена, нажмите любую Клавишу, чтобы вернуться к списку Заданий!");
            Console.ReadKey();
        }

        static void Task_7()
        {
            Console.WriteLine("Задача 7. Найти Максимальное и Минимальное - Числа");

            Console.Write("\nВведите пять чисел: ");
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int max = arr.Max();
            int min = arr.Min();

            Console.WriteLine($"\nМаксимальное Число: {max}");
            Console.WriteLine($"Минимальное Число: {min}");

            Console.WriteLine("\nЗадача завершена, нажмите любую Клавишу, чтобы вернуться к списку Заданий!");
            Console.ReadKey();
        }

        static void Task_8_1()
        {
            Console.WriteLine("Задача 8.1 Постройка Пирамиды из Чисел, исходя из введенного пользователем Числа.");

            int numOfSteps;

            while (true)
            {
                Console.Write("\nВведите количество ступеней: ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out numOfSteps) && numOfSteps > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите положительное целое число.");
                }
            }

            for (int i = 1; i <= numOfSteps; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nЗадача завершена, нажмите любую Клавишу, чтобы вернуться к списку Заданий!");
            Console.ReadKey();
        }

        static void Task_8_2()
        {
            Console.WriteLine("Задача 8.2 Полная Таблица Умножения.");

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"\n{i} x {j} = {i * j}   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nЗадача завершена, нажмите любую Клавишу, чтобы вернуться к списку Заданий!");
            Console.ReadKey();
        }

        //Задание по Варианту (Я 7, по идеи) - Оно уже и так выполнено в процессе выполнения других 9и Заданий
    }
}
