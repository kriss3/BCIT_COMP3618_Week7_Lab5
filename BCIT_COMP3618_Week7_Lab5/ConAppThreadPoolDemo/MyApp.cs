using System.Threading;
using static System.Console;

namespace ConAppThreadPoolDemo
{
    class MyApp
    {
        /// <summary>
        /// Krzysztof Szczurowski - BCIT COMP 3618 Week 7 Lab 5
        /// Main applicaton to present working of ThreadPool class
        /// Repo: https://github.com/kriss3/BCIT_COMP3618_Week7_Lab5.git
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(Helper.ShowMyText);
            ThreadPool.QueueUserWorkItem(callback, "Hello");
            ThreadPool.QueueUserWorkItem(callback, "Hi");
            ThreadPool.QueueUserWorkItem(callback, "Heya");
            ThreadPool.QueueUserWorkItem(callback, "Goodbye");
            Read();
        }
    }
}
