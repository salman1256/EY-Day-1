using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //objectName.Property
            //static : ClassName.Property
            // Product objPro = new Product(1);
            // Console.WriteLine("Enter Product Name");
            // objPro.Name=Console.ReadLine();
            // Console.WriteLine("Enter Product Price");
            // objPro.Price=double.Parse(Console.ReadLine());
            // Console.WriteLine("Enter Tax");
            //Product.Tax=double.Parse(Console.ReadLine());

            // //objPro.Id=Console.ReadLine(); It's readonly you can not change it

            // Product objPro2 = new Product(5);
            // Console.WriteLine("Enter Product Name");
            // objPro2.Name = Console.ReadLine();
            // Console.WriteLine("Enter Product Price");
            // objPro2.Price = double.Parse(Console.ReadLine());
            // Console.WriteLine($"Product Id {objPro.Id} \t Product Name: {objPro.Name} \t Price: {objPro.Price} \t Tax {Product.Tax}");
            // Console.WriteLine($"Product Id {objPro2.Id} \t Product Name: {objPro2.Name} \t Price: {objPro2.Price} \t Tax {Product.Tax}");

            // Console.ReadKey();

            //Example -2
            Product obj = new Product();
            Console.WriteLine("Enter Product Name");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Enter Product Id");
            obj.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("***** Product Details as follows *****");
            Console.WriteLine("Product Id {0} \t Product Name: {1} ",obj.Id,obj.Name);
           

            Console.ReadKey();

        }
    }
}
//Method Overloading
