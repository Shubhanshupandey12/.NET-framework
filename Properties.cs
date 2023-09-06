/* 
Properties in C#

Properties in C# provide a flexible mechanism to handle private fields. 
They are named members of classes, structures etc. 
Properties use accessors to read, write or manipulate the values of private fields.

Properties behave like fields when they're accessed. 
However, unlike fields, properties are implemented with accessors that 
define the statements executed when a property is accessed or assigned.

Some of the salient points on properties are given as follows:

1. Properties allow a public way of getting and setting values in a class. 
2. The implementation and verification code is hidden.
3. The get and set accessors are used in properties. 
4. The get accessor returns the property value while a set accessor sets a new value.
5. Some properties have both get and set accessor(read-write).
6. Some have only a get accessor (read only) while some have only a set accessor (write only).
7. The value that is assigned by the set assessor is defined using the value keyword.
 */

using System;
namespace MCA_CSharp
{
    class PropertiesExample
    {
        char _data1;
        public char Data1
        {
            get
            {
                return this._data1;
            }

            set
            {
                this._data1 = value;
            }
        }


        public int Data2 { get; set; }
        /* The syntax shown above is the auto property syntax. 
         * The compiler generates the storage location for the field that backs up the property. 
         * The compiler also implements the body of the get and set accessors.*/

        public int Data3 { get; set; } = 1000;
        /* Sometimes, you need to initialize a property to a value other than the default for its type.*/

        int _data4;
        public int Data4
        {
            get
            {
                if (_data4 > 0)
                    return _data4;
                else
                    throw new ArgumentException("Value must be greater than 0");
            }
            set
            {
                if (this._data4 > 0)
                    this._data4 = value;
                else throw new ArgumentException("Value must be greater than 0");

            }
        }

    }

    class Properties
    {
        static void Main()
        {
            PropertiesExample obj = new PropertiesExample();
            obj.Data1 = 'A';
            obj.Data2 = 100;
            //obj.Data4 = 0;
            Console.WriteLine("Implementing Properties in C#");
            Console.WriteLine("The _data1 value is: {0}", obj.Data1);
            Console.WriteLine("The Data2 value is: {0}", obj.Data2);
            Console.WriteLine("The Data3 value is: {0}", obj.Data3);
            Console.WriteLine("The Data4 value is: {0}", obj.Data4);
            Console.Read();

        }
    }
}