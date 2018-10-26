using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDesignPatterns.DecoratorPattern
    {
    public class HashTagDecorator : ITweeter
        {
        private readonly ITweeter _tweeter;

        public HashTagDecorator (ITweeter tweeter)
            {
            _tweeter = tweeter;
            }

        public void SendTweet (string message)
            {
            _tweeter.SendTweet(message + " #CharpTips");
            }
        }
    }
