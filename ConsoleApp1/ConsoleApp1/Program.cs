using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle _rectangle = new Rectangle();
            int ilength = -1, iwidth = -1, temp;
            Console.WriteLine("Assignment 2");
            while (ilength < 0)
            {
                Console.WriteLine("Enter the length:");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp > 0)
                        ilength = temp;
                }
            }
            while (iwidth < 0)
            {
                Console.WriteLine("Enter the width:");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp > 0)
                        iwidth = temp;
                }
            }

            _rectangle = new Rectangle(iwidth, ilength);
            int menu_option = 0;
            Console.Clear();
            while (menu_option != 7)
            {
                Console.Clear();
                Console.WriteLine("1.Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Choose any option");

                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp == 7)
                        return;
                    menu_option = temp;
                    int tempo;
                    switch (menu_option)
                    {
                        case 1:
                            Console.WriteLine("Length: " + _rectangle.GetLength().ToString());
                            break;
                        case 2:
                            ilength = -1;
                            while (ilength < 0)
                            {
                                Console.WriteLine("Enter new length");
                                if (int.TryParse(Console.ReadLine(), out tempo))
                                {
                                    if (tempo > 0)
                                        ilength = tempo;
                                }
                            }
                            _rectangle.SetLength(ilength);
                            break;
                        case 3:
                            Console.WriteLine("width: " + _rectangle.GetWidth().ToString());
                            break;
                        case 4:
                            iwidth = -1;
                            while (iwidth < 0)
                            {
                                Console.WriteLine("please Enter a new length");
                                if (int.TryParse(Console.ReadLine(), out tempo))
                                {
                                    if (tempo > 0)
                                        iwidth = tempo;
                                }
                            }
                            _rectangle.SetWidth(iwidth);
                            break;
                        case 5:
                            Console.WriteLine("Perimeter: " + _rectangle.GetPerimeter().ToString());
                            break;
                        case 6:
                            Console.WriteLine("Area: " + _rectangle.GetArea().ToString());
                            break;

                    }
                    Console.WriteLine("Press any Key to Continue");
                    Console.ReadLine();
                }

            }

        }
    }
}