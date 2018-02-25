using System.Threading;
using static System.Console;

namespace ConAppThreadPoolDemo
{
    public class Helper
    {
        /// <summary>
        /// Krzysztof Szczurowski - BCIT COMP 3618 Week 7 Lab 5
        /// Helper class used to separed some operations from main application;
        /// Repo: https://github.com/kriss3/BCIT_COMP3618_Week7_Lab5.git
        /// </summary>
        /// <param name="state"></param>
        public static void ShowMyText(object state)
        {
            var myText = (string)state;
            //Below should not be here but delegate has void returning function signature?
            WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId} - {myText}");
        }
    }
}
