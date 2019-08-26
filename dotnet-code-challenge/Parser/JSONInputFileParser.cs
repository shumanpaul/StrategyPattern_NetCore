using dotnet_code_challenge.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// Implementaion for JSON Strategy Objects
/// </summary>
namespace dotnet_code_challenge
{

    public class JSONInputFileParser : IInputFileParser
    {
        /// <summary>
        /// Returns List of horse objects as parsed from the input file
        /// </summary>
        /// <param name="inputFilePath"></param>
        /// <returns></returns>
        public List<RacingHorse> ListofHorses(string inputFilePath)
        {
            Console.WriteLine($"Parsing XML File");

            List<RacingHorse> horses = new List<RacingHorse>();

            try
            {
                string path = Environment.CurrentDirectory;
                if (string.IsNullOrEmpty(inputFilePath))//Null or Empty Input file path
                {
                    Console.WriteLine("Error:- You did not supply a file path.");
                    return horses;
                }
                else if(!File.Exists(inputFilePath))//File doesnt exist
                {
                    Console.WriteLine("Error:- File doesnt exist.");
                    return horses;
                }
                else if (new FileInfo(inputFilePath).Length == 0)//File Empty
                {
                    Console.WriteLine("Error:- File doesnt exist.");
                    return horses;
                }


                /*
                * Code for parsing file
                */


                //Dummy list added to test UnitTestCases
                //To be removed when parsing is implemented
                horses.Add(new RacingHorse { Id = "11111", Name = "Toolatetodelegate", Price = 4.4 });
                horses.Add(new RacingHorse { Id = "22222", Name = "Fikhaar", Price = 10.0 });
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file or directory cannot be found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Application has encountered error....");
                Console.WriteLine("Exception information: {0}", ex);
            }

            return horses;
        }
    }
}
