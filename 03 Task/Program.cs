//Напишете програма, която сравнява вярно две реални числа с
//точност до 0.000001

//

namespace _03_Task
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(1.1 == 1.1);
            Console.WriteLine(1.1 == 1.1f);
            Console.WriteLine(0.3 == 0.3);
            var a = 0.15 + 0.15;
            var b = 0.1 + 0.2;
            Console.WriteLine(a == b);
            Console.WriteLine(0.15 + 0.15 == 0.1 + 0.2);
            var isAGreaterThanB = (a + 1e-15) >= b;
        }
    }
}