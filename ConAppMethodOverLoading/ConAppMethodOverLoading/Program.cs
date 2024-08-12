using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethodOverLoading
{
    public class OurClass
    {
        public void Display()
        {
            Console.WriteLine("Display Method of Our Class");
        }
        public void Display(string name)
        {
            Console.WriteLine("Welcome to Display Mr.\\Ms. "+name);
        }
        public void Display(int id)
        {
            Console.WriteLine("Welcome to Display Roll Number . " + id);
        }
        public void Increment(int num)
        {
            Console.WriteLine("Value before increment is "+num);
            num++;
            Console.WriteLine("Value after increment is "+num);
        }
        public void Increment( ref int num)
        {
            Console.WriteLine("Value before increment is " + num);
            num++;
            Console.WriteLine("Value after increment is " + num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass ourClass = new OurClass();
            ourClass.Display("Sam");
            int num = 12;
            ourClass.Increment(ref num);
            Console.WriteLine("after Method call value of num is : "+num);
            Console.ReadKey();
        }    }
}
