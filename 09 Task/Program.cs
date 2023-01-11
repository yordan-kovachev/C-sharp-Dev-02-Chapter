//Declare two variables of type string
//and assign them a value “The "use" of quotations causes difficulties.”
//(without the outer quotes).
//In one of the variables use quoted string
//and in the other do not use it.

namespace _09_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string solution1 = "The \"use\" of quatations causes difficulties.";
            string solution2 = @"The 'use' of quatations causes difficulties.";
            Console.WriteLine("THis is an escaped string: " + solution1);
            Console.WriteLine("This is a verbatime string: " + solution2);
        }
    }
}