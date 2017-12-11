using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;

namespace Capstone_SneakyFinch_
{
    class Program
    {
        static void Main(string[] args)
        {
            //**********************************************
            // Application: CIT 110 Capstone
            // Author: Duane Dodge  
            // Date: Dec 6th, 2017
            //**********************************************

            Finch SneakyFinch = new Finch();
            SneakyFinch.connect();



            double ambientLight;
            double currentLight;
            double lightTolerance;
            double maxLightThreshold;


            //
            // set up temp values
            //
            /*temperatureTolerance = 1;
            ambientTemperature = SneakyFinch.getTemperature();
            minTemperatureThreshold = ambientTemperature - temperatureTolerance;*/

            //
            // set up light values
            //
            lightTolerance = 15;
            ambientLight = SneakyFinch.getLeftLightSensor();
            maxLightThreshold = ambientLight + lightTolerance;

            string menuChoice;
            bool exiting = false;


            //
            // display menu choices
            //
            DisplayHeader("");

            Console.WriteLine("Welcome to Sneaky Finch!");
            Console.WriteLine("Sneaky Finch will sneak into the lab to collect some code that will help defeat the bad guys!");
            Console.WriteLine("He will be sneaking through the shadows and avoiding the guard's flashlight.");
            Console.Write("Enter Shield Level");
            Console.WriteLine();
            Console.WriteLine("\t1) Enter hallway one");
            Console.WriteLine("\t2) Enter hallway two");
            Console.WriteLine("\t3) Enter stairwell");
            Console.WriteLine("\t4) Enter secret lab");
            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    HallwayCrawl(5, SneakyFinch);
                    break;

                case "2":
                    HallwayCrawlTwo(5, SneakyFinch);
                    break;

                case "3":
                    StairWell(5, SneakyFinch);
                    break;

                case "4":
                    break;
                    SecretLab(10, SneakyFinch);

                default:
                    break;


            }









            //
            // sneaky finch continue
            //
            SneakyFinch.setMotors(0, 0);
            Console.WriteLine("So far so good.");
            Console.WriteLine();
            Console.WriteLine("Press Enter Key to Continue");
            Console.ReadKey();

            //
            // display menu choices
            //
            DisplayHeader("");

            Console.WriteLine("Welcome to Sneaky Finch!");
            Console.WriteLine("Sneaky Finch will sneak into the lab to collect some code that will help defeat the bad guys!");
            Console.WriteLine("He will be sneaking through the shadows and avoiding the guard's flashlight.");
            Console.Write("Enter Shield Level");
            Console.WriteLine();
            Console.WriteLine("\t1) Enter hallway one");
            Console.WriteLine("\t2) Enter hallway two");
            Console.WriteLine("\t3) Enter stairwell");
            Console.WriteLine("\t4) Enter secret lab");
            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    HallwayCrawl(5, SneakyFinch);
                    break;

                case "2":
                    HallwayCrawlTwo(5, SneakyFinch);
                    break;

                case "3":
                    StairWell(5, SneakyFinch);
                    break;

                case "4":
                    break;
                    SecretLab(10, SneakyFinch);
                default:
                    break;


            }

            SneakyFinch.setMotors(0, 0);
            Console.WriteLine("Phew that was close.");
            Console.WriteLine();
            Console.WriteLine("Press Enter Key to Continue");
            Console.ReadKey();

            //
            // display menu choices
            //
            DisplayHeader("");

            Console.WriteLine("Welcome to Sneaky Finch!");
            Console.WriteLine("Sneaky Finch will sneak into the lab to collect some code that will help defeat the bad guys!");
            Console.WriteLine("He will be sneaking through the shadows and avoiding the guard's flashlight.");
            Console.Write("Enter Shield Level");
            Console.WriteLine();
            Console.WriteLine("\t1) Enter hallway one");
            Console.WriteLine("\t2) Enter hallway two");
            Console.WriteLine("\t3) Enter stairwell");
            Console.WriteLine("\t4) Enter secret lab");
            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    HallwayCrawl(5, SneakyFinch);
                    break;

                case "2":
                    HallwayCrawlTwo(5, SneakyFinch);
                    break;

                case "3":
                    StairWell(5, SneakyFinch);
                    break;

