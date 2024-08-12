using System;
namespace ConAppInheritance
{
    public class AppDev:Dev
    {
        string osType;
        public AppDev()
        {
            Console.WriteLine("App Developer Constructor!!!");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Operating System Type is : "+osType);
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter Operating System Type");
            osType = Console.ReadLine();
        }
    }
}
