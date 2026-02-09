using System;

namespace CADelegate
{
    //dotnet run  Program.cs   


    //delegate void MDelegate();
    //Action, Func, Pred
    internal class Program
    {
        static void Main(string[] args)
        {
            // M2(M1);

            // Action action = M1;
            // M2(action);
             
             Action action = M3;
             M(action);

            Console.ReadKey();
        }

        // static void M1()
        // {
        //     Console.WriteLine("M1");
        // }

        static void M3()
        {
            Console.WriteLine("hi iam aya  ");
        }

        // static void M2(Action action)
        // {
        //     action();
        //     Console.WriteLine("M2");
        // }

          static void M(Action action)
        {
            action();
            Console.WriteLine("M3");
        }
    }


}
