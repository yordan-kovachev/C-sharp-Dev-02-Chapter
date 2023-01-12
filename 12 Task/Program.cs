//A company dealing with marketing wants to keep a data record of its
//employees.
//Each record should have the following characteristic
//first name,
//last name,
//age,
//gender (‘m’ or ‘f’)
//and unique employee number (27560000 to 27569999).
//Declare appropriate variables needed to
//maintain the information for an employee
//by using the appropriate data types and attribute names.

namespace _12_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string employeFirstName = "Yordan";
            string employeLastName = "Kovachev";
            int employeeAge = 20;
            string employeeGender = "male";
            int employeeUniqueNumber = 27560000;

            object employeeProfile = employeFirstName + "\n"
                + employeLastName + "\n"
                + employeeAge + "\n"
                + employeeGender + "\n"
                + employeeUniqueNumber + "\n";
            Console.WriteLine(employeeProfile);
        }
    }
}