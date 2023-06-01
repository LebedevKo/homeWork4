// написать цикл, который принимает на вход два числа (А и Б) и возводит число А в натуральную степень Б

// Console.WriteLine("Введите число A:");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B:");
// int B = Convert.ToInt32(Console.ReadLine());


//     int result = 1;

//     for (int i = 1; i <= B; i++)
//     {
//         result *= A;
//     }

//     return result;

// Console.WriteLine("Результат: " + result);

Console.WriteLine("Введите число A:");
double A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());

double result = number(A, B);
Console.WriteLine("Результат: " + result);
    
double number(double A, int B)
{
    double result = 1;

    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }

    return result;
}