                case "4":
                    break;
                    SecretLab(10, SneakyFinch);
                default:
                    break;


            }

            SneakyFinch.setMotors(0, 0);
            Console.WriteLine("That was TOO easy!");
            Console.WriteLine();
            Console.WriteLine("Press Enter Key to Continue");
            Console.ReadKey();

            //
            // display menu choices
            //
            DisplayHeader("");

            Console.WriteLine("Welcome to Sneaky Finch!");
            Console.WriteLine("Sneaky Finch will sneak into the lab to collect some code that will help defeat the bad guys!");
            Console.WriteLine("He will be sneaking through the shadows and avoiding the guard's flashlight.");
            Console.Write("Enter Shield Level");
            Console.WriteLine();
            Console.WriteLine("\t1) Enter hallway one");
            Console.WriteLine("\t2) Enter hallway two");
            Console.WriteLine("\t3) Enter stairwell");
            Console.WriteLine("\t4) Enter secret lab");
            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    HallwayCrawl(5, SneakyFinch);
                    break;

                case "2":
                    HallwayCrawlTwo(5, SneakyFinch);
                    break;

                case "3":
                    StairWell(5, SneakyFinch);
                    break;

                case "4":
                    break;
                    SecretLab(10, SneakyFinch);
                default:
                    break;


            }
            //
            // disconnect finch
            //
            SneakyFinch.setMotors(0, 0);
            Console.WriteLine("I did it, I got the secret code!");
            Console.WriteLine();
            Console.WriteLine("Press Enter Key to exit");
            Console.ReadKey();
            SneakyFinch.disConnect();

        }






        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }


        /// <summary>
        /// First Choice
        /// </summary>
        /// <param name="secondsOfCrawl"></param>
        /// <param name="SneakyFinch"></param>
        static void HallwayCrawl(int secondsOfCrawl, Finch SneakyFinch)
        {
            bool hit = false;

            for (int seconds = 0; seconds < secondsOfCrawl * 10; seconds++)
            {
                SneakyFinch.setMotors(100, 100);

                Console.Clear();
                Console.WriteLine(SneakyFinch.getRightLightSensor());
                if (SneakyFinch.getLeftLightSensor() > 150)
                {
                    hit = true;
                    SneakyFinch.setMotors(0, 0);
                    SneakyFinch.setLED(255, 0, 0);
                    SneakyFinch.wait(1000);
                }


            }


        }

        /// <summary>
        /// Second Choice
        /// </summary>
        /// <param name="secondsOfCrawl"></param>
        /// <param name="SneakyFinch"></param>
        static void HallwayCrawlTwo(int secondsOfCrawl, Finch SneakyFinch)
        {
            bool hit;

            for (int seconds = 0; seconds < secondsOfCrawl * 10; seconds++)
            {
                SneakyFinch.setMotors(100, 100);

                Console.Clear();
                Console.WriteLine(SneakyFinch.getRightLightSensor());
                if (SneakyFinch.getLeftLightSensor() > 150)
                {
                    hit = true;
                    SneakyFinch.setMotors(-100, -25);
                    SneakyFinch.setLED(255, 0, 0);
                    SneakyFinch.wait(3000);
                    SneakyFinch.setMotors(100, 25);
                    SneakyFinch.wait(3000);

                }

                else
                {
                    hit = false;
                    SneakyFinch.setMotors(100, 25);
                    SneakyFinch.setMotors(100, 100);
                }
            }


        }

        /// <summary>
        /// third choice
        /// </summary>
        /// <param name="secondsOfCrawl"></param>
        /// <param name="SneakyFinch"></param>
        static void StairWell(int secondsOfCrawl, Finch SneakyFinch)
        {
            bool hit;

            for (int seconds = 0; seconds < secondsOfCrawl * 10; seconds++)
            {
                SneakyFinch.setMotors(255, 255);

                Console.Clear();
                Console.WriteLine(SneakyFinch.getRightLightSensor());
                if (SneakyFinch.getLeftLightSensor() > 150)
                {
                    hit = true;
                    SneakyFinch.setMotors(-100, -25);
                    SneakyFinch.setLED(255, 0, 0);
                    SneakyFinch.wait(3000);
                    SneakyFinch.setMotors(100, 25);
                    SneakyFinch.wait(3000);

                }

                else
                {
                    hit = false;
                    SneakyFinch.setMotors(100, 25);
                    SneakyFinch.setMotors(100, 100);
                }
            }


        }

        /// <summary>
        /// Final choice
        /// </summary>
        /// <param name="secondsOfCrawl"></param>
        /// <param name="SneakyFinch"></param>
        static void SecretLab(int secondsOfCrawl, Finch SneakyFinch)
        {
            bool hit;

            for (int seconds = 0; seconds < secondsOfCrawl * 10; seconds++)
            {
                SneakyFinch.setMotors(40, 40);

                Console.Clear();
                Console.WriteLine(SneakyFinch.getRightLightSensor());
                if (SneakyFinch.getLeftLightSensor() > 150)
                {
                    hit = true;
                    SneakyFinch.setMotors(-100, -25);
                    SneakyFinch.setLED(255, 0, 0);
                    SneakyFinch.wait(3000);
                    SneakyFinch.setMotors(100, 25);
                    SneakyFinch.wait(3000);

                }


            }


        }
    }
}
