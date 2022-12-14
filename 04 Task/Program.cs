﻿//Инициализирайте променлива от тип int със стойност 256 
//в шестнадесетичен формат (256 е 100 в бройна система с основа 16)

//Why is hexadecimal base 16 ?
//The word “Hexadecimal” means sixteen because this type of digital numbering 
//    system uses 16 different digits from 0-to-9, and A-to-F. 
//    Hexadecimal Numbers group binary numbers into sets of four digits.

namespace _04_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decNum = 0;

            int i = 0;
            int rem = 0;

            string hexNum = "";

            Console.Write("Enter a Decimal Number: ");
            decNum = int.Parse(Console.ReadLine());

            while (decNum != 0)
            {
                rem = decNum % 16;
                if (rem < 10)
                    rem += 48;
                else
                    rem += 55;

                hexNum += Convert.ToChar(rem);
                decNum = decNum / 16;
            }

            Console.Write("Hexa-decimal number: ");
            for (i = hexNum.Length - 1; i >= 0; i--)
                Console.Write(hexNum[i]);

            Console.WriteLine();
        }
    }
}