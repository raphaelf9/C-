﻿using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "Televisão";

            Console.WriteLine(p.Nome);
        }
    }
}
