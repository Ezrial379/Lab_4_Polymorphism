using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Printer printer = new Printer();
            printer.Print();


            Printer printer1 = new Printer_R();
            printer1.Print();


            Printer printer2 = new Printer_G();
            printer2.Print();

            Printer printer3 = new Printer_B();
            printer3.Print();


        }
    }





    class Printer
    {

        public string Value;

        public virtual void Print()
        {
            Value = "\nPrinted in usual color \n";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Value);
        }

    }


    class Printer_R : Printer
    {


        public override void Print()
        {
            Value = "\nPrinted in red color \n";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Value);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }


    class Printer_G : Printer
    {

        public override void Print()
        {
            Value = "\nPrinted in green color \n";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Value);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }



    class Printer_B : Printer
    {

        public override void Print()

        {

            Value = "\nPrinted in blue color \n";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Value);
            Console.ForegroundColor = ConsoleColor.White;

        }

    }

}
