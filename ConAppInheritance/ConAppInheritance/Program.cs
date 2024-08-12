using System;


namespace ConAppInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Emp emp = new Emp() { Id = 1, Name = "Sam" };
            //Console.WriteLine("Employee Details ID: {0} Name: {1}",emp.Id,emp.Name);
            //Dev dev = new Dev() { Id = 2, Name = "Amit", Tech = ".net fullstack", Project = "e-carnival" };
            //Console.WriteLine("Devloper Details ID: {0} Name: {1} Tech: {2} Project: {3}", dev.Id, dev.Name,dev.Tech,dev.Project);
            //Console.ReadKey();
            //Example-2
            //Dev dev= new Dev();
            //Console.WriteLine("Developer Registration");
            //dev.Register();
            //Console.WriteLine("Developer Display");
            //dev.Display();
            //Emp obje=new Emp();
            //Console.WriteLine("Employee Registeration");
            //obje.Register();
            //Console.WriteLine("Employee Display");
            //obje.Display();
            //Console.ReadKey();
            //Example-3
            AppDev appDev = new AppDev();
            appDev.Register();
            appDev.Display();
            Console.ReadKey();
          

        }
    }
}
