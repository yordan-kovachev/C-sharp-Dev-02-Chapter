//Write a program
//that prints on the console isosceles triangle
//which sides consist of the copyright character "©".
//https://www.youtube.com/watch?v=rTqBnJ8HrSc  

namespace _11_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            Console.WriteLine("       \x00A9");
            Console.WriteLine("      ©©©");
            Console.WriteLine("     ©©©©©");
        }
    }
}