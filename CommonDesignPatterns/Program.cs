using System;
using CommonDesignPatterns.DecoratorPattern;

namespace CommonDesignPatterns
    {
    class Program
        {
        static void Main (string[] args)
            {
            //HashTag decorator 
            Console.WriteLine ("HashTag Decorator");
            ITweeter t = new Tweeter();
            HashTagDecorator decorated = new HashTagDecorator(t);
            decorated.SendTweet("docs.microsoft.com");

            //SpamDecorator
            Console.WriteLine ("Spam Decorator");
            ITweeter tw = new Tweeter();
            SpamDecorator decorator = new SpamDecorator(t);
            decorator.SendTweet("docs.ms.com");
            Console.ReadKey();

            //compose HashTag & Spam Decorators 
            Console.WriteLine ("Composition of both Spam & Hash Decorators");
            ITweeter compose  =  new SpamDecorator(
                new HashTagDecorator(
                    new Tweeter()
                    ));

            compose.SendTweet("www.shafiqkhuidad.com");
            }
        }
    }
