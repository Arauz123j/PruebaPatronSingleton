using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{

    // se crea una instancia llamada singleton
    public sealed class Singleton
    {
        // se crean propiedades privadas
        private static int contar = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
         
        private Singleton()
        {
            contar++;
            Console.WriteLine("Contar valor " + contar.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
