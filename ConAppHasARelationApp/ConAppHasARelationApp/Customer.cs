using System;
namespace ConAppHasARelationApp
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public void Display() 
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Customer Address: {Address}");
        }
    }
}
