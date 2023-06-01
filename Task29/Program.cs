// паписать программу, которая принимает 8 чисел и выводит их в виде массива на экран


//Console.WriteLine("Введите количество цифр для массива:");
//int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[8]; // вместо 8 пишем size

for (int i = 0; i < 8; i++) // вместо 8 пишем size
{
    Console.WriteLine("Введите цифру:");
    int digit = Convert.ToInt32(Console.ReadLine());
    numbers[i] = digit;
}

Console.WriteLine("массив: " + String.Join(", ", numbers)); 
