using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number from the menu below ");
            Console.WriteLine("    1--> Crismas Tree");
            Console.WriteLine("    2--> Butterfly");
            Console.WriteLine("    3--> Triangle");
            Console.WriteLine("    4--> Square");
            Console.WriteLine("    5--> Rhomb");
            try
            {
                int i = 0; i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        CrismasTree();
                        break;
                    case 2:
                        Butterfly();
                        break;
                    case 3:
                        Triangle();
                        break;
                    case 4:
                        Square();
                        break;
                    case 5:
                        Rhomb();
                        break;
                    default:
                        Console.WriteLine("    ** Enter a number from 1 to 3 **");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("    ** Enter a number **");
                throw;
            }
            static void CrismasTree()
            {
                Console.WriteLine("          *");
                for (int b = 1; b <= 4; b++)
                {
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
                for (int b = 2; b <= 4; b++)
                {
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
                for (int b = 2; b <= 4; b++)
                {
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("         ^$^");
                Console.WriteLine("         ^$^");
                Console.WriteLine("         ^$^");
                Console.WriteLine("        ^^$^^");
            }
            static void Butterfly()
            {
                for (int b = 1; b <= 4; b++)
                {
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write("# ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("         # #");
                for (int b = 1; b <= 4; b++)
                {
                    for (int a = 4; a >= b; a--)    //decreasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 1; a <= b; a++)   //increasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 1; a <= b; a++)   //increasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing triangle
                    {
                        Console.Write("# ");
                    }
                    Console.WriteLine();
                }
            }
            static void Rhomb()
            {
                Console.WriteLine("          #");
                for (int b = 1; b <= 4; b++)
                {
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle

                    {
                        Console.Write(" #");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(" # # # # # # # # # #");
                for (int b = 1; b <= 4; b++)
                {
                    for (int a = 1; a <= b; a++)   //increasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing shape
                    {
                        Console.Write(" #");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing shape
                    {
                        Console.Write(" #");
                    }
                    for (int a = 1; a <= b; a++)   //increasing space
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("          #");
            }
            static void Square()
            {
                for (int b = 1; b <= 4; b++)
                {
                    for (int a = 1; a <= 4; a++)
                    {
                        Console.Write(" #");
                    }
                    Console.WriteLine();
                }
            }
            static void Triangle()
            {
                Console.WriteLine("          #");
                for (int b = 1; b <= 4; b++)
                {
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 1; a <= b; a++)   //increasing triangle
                    {
                        Console.Write(" #");
                    }
                    for (int a = 4; a >= b; a--)    //decreasing space
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
            }
            /*
                        // triangle
                        for (int b = 1; b <= 4; b++)       //row
                        {
                            for (int a = 1; a <= b; a++)   //column
                            {
                                Console.Write(" #");
                            }
                            Console.WriteLine();
                        }
            */
        }
    }
}



