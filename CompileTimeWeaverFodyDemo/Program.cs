using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimeWeaverFodyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCompileTimeWeaverFody();
            Console.ReadLine();
        }

        [TimeIt]
        private static void TestCompileTimeWeaverFody()
        {
            Console.WriteLine("Sleeping for 5 seconds");
            System.Threading.Thread.Sleep(5000);
            try
            {
                throw new NullReferenceException();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception message: "+ ex.Message);
            }
        }
    }
}
