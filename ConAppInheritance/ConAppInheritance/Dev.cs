//using System;
//namespace ConAppInheritance
//{
//    public class Dev:Emp
//    {
//        public string Tech { get; set; }
//        public string Project { get; set; }
//    }
//}
using System;
namespace ConAppInheritance
{
    //public sealed class Dev : Emp
    //you can not drive class from a sealed class
    public  class Dev : Emp
    {
        string domain;
        string project;
        public Dev()
        {
            Console.WriteLine("Developer Constructor");
            domain = "not set";
            project = "not assign";
        }
        //public sealed override void Display()
        //sealed means you can not override this method further
        public override  void Display()
        {
            base.Display();
            Console.WriteLine("Domain: \t" + domain);
            Console.WriteLine("Project: \t "+project);
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter Domain");
            domain=Console.ReadLine();
            Console.WriteLine("Enter Project \\(s)");
            project=Console.ReadLine();
        }
    }
}