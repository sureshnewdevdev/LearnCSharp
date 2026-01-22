using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    //public class SomeClass
    //{
    //    private int _id;

    //    public int Id 
    //    {
    //        get 
    //        {
    //            if (Id < 5)
    //            {
    //                Console.WriteLine("Invalid");
    //            }
    //            //throw new InvalidOperationException();
    //            //Console.WriteLine("I am here");
    //            return Id;
    //        }
    //        set
    //        {
    //            _id = value;
    //        }
    //    }
    //}
    public class ThreadingExample
    {
        public static async Task AsyncMethod()
        {
            //SomeClass someClass = new SomeClass();
            //someClass.Id = 1;
            //Console.WriteLine(someClass.Id);


            Console.ReadLine();
            //Console.WriteLine("Task started");
            //await Task.Delay(3000); // Non-blocking delay
            //Console.WriteLine("Task completed after 3 seconds");
        }

        public async void CallMethod()
        {
            string result = await FetchDataAsync("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(result);
            await AsyncMethod();

        }


        //public async Task<string> FetchDataAsync(string url)
        //{

        //}

        //public async void FetchDataAsync(string url)
        //{

        //}
        // Usage
        public async Task<string> FetchDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                return response;
            }
        }
        public static void Main(string[] args)
        {
            ThreadingExample threadingExample = new ThreadingExample();
            threadingExample.CallMethod();

            

            //Thread t1 = new Thread(Task1);
            //Thread t2 = new Thread(Task2);
            //t1.Start();
            //t2.Start();



            Console.ReadLine();
        }

        private static void Task1()
        {
            Console.WriteLine("For loop for even started");
            for (int i = 0; i < 100; i += 2)
            {
                Thread.Sleep(100);
                Console.Write( i + " *  ");
            }
        }

        private static void Task2()
        {
            Console.WriteLine("For loop for odd started");

            for (int i = 1; i < 100; i += 2)
            {
                Thread.Sleep(100);
                Console.Write(i + "  ");
            }
        }
    }
}
