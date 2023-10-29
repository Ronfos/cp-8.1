using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {

        //Задача1.1. Вызов пустого метода Func без возвращения значений для вычисления функции y=x2.
        //static void Func()
        //{
        //    Console.Write("x= ");
        //    int x = int.Parse(Console.ReadLine());
        //    int y = x * x;
        //    Console.WriteLine($"y={y}");
        //}
        //static void Main(string [] args)
        //{
        //    Func();
        //}

        //Задача1.2. Преобразуйте программу так, чтобы метод Func вызывался n раз.
        //static void Func()
        //{
        //    Console.Write("x= ");
        //    int x = int.Parse(Console.ReadLine());
        //    int y = x * x;
        //    Console.WriteLine($"y={y}");
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите n= ");
        //    int n = int.Parse(Console.ReadLine());
        //    for (int i = 0; i <= n; i++)
        //    { Func(); }
        //    Console.ReadKey();
        //}

        //Задача 1.3. Преобразуйте программу так, чтобы метод Func вычислял значение выражения:
        //static void Func()
        //{
        //    Console.Write("x= ");
        //    double x = int.Parse(Console.ReadLine());
        //    double y = ((3*x)*(3*x) + 8*x-10)/15;
        //    Console.WriteLine($"y={y}");
        //}
        //static void Main(string[] args)
        //{
        //    Func();
        //    Console.ReadKey();
        //}

        //Задача 2.Нахождение суммы двух чисел с использованием метода сложения двух чисел.
        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("x = ");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.Write("y = ");
        //    int y = int.Parse(Console.ReadLine());
        //    int add = Add(x, y);
        //    Console.WriteLine($"x + y = {add}");
        //    Console.ReadKey();
        //}

        //Задача 3. Вызов метода Func для вычисления функции y=x2, в который будет передаваться значение х от a до b
        //с шагом h, а сам метод возвращал значение y.
        //static void Func()
        //{
        //    Console.Write("a= ");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b= ");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.Write("h= ");
        //    int h = int.Parse(Console.ReadLine());
        //    int x = a;
        //    int y;
        //    for (int i = a; i <= b; i++)
        //    {
        //        y = x * x;
        //        x = x + h;
        //        Console.WriteLine($"y={y}");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Func();
        //    Console.ReadKey();
        //}


        //Задача 4. Составьте таблицу значений функции y = 5x² - 2x +1 на отрезке [-5; 5]
        //с шагом h = 2 с использованием дополнительного метода.
        //static void Func()
        //{
        //    int a = -5;
        //    Console.WriteLine($"a = {a}");
        //    int b = 5;
        //    Console.WriteLine($"b = {b} ");
        //    int h = 2;
        //    Console.WriteLine($"h = {h}");
        //    int x = a;
        //    int y;
        //    for (int i = a; i <= b; i++)
        //    {
        //        y = (5*x)*(5*x)-2*x+1;
        //        x = x + h;
        //        Console.WriteLine($"y={y}");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Func();
        //    Console.ReadKey();
        //}


        //Задача 5. Напишите дополнительный метод для вычисления функции:
        //static void Func()
        //{
        //    Console.WriteLine("Введите x: ");
        //    int x = int.Parse(Console.ReadLine());
        //    int y;
        //    if (x < 5)
        //    {
        //        y = (4 * x * 4 * x + 1) / x - 5;
        //        Console.WriteLine($"y={y }");
        //    }
        //    else 
        //    {
        //        y = 3 * x * 3 * x - 2;
        //        Console.WriteLine($"y={y}");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Func();
        //    Console.ReadKey();
        //}

        //Задача 6. Создайте приложение, которое выводит сумму, вычитание, умножение и деление двух параметров входных данных.
        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int Diff(int x, int y)
        //{
        //    return x - y;
        //}
        //public static int Mult(int x, int y)
        //{
        //    return x * y;
        //}
        //public static int Div(int x, int y)
        //{
        //    return x / y;
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("x= ");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.Write("y= ");
        //    int y = int.Parse(Console.ReadLine());
        //    int add = Add(x, y);
        //    int diff = Diff(x, y);
        //    int mult = Mult(x, y);
        //    int div = Div(x, y);
        //    Console.WriteLine($"x+y={add}\n x-y={diff}\n x*y={mult}\n x/y={div} ");
        //    Console.ReadKey();
        //}

       
        //Домашнее задание. 

        //static void Main(string[] args)
        //{

        //1. Нахождение максимальной величины из двух целых переменных a, b.
        //Console.Write("Введите число a: ");
        //int a = int.Parse(Console.ReadLine());
        //Console.Write("Введите число b: ");
        //int b = int.Parse(Console.ReadLine());
        //if (a > b)
        //{ Console.WriteLine($"Число a = {a} максимальное"); }
        //else if (a < b)
        //{ Console.WriteLine($"Число b = {b} максимальное"); }
        //else { Console.WriteLine($"Числа a = {a} и b = {b} оба являются макисмальными"); }
        //Console.ReadKey();


        //2. Вычислить среднее арифметическое трех действительных чисел.
        //Console.Write("Введите число a: ");
        //double a = int.Parse(Console.ReadLine());
        //Console.Write("Введите число b: ");
        //double b = int.Parse(Console.ReadLine());
        //Console.Write("Введите число c: ");
        //double c = int.Parse(Console.ReadLine());
        //double average = (a + b + c) / 3;
        //Console.WriteLine($"Среднее врифметическое = {average:f2}");
        //Console.ReadKey();
        //}


        //3. Составьте таблицу значений функции y = 4x² + 5x - 10 на отрезке[-9; 9] с шагом h = 3.
        static void Func()
        {
            for (double x = -9; x <= 9; x += 3)
            { Console.WriteLine($"x={x}\ty={4*Math.Pow(x, 2) + 5 * x - 10}"); }

        }
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }

    }
}
