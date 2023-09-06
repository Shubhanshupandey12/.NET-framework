using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Class1
    {
        public void fun1()
        {
            Console.WriteLine("New Class");
            Console.WriteLine("Class Updated");

        }
        protected void fun2()
        {
            Console.WriteLine("Protected Class");
            Console.WriteLine("Class Updated");
        }
    }
    internal class Class2
    {
        public void fun2() { }
    }
    public class Class3
    {
        public void fun3() { }
        private void fun4() { }
        protected void fun5() { }
        internal void fun6() { }
        protected internal void fun7() { }
        private protected void fun8() { }
    }
}
