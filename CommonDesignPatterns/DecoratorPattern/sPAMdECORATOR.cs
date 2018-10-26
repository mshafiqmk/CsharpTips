using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDesignPatterns.DecoratorPattern
    {
    class SpamDecorator : ITweeter
        {
        private readonly ITweeter _tweeter;

        public SpamDecorator (ITweeter tweeter)
            {
            _tweeter = tweeter;
            }
        public void SendTweet (string message)
            {
            const int numberOfSpamMessage  = 10;
            for (int i = 0; i < numberOfSpamMessage; i++)
                {
                _tweeter.SendTweet(message);
                }
            }
        }
    }
