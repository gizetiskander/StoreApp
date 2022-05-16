using System;
using System.Collections.Generic;
using StoreApp1;


namespace StoreApp1
{
    class Program : Operations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите команду:");
            Console.WriteLine("1 - Показать товары");
            Console.WriteLine("2 - Выйти");
            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Operations.ShowProductList();
                    goto case "2";
                case "2":
                    Console.WriteLine("Выберите команду:");
                    Console.WriteLine("3- Найти товар по названию и описанию");
                    Console.WriteLine("4- Сортировка товара по возрастанию цены и фильтрация производителя");
                    Console.WriteLine("5- Сортировка товара по убыванию цены и фильтрация производителя");
                    string str1 = Console.ReadLine();
                    if (str1 == "3")
                    {
                        goto case "3";
                    }
                    else if (str1 == "4")
                    {
                       // goto case "4";
                    }
                    else if (str1 == "5")
                    {
                      //  goto case "5";
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    goto case "1";
                case "3":
                    Console.WriteLine("Введите название товара:");
                    string str2 = Console.ReadLine();
                    if (str2 == "Пеленка")
                    {
                        Console.WriteLine(prod.FindAll(delegate (Product product) { return product.Name == "Пеленка"; }));
                    }
                    goto case "2";
                    
                //case "4":
                  //  Operations.prod.Sort(delegate (Product prod1, Product prod2) { return prod1.Name.CompareTo(prod2.Name); });
            }
        }

    }
}
