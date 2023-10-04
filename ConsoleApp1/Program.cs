using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal class asd1
{
    [DllImport("Dll2.dll")]
    public static extern int asd();
    int a=0;
    int b = 3;
    int c = 4;
   
    public static void sf()
    {
        Task hj=new Task(new Action(() => { Console.WriteLine("45678"); }));
        hj.Start();
       
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
        
        int a = 42;
            int b = 119;
            int c = a + b;
        Thread t=new Thread(new ThreadStart(delegate(){ Console.WriteLine(c+"123");}));
        t.Start();
        asd1 hj=new asd1();
        Console.Write(asd1.asd() + "\n");
        Console.Read();
        }
    }

