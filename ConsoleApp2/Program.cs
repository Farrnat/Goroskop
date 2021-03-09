using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y')
            {
                try
                {

                    Console.WriteLine("Введите год рождения");
                    int year = Convert.ToInt32(Console.ReadLine());

                    int[] rat = { 1900, 1912, 1924, 1936, 1948, 1960, 1972, 1984, 1996, 2008, 2020 }; //крыса
                    int[] bull = { 1901, 1913, 1925, 1937, 1949, 1961, 1973, 1985, 1997, 2009, 2021 }; //бык
                    int[] tiger = { 1902, 1914, 1926, 1938, 1950, 1962, 1973, 1986, 1998, 2010, 2022 }; //тигр
                    int[] cat = { 1903, 1915, 1927, 1939, 1951, 1963, 1974, 1987, 1999, 2011, 2023 }; //кошка
                    int[] dragon = { 1904, 1916, 1928, 1940, 1952, 1964, 1975, 1988, 2000, 2012, 2024 }; //дракон
                    int[] snake = { }; //змея
                    int[] horse = { }; //лошадь
                    int[] goat = { }; //коза
                    int[] monkey = { }; //обезьяна
                    int[] chicken = { }; //петух
                    int[] dog = { }; //собака
                    int[] hog = { }; //кабан

                    bool flag = false;
                    if (rat.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год крысы");
                        flag = true;
                    }

                    else if (bull.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год быка");
                        flag = true;
                    }

                    else if (flag == false)
                    {
                        Console.WriteLine("Вы ввели дату ранее 1900 года");

                    }




                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Вы ввели не число. {0}", ex.Message);
                }


                Console.WriteLine("Если хотите продолжить работу с конвертором поставьте y, если нет - n");
                again = Convert.ToChar(Console.ReadLine());

            }
        }
    }
}
