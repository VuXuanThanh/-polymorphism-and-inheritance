using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Person
    {
        private string name;
       
        private  void output()
        {
            Console.WriteLine("Name is " + name);
        }
        private static void doSomething(string job)
        {
            Console.WriteLine("Job is " + job);
        }
        private void run()
        {
            Console.WriteLine("sdbsjbds");
        }
        private void work()
        {
            doSomething("doctor");
            output();
        }
        class People
        {
            public void logging()
            {
                doSomething("employee");
            }
        }
    }
    class Student
    {
       public static void Main(string[] args)
        {
            Person tom = new Person();

            
            

        }
    }
       
    
}
