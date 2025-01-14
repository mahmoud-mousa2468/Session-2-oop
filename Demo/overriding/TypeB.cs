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
       
        //static Binding
        // Compilar will bind fun call based on reference type not the object type
        // at compilation time
        
        public new void Fun01() //using new Keyword
        {
            Console.WriteLine("Iam Type B");
        }

        // Must Be Not Private and Virtual
        
        //Dynamic Binding
        //CLR will Bind the Fun Call Based on Object type Not the reference type
        //RunTime

        public override void Fun02() //using override Keyword
        {
            Console.WriteLine($"A: {A} :: B : {B}");
        }

    }
}
