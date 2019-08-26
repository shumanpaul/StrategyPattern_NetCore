using dotnet_code_challenge.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Xunit;

namespace dotnet_code_challenge.Test
{
    public class UnitTest1
    {
        /// <summary>
        /// Invalid path or missing file
        /// </summary>
        [Fact]
        public void ListHorses_FileNotFoundException()
        {
            string inputFilePath = "FeedData/RandomFile.json";
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>();

            var horsesSortedAscending = new List<RacingHorse>();           

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());
        }

        /// <summary>
        /// File exist but empty
        /// </summary>
        [Fact]
        public void ListHorses_EmptyFile()
        {
            string inputFilePath = "FeedData/RandomFile.json";
            ContextRacingAnimalOperator contextFileParser = new ContextRacingAnimalOperator(new JSONInputFileParser());
            //Empty list expected
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>();

            var horsesSortedAscending = contextFileParser.returnListOfHorsesPriceAscending(inputFilePath);

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// Empty string passed as file path
        /// </summary>
        [Fact]
        public void ListHorses_EmptyFilePath()
        {
            string inputFilePath = "";
            ContextRacingAnimalOperator contextFileParser = new ContextRacingAnimalOperator(new JSONInputFileParser());
            //Empty list expected
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>();

            var horsesSortedAscending = contextFileParser.returnListOfHorsesPriceAscending(inputFilePath);

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// JSON Input file corrupt
        /// </summary>
        [Fact]
        public void ListHorses_InCorrectFromatJSONFile()
        {
            string inputFilePath = "FeedData/RandomFile.json";
            ContextRacingAnimalOperator contextFileParser = new ContextRacingAnimalOperator(new JSONInputFileParser());
            //Empty list expected
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>();

            var horsesSortedAscending = contextFileParser.returnListOfHorsesPriceAscending(inputFilePath);

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// XML Input file corrupt
        /// </summary>
        [Fact]
        public void ListHorses_InCorrectFromatXMLFile()
        {
            string inputFilePath = "FeedData/RandomFile.json";
            ContextRacingAnimalOperator contextFileParser = new ContextRacingAnimalOperator(new JSONInputFileParser());
            
            //Empty list expected
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>();

            var horsesSortedAscending = contextFileParser.returnListOfHorsesPriceAscending(inputFilePath);
            
            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// Input file doesnt contain any horses or required data
        /// </summary>
        [Fact]
        public void ListHorses_NoHorsesInInputFile()
        {
            string inputFilePath = "FeedData/NoHorsesInInputFile.json";
            ContextRacingAnimalOperator contextFileParser = new ContextRacingAnimalOperator(new JSONInputFileParser());

            //Empty list expected
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>();

            var horsesSortedAscending = contextFileParser.returnListOfHorsesPriceAscending(inputFilePath);

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// JSON Valid Case 1
        /// </summary>
        [Fact]
        public void ListHorses_JSON_ValidCase1()
        {
            string inputFilePath = "FeedData/Wolferhampton_Race1.json";
            ContextRacingAnimalOperator contextFileParser = new ContextRacingAnimalOperator(new JSONInputFileParser());
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "2", Name = "Toolatetodelegate", Price = 4.4 },
                                                                                     new RacingHorse { Id = "1", Name = "Fikhaar", Price = 10.0 } };

            var horsesSortedAscending = contextFileParser.returnListOfHorsesPriceAscending(inputFilePath);

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// XML Valid Case 1
        /// </summary>
        [Fact]
        public void ListHorses_XML_ValidCase1()
        {
            string inputFilePath = "FeedData/Caulfield_Race1.xml";
            ContextRacingAnimalOperator contextFileParser = new ContextRacingAnimalOperator(new XMLInputFileParser());
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "872699", Name = "Advancing", Price = 4.2 },
                                                                                     new RacingHorse { Id = "872442", Name = "Coronel", Price = 12.0 } };

            var horsesSortedAscending = contextFileParser.returnListOfHorsesPriceAscending(inputFilePath);

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }
    }
}
