//Declare two variables of type int.
//Assign to them values 5 and 10 respectively.
//Exchange (swap) their values
//and print them.

namespace _13_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;
            int tempNumber1 = number2;
            int tempNumber2 = number1;
            Console.WriteLine(tempNumber1 + " " + tempNumber2);
        }
    }
}