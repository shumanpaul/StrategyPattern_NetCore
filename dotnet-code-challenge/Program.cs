using dotnet_code_challenge.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Get first argument as filepath 
                string inputFilePath = args[0];

                //Determine the extension of the filepath
                var inputFileExtension = Path.GetExtension(inputFilePath).ToLower();// Make it case insensitive
                ContextRacingAnimalOperator contextFileParser;
                List<RacingHorse> horsesSortedAscending = new List<RacingHorse>();

                //Invoke required parser and get sort list of horses
                switch (inputFileExtension)
                {
                    case ".xml"://XML
                        contextFileParser = new ContextRacingAnimalOperator(new XMLInputFileParser());
                        horsesSortedAscending = contextFileParser.returnListOfHorsesPriceAscending(inputFilePath);
                        break;
                    case ".json"://JSON
                        contextFileParser = new ContextRacingAnimalOperator(new JSONInputFileParser());
                        horsesSortedAscending = contextFileParser.returnListOfHorsesPriceAscending(inputFilePath);
                        break;
                    default://Any other file
                        Console.WriteLine("JSON or XML file is a valid input");
                        break;
                }
                if (horsesSortedAscending.Count > 0)//If List has values then print it
                {
                    Console.WriteLine("Racing Horses Sorted in ascending order as per their Price");
                    Console.WriteLine("_______________________________________");
                    foreach (var horse in horsesSortedAscending)
                    {
                        Console.WriteLine(horse.Name);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Application has encountered error....");
                Console.WriteLine("Exception information: {0}", ex);
            }
        }
    }
}
