using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int daytotal = 0;
            Customer[] c = new Customer[50];
            int[] bills = new int[50];
            for (int w = 0; w < 457; w++)
            {
                Console.WriteLine("if you're the owner press the password or else press enter \n");
                string q = Console.ReadLine();
                if (q == "password")
                {
                    Console.WriteLine("number of items sold today : "+w+"\n");
                    for(int e=0;e<w;e++)
                    {
                        daytotal = 0;
                        daytotal = daytotal + bills[e];
                    }
                    Console.WriteLine("total profits today : "+daytotal);

                }
                else if (q == "poweroff")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("enter your name : ");
                    string a=Console.ReadLine();
                    Console.WriteLine("\n");

                    Console.WriteLine("enter your mobile number : ");
                    string b = Console.ReadLine();
                    Console.WriteLine("\n");

                    c[w] = new Customer(a, b);

                    if (c[w].Ind_bill() != 0)
                    {
                        bills[w] = c[w].Ind_bill();
                    }
                    else
                    {

                    }
                    
                   
                    
                }
            }

        }
    }
    class Customer
    {
        public bool x = true;
        int total = 0;
        string name, ph_number;
        public Customer(string a,string b)
        {
           this.name = a;
           this.ph_number = b;
        }
        public int Ind_bill()
        {
            bool m = false;
            int ch;
            for (int q = 0; q < 67; q++)
            {
                Console.WriteLine("enter your choice from the menu below  :\n\n");
                Console.WriteLine("\n");
                Console.WriteLine("-------------------------MENU------------------------\n\n");
                Console.WriteLine("small coffee         PRESS [ 1 ]-----------------Rs 5/-");
                Console.WriteLine("medium coffee        PRESS [ 2 ]-----------------Rs 10/-");
                Console.WriteLine("large coffee         PRESS [ 3 ]-----------------Rs 15/-");
                Console.WriteLine("extra large coffee   PRESS [ 4 ]-----------------Rs 20/-");
                Console.WriteLine("DONE WITH ORDER      PRESS [ 0 ]");
                Console.WriteLine("\n");
                Console.WriteLine("\n");

                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            total = total + 5;
                            break;
                        }
                    case 2:
                        {
                            total = total + 10;
                            break;
                        }
                    case 3:
                        {
                            total = total + 15;
                            break;
                        }
                    case 4:
                        {
                            total = total + 20;
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("dear " + name + " your bill is " + total + "\n");
                            Console.WriteLine("thankyou and visit again:)");
                            Console.WriteLine("\n");
                            return total;
                        }
                    default:
                        {
                            Console.WriteLine("please enter a valid input !!!! ");
                            break;
                        }
                }
                
            }
            
            return total;
            
        }



    }
}
