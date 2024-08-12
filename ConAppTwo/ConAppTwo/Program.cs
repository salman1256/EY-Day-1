using System;
namespace ConAppTwo
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClassName objectname=new ClassName();
            //ojbectName.MemberName
            //objectName.MethodName(arguments);

            //Employee employee = new Employee();
            //Employee employee2 = new Employee();

            //employee.Register();
            //Console.WriteLine("*** Employee One Details ***");
            //employee.Display();
            //Console.WriteLine("*** Employee Two Details *** ");
            //employee2.Display();
            //Console.ReadKey();

            //Example-2
            Employee employee = new Employee();
            Employee obj = new Employee(12,"Sandeep",98000.76);
            obj.Display();
            employee.Display();
            Console.ReadKey();
        }
    }
}
