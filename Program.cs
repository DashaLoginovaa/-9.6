using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практ9._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[] 
            {
                new IndexOutOfRangeException(),
                new MyOwnException("ошибочка"),
                new ArgumentOutOfRangeException(),
                new KeyNotFoundException(),
                new InvalidOperationException()
            };
            
                foreach (var exception in exceptions) 
                {
                    try 
                    {
                        throw exception;
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                    }

                }
            
        }
    }
    public class MyOwnException : Exception
    {
        public MyOwnException (string message): base (message) { }
    }
}
