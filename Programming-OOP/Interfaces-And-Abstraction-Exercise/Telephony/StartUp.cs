using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] numbersArray = Console.ReadLine().Split().ToArray();
            string[] urlArray = Console.ReadLine().Split().ToArray();
            ICallable call = new Smartphone();
            IBrowseable browse = new Smartphone();
            foreach (var num in numbersArray)
            {
                Console.WriteLine(call.Call(num));
            }

            foreach (var url in urlArray)
            {
                Console.WriteLine(browse.Browse(url));
            }
        }
    }
}
