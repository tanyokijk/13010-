using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введіть три параметри: два числа і дію над ними");
        string a = "";
        double x = 0;
        double y = 0;
        if (args.Length != 0)
        {
            a = args[1];
            x = double.Parse(args[0]);
            y = double.Parse(args[2]);

            switch (a)
            {
                case "+":
                    {
                        Console.WriteLine(x + "+" + y + "=" + (x + y));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(x + "-" + y + "=" + (x - y));
                        break;
                    }
                case "/":
                    {
                        if (y != 0)
                            Console.WriteLine(x + "/" + y + "=" + (x / y));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(x + "*" + y + "=" + (x * y));
                        break;
                    }
                case "%":
                    {
                        Console.WriteLine(x + "%" + y + "=" + (x % y));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ви ввели некоректний символ!");
                        break;
                    }
            }
        }
    }
}
