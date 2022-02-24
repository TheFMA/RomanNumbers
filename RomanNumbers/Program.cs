using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RomanNumber obj1 = new RomanNumber(32);
                RomanNumber obj2 = new RomanNumber(4);
                RomanNumber obj3 = new RomanNumber(13);
                RomanNumber obj4 = new RomanNumber(26);
                Console.WriteLine($"Сложение: {obj3.ToString()} + {obj4.ToString()} = {RomanNumber.Add(obj3, obj4).ToString()}");
                Console.WriteLine($"Деление: {obj1.ToString()} / {obj2.ToString()} = {RomanNumber.Div(obj1, obj2).ToString()}");
                Console.WriteLine($"Вычитание: {obj1.ToString()} - {obj4.ToString()} = {RomanNumber.Sub(obj1, obj4).ToString()}");
                Console.WriteLine($"Умножение: {obj2.ToString()} * {obj3.ToString()} = {RomanNumber.Mul(obj2, obj3).ToString()}");
                RomanNumber[] objects = { obj1, obj2, obj3, obj4 };
                Array.Sort(objects);
                Console.WriteLine("Результат сортировки");
                foreach (var value in objects)
                {
                    Console.Write(value.ToString() + " ");
                }

            }
            catch (RomanNumberException exception)
            {
                Console.WriteLine($"Ошибка: {exception.Message}");
            }

        }
    }
}
