using dotnet_code_challenge.Model;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Interface for Strategy Pattern
/// </summary>
namespace dotnet_code_challenge
{
    public interface IInputFileParser
    {
        /// <summary>
        /// Returns List of horse objects as parsed from the input file
        /// </summary>
        /// <param name="inputFilePath"></param>
        /// <returns></returns>
        List<RacingHorse> ListofHorses(String inputFilePath);
    }
}
