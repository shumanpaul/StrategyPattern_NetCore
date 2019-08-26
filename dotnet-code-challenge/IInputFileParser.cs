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
        List<RacingHorse> ListofHorses(String inputFilePath);
    }
}
