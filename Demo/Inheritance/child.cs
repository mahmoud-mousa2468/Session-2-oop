﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child:Parent
    {
        public int Z { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Iam Child [Derived]");
        }
        public void Fun02()
        {
            Console.WriteLine($"X : {X} :: Y : {Y} Z : {Z}");
        }
        public Child(int X,int Y,int Z):base(X,Y)
        {
            this.Z = Z;
        }

        public override string ToString()
        {
            return $"X : {X} :: Y : {Y} :: Z : {Z}";
        }
    }
}
