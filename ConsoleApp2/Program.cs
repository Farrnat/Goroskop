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
                    int[] snake = { 1905, 1917, 1929, 1941, 1953, 1965, 1976, 1989, 2001, 2013, 2025 }; //змея
                    int[] horse = { 1906, 1918, 1930, 1942, 1954, 1966, 1977, 1990, 2002, 2014, 2026 }; //лошадь
                    int[] goat = { 1907, 1919, 1931, 1943, 1955, 1967, 1978, 1991, 2003, 2015, 2027 }; //коза
                    int[] monkey = { 1908, 1920, 1932, 1944, 1956, 1968, 1979, 1992, 2004, 2016, 2028 }; //обезьяна
                    int[] chicken = { 1909, 1921, 1933, 1945, 1957, 1969, 1980, 1993, 2005, 2017, 2029 }; //петух
                    int[] dog = { 1910, 1922, 1934, 1946, 1958, 1970, 1981, 1994, 2006, 2018, 2020 }; //собака
                    int[] hog = { 1911, 1923, 1935, 1947, 1959, 1971, 1982, 1995, 2007, 2019, 2021 }; //кабан
                    double[] oven = { 21.3, 22.3, 23.3, 24.3, 25.3, 26.3, 27.3, 29.3, 30.3, 31.3, 1.4, 2.4, 3.4, 4.4, 5.4, 6.4, 7.4, 8.4, 10.4, 11.4, 12.4, 13.4, 14.4, 15.4, 16.4, 17.4, 18.4, 19.4, 20.4 };
                    double[] telets = { 21.4, 22.4, 23.4, 24.4, 25.4, 26.4, 27.4, 28.4, 30.4, 31.4, 1.5, 2.5, 3.5, 4.5, 5.5, 6.5, 7.5, 8.5, 9.5, 10.5, 11.5, 12.5, 13.5, 14.5, 15.5, 16.5, 17.5, 18.5, 19.5, 20.5, 21.5 };
                    double[] bliznetsi = { 22.5, 23.5, 24.5, 25.5, 26.5, 27.5, 28.5, 29.5, 30.5, 31.5, 1.6, 2.6, 3.6, 4.6, 5.6, 7.6, 8.6, 9.6, 10.6, 11.6, 12.6, 13.6, 14.6, 15.6, 16.6, 17.6, 18.6, 19.6, 20.6, 21.6 };
                    double[] rak = { 22.6, 23.6, 24.6, 25.6, 27.6, 28.6, 29.6, 30.6, 31.6, 1.7, 2.7, 3.7, 4.7, 5.7, 6.7, 7.7, 8.7, 9.7, 10.7, 11.7, 12.7, 13.7, 14.7, 15.7, 16.7, 17.7, 18.7, 19.7, 20.7, 21.7, 22.7 };
                    double[] lev = { 23.7, 24.7, 25.7, 26.7, 27.7, 28.7, 29.7, 30.7, 31.7, 1.8, 2.8, 3.8, 4.8, 5.8, 6.8, 7.8, 8.8, 9.8, 10.8, 11.8, 12.8, 13.8, 14.8, 15.8, 16.8, 17.8, 18.8, 19.8, 20.8, 21.8 };
                    double[] deva = { 22.8, 23.8, 24.8, 25.8, 26.8, 27.8, 28.8, 29.8, 30.8, 31.8, 1.9, 2.9, 3.9, 4.9, 5.9, 6.9, 7.9, 8.9, 10.9, 11.9, 12.9, 13.9, 14.9, 15.9, 16.9, 17.9, 18.9, 19.9, 20.9, 21.9, 22.9, 23.9 };
                    double[] vesi = { 24.9, 25.9, 26.9, 27.9, 28.9, 29.9, 30.9, 31.9, 1.10, 2.10, 3.10, 4.10, 5.10, 6.10, 7.10, 8.10, 9.10, 10.10, 11.10, 12.10, 13.10, 14.10, 15.10, 16.10, 17.10, 18.10, 19.10, 20.10, 21.10, 22.10, 23.10 };
                    double[] scorpion = {24.10-22.11 };
                    double[] strelets = { 23.11-22.12};
                    double[] kozerog = { 23.12-20.01};
                    double[] vodoley = { 21.01-19.02};
                    double[] ribi = { 20.02-20.03};

                    bool flag = false;

                    if (rat.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("");
                        flag = true;
                    }

                    else if (bull.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год быка");
                        flag = true;
                    }

                    else if (tiger.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год тигра");
                        flag = true;
                    }

                    else if (cat.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год кошки");
                        flag = true;
                    }

                    else if (dragon.Contains(year))
                    {

                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год дракона");
                        flag = true;
                    }

                    else if (snake.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год змеи");
                        flag = true;
                    }

                    else if (horse.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год лошади");
                        flag = true;
                    }

                    else if (goat.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год козы");
                        flag = true;
                    }

                    else if (monkey.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год обезьяны");
                        flag = true;
                    }

                    else if (chicken.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год петуха");
                        flag = true;
                    }

                    else if (dog.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

                        Console.WriteLine("Вы родились в год собаки");
                        flag = true;
                    }

                    else if (hog.Contains(year))
                    {
                        if(oven.Contains(dm))
                        {

                        }
                        
                        else if(telets.Contains(dm))
                        {
                        
                        }

                        else if(bliznetsi.Contains(dm))
                        {
                        
                        }

                        else if(rak.Contains(dm))
                        {
                        
                        }

                        else if(lev.Contains(dm))
                        {
                        
                        }

                        else if(deva.Contains(dm))
                        {
                        
                        }

                        else if(vesi.Contains(dm))
                        {
                        
                        }

                        else if(scorpion.Contains(dm))
                        {
                        
                        }

                        else if(strelets.Contains(dm))
                        {
                        
                        }

                        else if(kozerog.Contains(dm))
                        {
                        
                        }

                        else if(vodoley.Contains(dm))
                        {
                        
                        }

                        else if(ribi.Contains(dm))
                        {
                        
                        }

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
