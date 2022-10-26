using System;

class programm
{

    static void Main()
    {
        Console.WriteLine("Введите сумму вклада");

        double value = double.Parse(Console.ReadLine());

        if (value < 100)
        {
            value = value + value * 0.05;
        }
        else if (value < 200)
        {
            value = value + value * 0.07;
        }
        else
        {
            value = value + value * 0.1;
        }

        Console.WriteLine(value);

    }
}