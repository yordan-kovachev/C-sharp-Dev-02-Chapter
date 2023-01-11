//Декларирайте две променливи от тип string
//и им присвоете стойности "Hello" и "World".
//Декларирайте променлива от тип object и ѝ присвоете
//стойността на конкатенацията на двете променливи от тип string
//(не изпускайте интервала по средата).
//Декларирайте трета променлива от тип string
//и я инициализирайте със стойността на променливата от тип object.

namespace _08_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting1 = "Hello";
            string greeting2 = "World";
            object mainGreeting = greeting1 + " " + greeting2;
            string greeting3 = mainGreeting.ToString();
            Console.WriteLine("");
        }
    }
}