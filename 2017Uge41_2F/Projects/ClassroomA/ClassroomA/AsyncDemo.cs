using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClassroomA
{
    public class AsyncDemo
    {
        public void GUI()
        {
            Console.WriteLine("Start of GUI");
            A();
            Console.WriteLine("End of GUI");
        }

        public void A()
        {
            Console.WriteLine("Start of A");
            B();
            Console.WriteLine("End of A");
        }

        public async Task B()
        {
            Console.WriteLine("Start of B");
            Task t = new Task(() =>
            {
                Console.WriteLine("Start of inside Task");
                Thread.Sleep(5000);
                Console.WriteLine("End of inside Task");
            });
            t.Start();
            t.Wait(); 
            Console.WriteLine("After Start of Task");

            Console.WriteLine("End of B");
        }
    }
}