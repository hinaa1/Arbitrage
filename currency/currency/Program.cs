using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Rupees");
            //double r = double.Parse(Console.ReadLine());
            
            //double dollar = 122, canada = 90.23, pound = 158.03 ,dinar =394.27 , darham = 32.49 , euro= 138.53, riyal = 31.53,yuan =18.53,aus =88.57;
            //double result=0;
            //Console.WriteLine("1 : Dollar");
            //Console.WriteLine("2 : Canada");
            //Console.WriteLine("3 : Pound");
            //Console.WriteLine("4 : Dinar");
            //Console.WriteLine("5 : Darham");
            //Console.WriteLine("6 : Euro");
            //Console.WriteLine("7 : Riyal");
            //Console.WriteLine("8 : Australian");
            //Console.WriteLine("9 : Yuan ");
            //string sel = Console.ReadLine();
            //string flag = "";
            //if (sel == "1")
            //{
            //    flag = "Dollar";
            //    result = r / dollar;
            //}
           
            //else if (sel == "2")
            //{
            //    flag = "Canada";
            //    result = r / canada;
            //}
          
            //else if (sel == "3")
            //{
            //    flag = "Pound";
            //    result = r / pound;
            //}

            //else if (sel == "4")
            //{
            //    flag = "Dinar";
            //    result = r / dinar;
            //}
            //else if (sel == "5")
            //{
            //    flag = "Darham";
            //    result = r / darham;
            //}
            //else if (sel == "6")
            //{
            //    flag = "Euro";
            //    result = r / euro;
            //}
            //else if (sel == "7")
            //{
            //    flag = "Riyal";
            //    result = r / riyal;
            //}
            //else if (sel == "8")
            //{
            //    flag = "Australian";
            //    result = r / aus;
            //}
            //else if (sel == "9")
            //{
            //    flag = "yuan";
            //    result = r / yuan;
            //}
                
            //else
            //{
            //    Console.WriteLine("incorrect Input");
            //}
            //Console.WriteLine(flag +" = " +result);
            //string h = Console.ReadLine();
            Console.WriteLine("enter 1st Country curency");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd Country curency");
            double secound = double.Parse(Console.ReadLine());
            Console.WriteLine("enter 3rd Country curency");
            double third = double.Parse(Console.ReadLine());
            int mul = Convert.ToInt32(first * secound-10);
            Console.WriteLine();
            Console.WriteLine("your Cross Rate : "+ first*secound);
            double temp = third * first;
            double temp2 = temp / mul;
            double temp3 = temp2 * secound;
            Console.WriteLine();
            Console.WriteLine("Your Profit : " + (temp3-third));

        }
    }
}
