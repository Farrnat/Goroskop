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
                    Console.WriteLine("Введите день и месяц дня рождения (пример 15,4)");
                    double dm = Convert.ToDouble(Console.ReadLine());



                    int[] rat = { 1900, 1912, 1924, 1936, 1948, 1960, 1972, 1984, 1996, 2008, 2020 }; //крыса
                    int[] bull = { 1901, 1913, 1925, 1937, 1949, 1961, 1973, 1985, 1997, 2009, 2021 }; //бык
                    int[] tiger = { 1902, 1914, 1926, 1938, 1950, 1962, 1973, 1986, 1998, 2010, 2022 }; //тигр
                    int[] cat = { 1903, 1915, 1927, 1939, 1951, 1963, 1974, 1987, 1999, 2011, 2023 }; //кошка
                    int[] dragon = { 1904, 1916, 1928, 1940, 1952, 1964, 1975, 1988, 2000, 2012, 2024 }; //дракон
                    int[] snake = { 1905 }; //змея
                    int[] horse = { 1906 }; //лошадь
                    int[] goat = { 1907 }; //коза
                    int[] monkey = { 1908 }; //обезьяна
                    int[] chicken = { 1909 }; //петух
                    int[] dog = { 1910 }; //собака
                    int[] hog = { 1911 }; //кабан
                    double[] oven = { 21.8 };
                    double[] telets = {  };
                    double[] bliznetsi = {  };
                    double[] rak = { };
                    double[] lev = {  };
                    double[] deva = {  };
                    double[] vesi = {  };
                    double[] scorpion = {  };
                    double[] strelets = {  };
                    double[] kozerog = {  };
                    double[] vodoley = {  };
                    double[] ribi = { };

                    bool flag = false;

                    if (rat.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год крысы и ваш знак зодиака овен");
                        flag = true;
                    }

                    else if (bull.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год быка");
                        flag = true;
                    }

                    else if (tiger.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год тигра");
                        flag = true;
                    }

                    else if (cat.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год кошки");
                        flag = true;
                    }

                    else if (dragon.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год дракона");
                        flag = true;
                    }

                    else if (snake.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год змеи");
                        flag = true;
                    }

                    else if (horse.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год лошади");
                        flag = true;
                    }

                    else if (goat.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год козы");
                        flag = true;
                    }

                    else if (monkey.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год обезьяны");
                        flag = true;
                    }

                    else if (chicken.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год петуха");
                        flag = true;
                    }

                    else if (dog.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год собаки");
                        flag = true;
                    }

                    else if (hog.Contains(year))
                    {
                        Console.WriteLine("Вы родились в год кабана");
                        flag = true;
                    }

                    else if (flag == false)
                    {
                        Console.WriteLine("Вы ввели дату ранее 1900 года");

                    }




                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Вы ввели не число или поставили точку между днем и месяцем. {0}", ex.Message);
                }


                Console.WriteLine("Если хотите продолжить работу с конвертором поставьте y, если нет - n");
                again = Convert.ToChar(Console.ReadLine());

            }
        }
    }
}
