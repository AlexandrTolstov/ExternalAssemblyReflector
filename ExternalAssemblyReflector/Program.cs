using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.IO;

namespace ExternalAssemblyReflector
{
    class Program
    {
        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine("\n******* Types in Assembly ********");
            Console.WriteLine("->{0}", asm.FullName);
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
                Console.WriteLine("Type: {0}", t);
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("******* External Assemly Viewer *******");
            string asmName = "";
            Assembly asm = null;
            do
            {
                Console.WriteLine("\nEnter an assebly to evaluate");
                Console.WriteLine("or enter Q to quit: ");
                asmName = Console.ReadLine();
                if(asmName.ToUpper() == "Q")
                {
                    break;
                }
                try
                {
                    asm = Assembly.LoadFrom(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find assembly.");
                }
            } while (true);
        }
    }
}
