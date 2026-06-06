using System;

class Program
{
    static void Main()
    {
        #region İstifadəçi 1 ilə 100 arasında ədəd daxil edir. Ədəd 3-ə bölünürsə Fizz, 5-ə bölünürsə Buzz, hər ikisinə bölünürsə Fizz Buzz çap edilir

        Console.Write("Ədədi daxil edin: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 3 == 0 && num % 5 == 0)
            Console.WriteLine("Fizz Buzz");
        else if (num % 3 == 0)
            Console.WriteLine("Fizz");
        else if (num % 5 == 0)
            Console.WriteLine("Buzz");
        else
            Console.WriteLine(num);

        #endregion


        #region İstifadəçi iki ədəd daxil edir. Birinci dəyər, ikinci faizdir. Dəyərin faizini hesabla

        Console.Write("Dəyəri daxil edin: ");
        double value = double.Parse(Console.ReadLine());

        Console.Write("Faizi daxil edin: ");
        double percent = double.Parse(Console.ReadLine());

        Console.WriteLine("Nəticə: " + value * percent / 100);

        #endregion


        #region Temperaturu Fahrenheitdən Celsiusa və ya Celsiusdan Fahrenheitə çevir

        Console.WriteLine("1 - Celsius -> Fahrenheit");
        Console.WriteLine("2 - Fahrenheit -> Celsius");

        Console.Write("Seçim: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Temperaturu daxil edin: ");
        double temp = double.Parse(Console.ReadLine());

        if (choice == 1)
            Console.WriteLine("Fahrenheit: " + (temp * 9 / 5 + 32));
        else if (choice == 2)
            Console.WriteLine("Celsius: " + ((temp - 32) * 5 / 9));

        #endregion
    }
}
