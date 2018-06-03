using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создайте консольное приложение которое принимает от пользователя его дату рождения и возвращает его знак зодиака.
   Приложение принимает дату в формате: DD/MM/YYYY.*/
            DateTime birthDate ;
            Console.Write("Введите свою дату рождения:");
            if (DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine(birthDate);
                check(birthDate);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            
            Console.ReadKey();
        }

        public static void check(DateTime birthDate)
        {
            DateTime birthDate1 = new DateTime(birthDate.Year, 3, 21);
            if (birthDate >= new DateTime(birthDate.Year, 3, 21) && birthDate <= new DateTime(birthDate.Year, 4, 20))
            {
                Console.WriteLine("Овен");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 4, 21) && birthDate <= new DateTime(birthDate.Year, 5, 20))
            {
                Console.WriteLine("Телец");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 5, 21) && birthDate <= new DateTime(birthDate.Year, 6, 21))
            {
                Console.WriteLine("Близнецы");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 6, 22) && birthDate <= new DateTime(birthDate.Year, 7, 22))
            {
                Console.WriteLine("Рак");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 7, 23) && birthDate <= new DateTime(birthDate.Year, 8, 23))
            {
                Console.WriteLine("Лев");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 8, 24) && birthDate <= new DateTime(birthDate.Year, 9, 23))
            {
                Console.WriteLine("Дева");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 9, 24) && birthDate <= new DateTime(birthDate.Year, 10, 23))
            {
                Console.WriteLine("Весы");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 10, 24) && birthDate <= new DateTime(birthDate.Year, 11, 22))
            {
                Console.WriteLine("Скорпион");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 11, 23) && birthDate <= new DateTime(birthDate.Year, 12, 21))
            {
                Console.WriteLine("Стрелец");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 12, 22) && birthDate <= new DateTime(birthDate.AddYears(1).Year, 1, 20))
            {
                Console.WriteLine("Козерог");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 1, 21) && birthDate <= new DateTime(birthDate.Year, 2, 18))
            {
                Console.WriteLine("Водолей");
            }
            else if (birthDate >= new DateTime(birthDate.Year, 2, 19) && birthDate <= new DateTime(birthDate.Year, 3, 20))
            {
                Console.WriteLine("Рыбы");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
