// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

    int SumCif(int A)
    {
        if(A<0)
        {
            A = -A;
        }
        int sum = 0;
        while (A != 0)
            {
                int num = A % 10;
                A = A / 10;
                sum = sum + num;
            }
        return sum;
    }

Console.Clear();
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Cумма всех цифр в числе равна: {SumCif(a)}");

