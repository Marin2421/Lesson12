//Домашнее задание. Тема 13. Урок 1. Циклы while и do while.

Random random = new Random();
int secretNumber = random.Next(1, 6);
int attempts = 3;
int currentAttempt = 0;

Console.WriteLine("Компьютер загадал число от 1 до 5. У вас есть 3 попытки, чтобы угадать.");

while (currentAttempt < attempts)
{
    Console.Write("Попытка {0}: Введите ваше предположение: ", currentAttempt + 1);
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess == secretNumber)
    {
        Console.WriteLine("Поздравляем! Вы угадали число.");
        return;
    }
    else
    {
        Console.WriteLine("Неверно. Попробуйте еще раз.");
    }

    currentAttempt++;
}

Console.WriteLine("Компьютер загадал число: " + secretNumber);

//Домашнее задание. Тема 12. Урок 2. Операторы ветвления Switch/Case.

Console.Write("Выберите парфюм:\n1 - Chanel\n2 - Dior\n3 - Tom Ford\n4 - Gucci\n5 - Yves Saint Laurent");
int n = int.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        Console.WriteLine("Chanel - классический аромат с богатой историей.");
        break;
    case 2:
        Console.WriteLine("Dior - известен своими элегантными ароматами и вечным обаянием.");
        break;
    case 3:
        Console.WriteLine("Tom Ford - предлагает роскошные и смелые ароматы.");
        break;
    case 4:
        Console.WriteLine("Gucci - объединяет современность и наследие в своих ароматах.");
        break;
    case 5:
        Console.WriteLine("Yves Saint Laurent - символ утонченности и дерзости.");
        break;
    default:
        Console.WriteLine("Неверный выбор. Пожалуйста, выберите число от 1 до 5.");
        break;
}