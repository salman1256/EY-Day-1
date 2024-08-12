﻿//using System;


//namespace ConAppInheritance
//{
//    public class Emp
//    {        
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string  Qualification { get; set; }
//    }
//}
using System;
namespace ConAppInheritance
{
    public class Emp
    {
        int id;
        string name;
        string qual;
        public Emp()
        {
            Console.WriteLine("Employee Constructor");
            id = 1;
            name = string.Empty;
            qual = string.Empty;
        }
        public virtual void Display()
        {
            Console.WriteLine("ID: \t"+id);
            Console.WriteLine("Name: \t" + name);
            Console.WriteLine("Qualification: \t" + qual);
        }
        public virtual void Register()
        {
            Console.WriteLine("Enter Id");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name=Console.ReadLine();
            Console.WriteLine("Enter Qualification");
            qual=Console.ReadLine();
        }
    }
}
