using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDesignPatterns.DecoratorPattern
    {
    public class Tweeter : ITweeter
        {
        public void SendTweet (string message)
            {
            Console.WriteLine ($"Tweeting : {message}");
            }
        }
    }
