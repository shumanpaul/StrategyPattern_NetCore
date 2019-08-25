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
            string inputFilePath = "InputFiles/RandomFile.json";
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "Horse123", Name = "Lightining", Price = 12.05 },
                                                                                     new RacingHorse { Id = "Horse1234", Name = "Striker", Price = 13.05 } };

            var horsesSortedAscending = new List<RacingHorse>();

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());
        }

        /// <summary>
        /// File exist but empty
        /// </summary>
        [Fact]
        public void ListHorses_EmptyFile()
        {
            string inputFilePath = "InputFiles/RandomFile.json";
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "Horse123", Name = "Lightining", Price = 12.05 },
                                                                                     new RacingHorse { Id = "Horse1234", Name = "Striker", Price = 13.05 } };

            var horsesSortedAscending = new List<RacingHorse>();

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// Empty string passed as file path
        /// </summary>
        [Fact]
        public void ListHorses_BlankFilePath()
        {
            string inputFilePath = "InputFiles/RandomFile.json";
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "Horse123", Name = "Lightining", Price = 12.05 },
                                                                                     new RacingHorse { Id = "Horse1234", Name = "Striker", Price = 13.05 } };

            var horsesSortedAscending = new List<RacingHorse>();

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// JSON Input file corrupt
        /// </summary>
        [Fact]
        public void ListHorses_InCorrectFromatJSONFile()
        {
            string inputFilePath = "InputFiles/RandomFile.json";
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "Horse123", Name = "Lightining", Price = 12.05 },
                                                                                     new RacingHorse { Id = "Horse1234", Name = "Striker", Price = 13.05 } };

            var horsesSortedAscending = new List<RacingHorse>();

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// XML Input file corrupt
        /// </summary>
        [Fact]
        public void ListHorses_InCorrectFromatXMLFile()
        {
            string inputFilePath = "InputFiles/RandomFile.json";
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "Horse123", Name = "Lightining", Price = 12.05 },
                                                                                     new RacingHorse { Id = "Horse1234", Name = "Striker", Price = 13.05 } };

            var horsesSortedAscending = new List<RacingHorse>();

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// Input file doesnt contain any horses or required data
        /// </summary>
        [Fact]
        public void ListHorses_NoHorsesInInputFile()
        {
            string inputFilePath = "InputFiles/RandomFile.json";
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "Horse123", Name = "Lightining", Price = 12.05 },
                                                                                     new RacingHorse { Id = "Horse1234", Name = "Striker", Price = 13.05 } };

            var horsesSortedAscending = new List<RacingHorse>();

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }

        /// <summary>
        /// Valid Case 1
        /// </summary>
        [Fact]
        public void ListHorses_ValidCase1()
        {
            string inputFilePath = "InputFiles/RandomFile.json";
            List<RacingHorse> expected_horsesSortedAscending = new List<RacingHorse>{new RacingHorse { Id = "Horse123", Name = "Lightining", Price = 12.05 },
                                                                                     new RacingHorse { Id = "Horse1234", Name = "Striker", Price = 13.05 } };

            var horsesSortedAscending = new List<RacingHorse>();

            CollectionAssert.AreEqual(expected_horsesSortedAscending, horsesSortedAscending, new RacingHorseListComparer());

        }
    }
}
