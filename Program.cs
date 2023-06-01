// напишите программу которая принимает на вход число (А) и выдает сумму от 1 до А.

// int a = 0;

// int Sum(int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// int result = Sum(5);
// Console.WriteLine(result);

// написать прогу, к-я принимает на вход число и выдаёт кол-во цифр в числе.
// int countch( int ch)
// {
//     int count = 0;
//     while (ch > 0)
//     {
//         int b = ch%10;
//         count +=1;
//         ch/=10;
//     }
//     return count;
// }
// Console.WriteLine("введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"кол-во цифр {countch(a)}");


// написать прогу, к-я принимает на вход число N и выдает произведение от 1 до N.
// Console.WriteLine("введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// int Pro(int a)
// {
//     int result = 1;
//     for (int i = 1; i <= a; i++)
//     {
//         result *= i; // result = result * i
//     }
//     return result;
// }

// int result = Pro(a);
// Console.WriteLine($"результат равен {result}");

//  написать программу, к-я выводит массив из 8 эл-тов, заполненных нулями и единицами в случайном порядке
// в виде массива

// int rando()
// {
//     int random = new Random().Next(0, 2);
//     return random;
// }
// int[] matrix = new int[8];
// for (int i = 0; i <= 7; i++)
// {
//     matrix[i] = rando();
// }
// Console.WriteLine("массив: " + String.Join(", ", matrix)); // Join соединяет то, что в скобках(аргументы), разделяя их тем, чем задали
//                                                             //  Sting.Join переводит в строку, т.к. WriteLine выдает только строку в консоль



