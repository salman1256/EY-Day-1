using System;
namespace ConAppHasARelationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address() 
            { House = "F-123", City = "Delhi",
                Region = "Delhi", 
                PostalCode = "110025", Country = "India" };
            Customer customer = new Customer()
            {
                CustomerId = 1,
                Name = "Sam",
                Address = address,
            };
            customer.Display();
            Console.ReadKey();
        }
    }
}
