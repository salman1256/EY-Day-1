using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

//namespace ConAppProperties
//{
//    //[A.S.][Mod] DataType PropertyName {get { return ;} set { value }}
//    //get,or set
//    //1.Read Only  get
//    //2.Write Only set
//    //3.Read/Write  get,set
//    //4.abstract
//    //5.static
//    //6.AutoImplemented
//   public  class Product
//    {
//        int id;
//        string name;
//        double price;
//        static double tax=10.0;
//        public Product(int pid)
//        {
//            id = pid;
//        }

//        public int Id { get { return id; } }
//        public string Name { get { return name; }  set { name = value; } }
//        public double Price { get { return price; } set { price = value; } }
//        public static double Tax { get {  return tax; } set { tax = value; } }
//    }
//}
//Example-2
using System.Threading.Tasks;

namespace ConAppProperties
{
    public class Product
    {
        int id;
        string name;
        public int Id
        {
            get {
                if (id !=-1)  { return id; }
                else { Console.WriteLine("Invalid ID");
                    return id; 
                }
            }
            set
            {
                if (value >= 1)
                { id = value; }
                else { id = -1; }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if ((value.Length >= 6) && (value.Length <= 50))
                {
                    name = value;
                }
                else
                {
                    name = "Invalid Product  Name";
                }
            }

        }
    }
}
