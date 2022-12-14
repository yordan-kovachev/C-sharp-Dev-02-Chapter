//Декларирайте няколко променливи, като изберете за всяка една найподходящия от типовете sbyte, byte, short, ushort, int, uint, long и
//ulong, за да им присвоите следните стойности: 52130, -115, 4825932,
//97, -10000, 20000; 224; 970700000; 112; -44; -1000000; 1990;
//123456789123456789

using System.Reflection.Metadata.Ecma335;

namespace _01_Task
{
    internal class Program
    {
        ushort a = 52130; //range 0 to 65535
        sbyte b = -115; //range -128 to 127
        int c = 4825932; //range from -2Bill to 2 bill ish
        sbyte d = 90; 
        short e = -10000;

        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}