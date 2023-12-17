using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0 ; i<100; i++){
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Hello World! \n");
            }
            
        }
    }
}
