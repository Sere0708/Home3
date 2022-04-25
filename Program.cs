/*
//. Задача 19.

namespace CA_9
{
    class Program
    {
 
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPalindrome(num));
            Console.ReadKey(true);
        }
        
        static bool IsPalindrome(int num)
        {
            if (num >= 0 && num <10)
                return true;
            int numLength = GetLength(num);
            int[] digits = new int[numLength];
            for (int i = numLength - 1; i >= 0; i--) {
                digits[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < numLength/2; i++) {
                if (digits[i] != digits[numLength - i - 1])
                    return false;
            }
            return true;
        }
        
        static int GetLength(int num)
        {
            int n = 0;
            while (num > 0) {
                num /= 10;
                n++;
            }
            return n;
        }
    }
}
*/
/*
// Задача. 21

Console.Write("Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между точками: {result}");
Console.ReadLine();
*/

/*
//. 
Задача. 23
using System;
 
class Program
{
 
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число N");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.WriteLine("{0}^2 = {1}", i, i*i);
        Console.ReadKey(true);
    }
}
*/



