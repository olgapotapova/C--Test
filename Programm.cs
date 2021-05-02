using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Debug.Listeners.Add(new TextWriterTraceListener("log.txt"));

            Debug.WriteLine("test");

            Debug.Flush();
        }
    }
}
