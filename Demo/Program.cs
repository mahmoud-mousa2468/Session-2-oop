namespace Demo
{
    internal class Program
    {
        static int Sum(int X, int Y)
        {
            return X + Y;
        }
        static double Sum(double X, double Y)
        {
            return X + Y;
        }
        static double Sum(double X, int Y)
        {
            return X + Y;
        }
        static double Sum(int X, double Y)
        {
            return X + Y;
        }
        static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        static void Main(string[] args)
        {
            #region Inheritance
            //Parent parent = new Parent(1, 2);
            ////Console.WriteLine(parent);
            //parent.Fun01();
            //parent.Fun02();

            //Child child = new Child(1, 2, 3);
            //child.Fun01();
            //child.Fun02();
            #endregion
            #region Relation Btw Class
            // Relation Btw Classes
            // 1- Inheritance : is a Relationship
            //FullTimeEmployee--->Employee
            // FullTimeEmployee is a Employee
            // child---- > Parent
            // child is a Parent


            //Child child = new Child(1, 2, 3);

            // 2.Association: has a Relationship
            // Book has a Author
            // Library has a Book

            // 2-1 Composition : has a Relationship
            // 2-2 Aggregation : has a Relationship

            Author author = new Author();
            Book book = new Book(author);
            #endregion
            #region Polymorphism
            //Polymorphism
            // 1 - Polymorphism Methods(Functions) Overloading
            // 2 - Polymorphism Methods(Functions) Overriding

            #region Overloading
            // 1- Polymorphism Methods (Functions) Overloading
            // there are more than one fun (in the same scope[class-struct])
            // these have the same name but with diff signature
            // (count-type-order) parameters
            //Sum(1, 2);
            //Sum(1.4, 4);
            //Sum(3, 4.5);
            //Sum(1, 5, 8);
            #endregion
            #region Overriding
            // 2 - Polymorphism Methods(Functions) Overriding
            //there are more than one function [in diff class] these have the same name and 
            //the same signature but with diff behaviour
            //TypeB typeB = new TypeB() { A = 1, B = 2 };
            //typeB.A = 1;
            //typeB.B = 2;
            //typeB.Fun01();
            //typeB.Fun02();

            #endregion
            #endregion
            #region Binding
            //what is binding?
            //referenceFrom Parent---> Object child

            //TypeA Ref;
            //Ref = new TypeA();
            //Ref = new TypeB();
            // cause child is a parent
            // TypeB is a TypeA
            //Ref = new TypeB();

            //Ref.A = 12;
            //Ref.B = 13; // will give u error cause this reference will access the part of
            // class TypeA from Class TypeB

            //Ref.Fun01(); //static binding
            //Ref.Fun02();
            #endregion
            #region BindingEx

            //TypeA typeA;
            //typeA = new TypeA();
            //typeA = new TypeB(); // TypeA is a Parent Of TypeB
            //typeA = new TypeD(); // TypeA is a Indirect Parent Of TypeD

            //TypeA typeA = new TypeD();

            //typeA.A = 12;
            //typeA.B = 12; // error cause can't see B
            //typeA.C = 12; // error cause can't see C
            //typeA.D = 12; // error cause can't see D

            //typeA.Fun01(); // static binding so run the fun01 of the parent (typeA)
            //typeA.Fun02(); // dynamic binding so run the fun02 of the type object (typeD)
            //               // but we change override keyword to new keyword so run the fun02 of the typeC

            #endregion
            #region Task
            //private Access is limited to the containing type.
            //public Access is not restricted.
            //internal Access is limited to the current assembly.
            //protected The code is accessible within the same class, or in a class that is inherited from that class.
            //protected internal Access is limited to the current assembly or types derived from the containing class.
            //private protected Access is limited to the containing class or types derived from the containing class within the current assembly.

            #endregion
        }
    }
}
