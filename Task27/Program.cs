// написать программу, к-я принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sum = DigitSum(number);
Console.WriteLine("Сумма цифр в числе: " + sum);


int DigitSum(int number)
{
    int sum = 0;

    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }

        return sum;
}
