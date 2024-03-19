/*Напишіть програму, яка обчислює оплату праці працівника,
враховуючи години роботи та ставку за годину. Використовуйте арифметичні
операції для обчислення оплати.
*/


{
    Console.WriteLine("Введіть кількість відпрацьованих годин");
    int hoursWorked = int.Parse(Console.ReadLine());

    Console.WriteLine("Введіть ставку за годину роботи");
    int hourlyRate = int.Parse(Console.ReadLine());

    int payment = hoursWorked * hourlyRate;
    Console.WriteLine($"Оплата праці становить: {payment} гривень.");

}


/* Напишіть програму, яка перевіряє, чи є введене користувачем число
простим. Використовуйте арифметичні операції для перевірки дільників
числа.
*/


{
    Console.WriteLine("Введіть число для перевірки:");
    int number = int.Parse(Console.ReadLine());

    bool isPrime = true;

    if (number <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

    }

    if (isPrime)
    {
        Console.WriteLine($"Число {number} є простим.");
    }
    else
    {
        Console.WriteLine($"Число {number} не є простим.");
    }

}

/*Напишіть програму для конвертації температури з градусів Цельсія в
градуси Фаренгейта або навпаки. Використовуйте арифметичні операції для
конвертації.
*/


{
    Console.WriteLine("Введіть температуру в Цельсіях.");
    float numbercel = float.Parse(Console.ReadLine());

    double numberfar = (numbercel * 1.8 + 32);
    Console.WriteLine($" Температура в градусах Фаренгейта: {numberfar}");
}

/*Напишіть програму, яка перевіряє, чи належить введене користувачем
число заданому інтервалу. Використовуйте логічні оператори для перевірки
умови належності числа до інтервалу.
*/

{
    int low = 5;
    int hight = 15;

    Console.WriteLine($"Введіть число в інтеграл від {low} до {hight}:");
    float numberf = float.Parse(Console.ReadLine());

    if (numberf >= low && numberf <= hight)
    {
        Console.WriteLine($"Число {numberf} відноситься до інтегралу");
    }
    else
    {
        Console.WriteLine($"Число {numberf} не відноситься до інтегралу");
    }
}