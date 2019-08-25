using dotnet_code_challenge.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge
{
    public class JSONInputFileParser : IInputFileParser
    {
        public List<RacingHorse> ListofHorses(string inputFilePath)
        {
            Console.WriteLine($"Parsing XML File");
            
            /*
             * Code for parsing file
             * */

            List<RacingHorse> horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "Horse123", Name = "Lightining", Price = 12.05 },
                                                                                     new RacingHorse { Id = "Horse1234", Name = "Striker", Price = 13.05 } };
            return horsesSortedAscending;
        }
    }
}
