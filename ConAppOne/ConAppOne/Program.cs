using System;

namespace ConAppOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datatype variable 
            string userName;
            int age;
            double salary;
            char grade;
            DateTime doj;
            Console.WriteLine("Enter User Name");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            //DataType.Parse(Console.ReadLine())
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary=double.Parse(Console.ReadLine());
           Console.WriteLine("Enter Grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            doj= DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\n Name: \t"+userName +"\n  Grade: \t"+grade +"\n Age: \t"+age +"\n Salary: \t"+salary +"\n Date of Joining: \t"+doj.ToShortDateString());
           
            Console.WriteLine($"\n Name: {userName} \n  Grade: \t {grade} \n Age: \t {age}\n Salary:{salary} \n Date of Joining: \t{doj}");
            Console.WriteLine
           ("\t *** ** \t Welcome {0} \t *** ** \n Name: {0} \n  Grade: \t {1} \n Age: \t {2}\n Salary:{3} \n Date of Joining: \t{4}",userName,grade,age,salary,doj);
            Console.ReadKey();
        }
    }
}
