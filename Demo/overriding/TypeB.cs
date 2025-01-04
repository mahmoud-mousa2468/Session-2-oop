using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overriding
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }

        //override or hide 
        //apply override
        //1- apply override using "new" Keyword
        //1- apply override using "override" Keyword
        public new void Fun01() //using new Keyword
        {
            Console.WriteLine("Iam Type B");
        }

        // Must Be Not Private and Virtual
        public override void Fun02() //using override Keyword
        {
            Console.WriteLine($"A: {A} :: B : {B}");
        }

    }
}
