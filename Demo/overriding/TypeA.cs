using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overriding
{
    internal class TypeA
    {
        public int A { get; set; }
        public void Fun01()
        {
            Console.WriteLine("Iam Type A");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"A: {A}");
        }
    }
}
