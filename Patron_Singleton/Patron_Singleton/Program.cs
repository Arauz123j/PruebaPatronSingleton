using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromTeachaer = Singleton.GetInstance;
            fromTeachaer.PrintDetails("Del porefesor");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("Del estudiante");
            Console.ReadLine();
        }
    }
}

