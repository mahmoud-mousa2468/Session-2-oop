﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Iam Parent [Base]");
        }
        public void Fun02()
        {
            Console.WriteLine($"X : {X} :: Y : {Y}");
        }
        public Parent(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override string ToString()
        {
            return $"X : {X} :: Y : {Y}";
        }
    }
}
