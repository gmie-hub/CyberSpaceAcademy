using System;

namespace ClassLearning
{

    public interface ICompress
    {
        void Write();
    }
    public interface IStore: ICompress
    {
        void Write();
    }




    public class MyClass: IStore
    {

        public void Write()
        { }

        void ICompress.Write()
        {

        }
    }

    //QUESTION 131: An Interface provides a contract specifying how to create an Object, 
    //without caring about the specifics of how they do the things.
    //An Interface is a reference type and it includes only abstract members such as Events, Methods, 
    //Properties etc.and it has no implementations for any of its members.
    //When a Class implements an Interface, they are forced by the compiler to write the methods and 
    //Properties that the Interface has defined.That is, if you implement an Interface in your Class 
    //you have to declare all of the Interface's Events, Methods, Properties in your Class. 
    //An Interface can have only Abstract methods and Constants , which are always implicitly public, static, and final.

    //QUESTION 132: An abstract base class is a way to achieve the abstraction in C#. 
    //An Abstract base class is never intended to be instantiated directly. 
    //This class must contain at least one abstract method, which is marked by the keyword or modifier 
    //abstract in the class definition. 
    //The Abstract classes are typically used to define a base class in the class hierarchy.
    //An interface can have methods, properties, events, and indexers as its members.But interfaces 
    //will contain only the declaration of the members.
    //The implementation of interface’s members will be given by the class who implements 
    //the interface implicitly or explicitly.

    //QUESTION 134: The 'is' and 'as' operator

    //QUESTION 135: The 'is' operator is used to check if the run-time type of an object is compatible with the given type or not, 
    //whereas the 'as' operator is used to perform conversion between compatible reference types or nullable types.

    //QUESTION 136: You can extend an existing interface to add new methods or members.For example, 
    //you might extend ICompressible with a new interface, 
    //ILoggedCompressible, which extends the original interface with methods to keep track of the bytes saved.

    //QUESTION 137:    public interface IMyInterfaceB: IMyInterfaceA
		  //         {
    //   			     
		  //         }

    //QUESTION 138: An implementing class is free to mark any or all of the methods that implement the interface as virtual. 
    //Derived classes can override or provide new implementations.
    //For example, a Document class might implement the IStorable interface and mark the Read() and Write() methods as virtual. 
    //The Document might Read() and Write() its contents to a File type.
    //The developer might later derive new types from Document, such as perhaps a Note or EmailMessage type, 
    //and he might decide that Note will read and write to a database rather than to a file.

    //QUESTION 139: Explicitly telling the compiler that a particular member belongs to that particular 
    //interface is called Explicit interface implementation. 
    //If a class implements from more than one interface that has methods with the same signature then the call to such a method 
    //will implement the same method and not the interface-specific methods.
    //This will defeat the whole purpose of using different Interfaces.
    //That is when Explicit implementation comes into the picture.
    //Using explicit implementation you can tell the compiler which interface’s method you are Overloading and 
    //can provide different functionalities for methods of different interfaces.
    //The same is the case for any other type of member like a property, event.

    public interface IConvertible
    {

        public string ConvertToCSharp(string bill);
        public string ConvertToVB2005(string bill);
    }

    public class ProgramHelper : ProgramConverter, IEveryOne
    {

        public bool CodeCheckSyntax(string stringToCheck, string langToUse)
        {

            if (langToUse == "CSharp")
            {
                Console.WriteLine($"Check if the string '{stringToCheck}' is in C#.");
                return true;
            }
            else if (langToUse == "VB2005")
            {

                Console.WriteLine($"Check if the string '{stringToCheck}' is in VB2005.");
                return true;
            }

            return false;
        }
    }

    public interface IEveryOne : IConvertible
    {

        public bool CodeCheckSyntax(string stringToCheck, string langToUse);
    }

    public class ProgramConverter : IConvertible
    {

        public string ConvertToCSharp(string bill)
        {

           return $"{bill} converted to C#";
        }

        public string ConvertToVB2005(string bill)
        {
            return $"{bill} converted to VB2005";
        }
    }
       

  
    public class Program
    {
        static void Main()
        {
            
            ProgramHelper programHelper = new ProgramHelper();
            string cSharpString = programHelper.ConvertToCSharp("This string");
            string vbString = programHelper.ConvertToVB2005("Any string");

            //Implementing Exercise 13-2 and 13-3
            Console.WriteLine(cSharpString);
            Console.WriteLine(vbString);

            programHelper.CodeCheckSyntax(cSharpString, "CSharp");
            programHelper.CodeCheckSyntax(vbString, "VB2005");

            //Testing the 'is' and 'as' keyword
            ProgramConverter[] programConverters = new ProgramConverter[2];
            programConverters[0] = new ProgramConverter();
            programConverters[1] = new ProgramHelper();

            //Demostrating the 'is' keyword
            for (int i = 0; i < programConverters.Length; i++)
            {

                Console.WriteLine(programConverters[i] is ProgramHelper);
            }

            //Demostrating the 'as' keyword
            for(int i = 0; i < programConverters.Length; i++)
            {

                ProgramHelper programHelper1 = programConverters[i] as ProgramHelper;
                if (programHelper1 != null)
                {
                    programHelper1.CodeCheckSyntax(vbString, "VB2005");
                }
                else Console.WriteLine("Not VB syntax");

                if (programHelper1 != null)
                {

                    programHelper1.CodeCheckSyntax(cSharpString, "CSharp");
                }
                else Console.WriteLine("Not C# syntax");
            }
        }
    }

   
}
