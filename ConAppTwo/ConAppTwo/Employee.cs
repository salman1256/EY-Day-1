using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppTwo
{
    //[A.S.] [Mod] class <ClassName>:[BaseClass]
    //{Members of Class}
    //constructor,method,property,fields,events,delegates
    //[A.S.] returntype MethodName (parameters) {//Body of Method}
    public class Employee
    {
        //int id;
        //string name;
        //double salary;

        //public  Employee()
        // {
        //     Console.WriteLine("*** Constructor Call ***");
        //     id = -1;
        //     name = "not given";
        //     salary = 0;
        // }
        // public void Register()
        // {
        //     Console.WriteLine("Enter Employee Id");
        //     id=int.Parse(Console.ReadLine());
        //     Console.WriteLine("Enter Employee Name");
        //     name=Console.ReadLine();
        //     Console.WriteLine("Enter Employee Salary");
        //     salary=double.Parse(Console.ReadLine());    
        // }
        // public void Display()
        // {
        //     Console.WriteLine("Employee ID: \t" + id);
        //     Console.WriteLine("Employee Name: \t" + name);
        //     Console.WriteLine("Employee Salary: \t" + salary);
        // }
        //Example-2
        int id;
        string name;
        double salary;
        public Employee()
        {
            Console.WriteLine("Default Constructor");
           
        }
        public Employee(int _id,string _name,double _salary)
        {
            //this.id = id;
            //this.name = name;   
            //this.salary = salary;
            //this. id=id;
            //this.name=name;
            //this.salary=salary;
            id= _id;
            name= _name;
            salary= _salary;
        }
        public void Display()
        {
            Console.WriteLine("Employee ID: \t" + id);
            Console.WriteLine("Employee Name: \t" + name);
            Console.WriteLine("Employee Salary: \t" + salary);
        }

    }
}
