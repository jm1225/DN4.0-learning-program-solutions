﻿using System;

namespace SingletonPatternExample
{
    // Logger Singleton Class
    public class Logger
    {
         
        private static Logger _instance;

         
        private Logger()
        {
            Console.WriteLine("Logger Initialized");
        }
         
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
         
        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
             
            Logger logger1 = Logger.GetInstance();
            logger1.Log("1st log message.");

             
            Logger logger2 = Logger.GetInstance();
            logger2.Log("2nd log message.");

            // Check if both are same
            if (object.ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("Both logger instances are the same = Singleton verified.");
            }
            else
            {
                Console.WriteLine("Different instances found = Singleton failed.");
            }
        }
    }
}
