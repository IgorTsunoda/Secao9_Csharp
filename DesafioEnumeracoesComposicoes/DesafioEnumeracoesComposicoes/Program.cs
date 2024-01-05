﻿using DesafioEnumeracoesComposicoes.Entity;
using DesafioEnumeracoesComposicoes.Entity.Enum;

namespace DesafioEnumeracoesComposicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine("How many items for this order: ");
            int nItems = int.Parse(Console.ReadLine());

            for(int i = 1; i <= nItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name: ");
                string product = Console.ReadLine();
            }


        }
    }
}