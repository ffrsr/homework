using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int password1, password2, password3, password4, password5, password6;
            Console.Write("Input password1 :");
            password1 = int.Parse(Console.ReadLine());
            Console.Write("Input password2 :");
            password2 = int.Parse(Console.ReadLine());
            Console.Write("Input password3 :");
            password3 = int.Parse(Console.ReadLine());
            Console.Write("Input password4 :");
            password4 = int.Parse(Console.ReadLine());
            Console.Write("Input password5 :");
            password5 = int.Parse(Console.ReadLine());
            Console.Write("Input password6 :");
            password6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Total password is :{0}{1}{2}{3}{4}{5}", password1, password2, password3, password4, password5, password6);

            string acronym;
            Console.Write("Input acronym :");
            acronym = Console.ReadLine();

            if (acronym == "CIA" ) 
            {
                if (password6 == 3 || password6 == 6 || password6 == 9)
                {
                    if (password5 != 1 && password5 != 3 && password5 != 5)
                    {
                        if (password3 >= 6 && password3 <= 7)
                        {
                            Console.WriteLine("true");
                        }
                        else
                        {
                            Console.WriteLine("false");
                        }                    
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else
                {
                    Console.WriteLine("false");
                }                
            }


            if (acronym == "FBI")
            {
                if (password1 == 4 || password1 == 5 || password1 == 6 || password1 == 7)
                {
                    if (password4 == 0 || password4 == 2 || password4 == 4 || password4 == 8)
                    {
                        if (password2 %2 == 1)
                        {
                            Console.WriteLine("true");
                        }
                        else
                        {
                            Console.WriteLine("false");
                        }
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else
                {
                    Console.WriteLine("false");
                }
            }


            if (acronym == "NSA")
            {
                if (password6 == 1 || password6 == 2 || password6 == 3 || password6 == 5 || password6 == 6)
                {
                    if (password4 == 3 || password4 == 9 )
                    {
                        if (password1 == 7 || password2 == 7 || password3 == 7 || password4 == 7 || password5 == 7 || password6 == 7 )
                        {
                            Console.WriteLine("true");
                        }
                        else
                        {
                            Console.WriteLine("false");
                        }
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else
                {
                    Console.WriteLine("false");
                }
            }


            if (acronym != "CIA" && acronym != "FBI" && acronym != "NSA" )
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();
        }

    }
}
