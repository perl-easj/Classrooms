using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClassroomB
{
    public class AsyncDemo
    {
        public async void DoDemo()
        {
            Console.WriteLine("Before PrepareGUIAsync");

            PrepareGUIAsync();  // await venter jo...

            Console.WriteLine("After PrepareGUIAsync");
            Console.WriteLine("Before RunGUI");

            RunGUI();

            Console.WriteLine("After RunGUI");
        }

        public async Task PrepareGUIAsync()
        {
            Console.WriteLine("Before await of DoA");

            await DoA();

            Console.WriteLine("After await of DoA");
            Console.WriteLine("Before await of DoB");

            await DoB();

            Console.WriteLine("After await of DoB");

            UpdateGUI();
        }

        public void RunGUI()
        {
            Console.WriteLine("Inside call of RunGUI");

            bool userIsDone = false;
            while (!userIsDone)
            {
                Console.Write("Type someting (c to Cancel): ");
                string input = Console.ReadLine();
                Console.WriteLine("You typed " + input);
                userIsDone = (input == "c");
            }
        }

        private async Task DoA()
        {
            Console.WriteLine("Starting A...");
            await Wait(15000);
            Console.WriteLine("Done A...");
        }

        private async Task DoB()
        {
            Console.WriteLine("Starting B...");
            await Wait(13000);
            Console.WriteLine("Done B...");
        }

        private void UpdateGUI()
        {
            Console.WriteLine("Updating GUI...done");
        }

        private async Task Wait(int ms)
        {
            await Task.Delay(ms);
        }
    }
}