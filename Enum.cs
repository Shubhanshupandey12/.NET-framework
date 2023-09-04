/*
 * Enums in C# *
The enum keyword in C# declares a list of named integer constants. 
An enum can be defined in a namespace, structure or class. 
However, it is better to define it in a namespace so that all the classes can access it.

*Enum Syntax*
The syntax for an enum is given as follows:

enum NameOfEnum
{
    // The enumerator list
};
The keyword enum is used to create an enumeration with the name NameOfEnum.
Then the enumeration list is available within curly braces in the enum body. 
The value of the first identifier in the enumerator list is zero by default.
*/

using System;
namespace EnumDemo
{
    class Example
    {
        enum Months
        {
            January = 1, February, March, April,
            May, June, July, August = 108,
            September, October, November, December
        };
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("The {0}th month of the year is {1}", (int)Months.August, Months.August);

            foreach (Months e in Enum.GetValues(typeof(Months)))
            {
                count++;
                Console.Write("Month " + (int)e + "...");
                Console.WriteLine(e);
            }
            Console.Read();
        }
    }
}
