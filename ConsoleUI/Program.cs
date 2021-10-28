﻿using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            /* foreach (var product in productManager.GetAll())
             {
                 Console.WriteLine(product.ProductName);
             }*/

            /* foreach (var product in productManager.GetAllByCategoryId(2))
             {
                 Console.WriteLine(product.ProductName);
             }*/

            foreach (var product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }


        }
    }
}