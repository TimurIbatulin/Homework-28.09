// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.Write("Введите число, которое нужно возвести в степень - ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение степени для числа - ");
// int i = Convert.ToInt32(Console.ReadLine());
// int F=a;
// int n=2;
// while (n<=i)
// {
//     F=F*a;
//     n++;
// }
// Console.Write($"{a} возведенное в степень {i} равно {F}");

// //for (int N = 2; N<=i; N++); с этим циклом не считало, я не нашел ошибку
// //{
// //    F=F*a;
// //}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// // 9012 -> 12
// Console.Write("Введите число - ");
// int a = Convert.ToInt32(Console.ReadLine());
// int m = a;
// int y = 0;
// while (a > 10)
// {
//     int z = a % 10;
//     a=a/10;
//     y=y+z;
// }
//     y=y+a;
// Console.Write($"Сумма всех чисел в числе {m} равна {y}");


//Console.WriteLine(a.Length);
//int z = Console.ReadLine();
//Console.WriteLine(z);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Выберете тип ввода массива ручной/автоматический - ");
string a = Console.ReadLine();
a=a.ToUpper();
string z = "РУЧНОЙ";
int index = 0;
int [] array = new int [8];
if (a==z)
{
    while (index<8)
    {
        Console.Write($"Введите {index} число массива - ");
        array[index]=Convert.ToInt32(Console.ReadLine());    
        index++;
    }
}
else
{
        while (index < 8)
    {
        array[index] = new Random().Next(0, 100);
        index++;
    }
}
int pos = 0;
while (pos < 8)
{
    Console.Write($"{array[pos]} ");
    pos++;
}

