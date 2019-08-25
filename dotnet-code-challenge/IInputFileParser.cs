using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge
{
    public interface IInputFileParser
    {
        List<RacingHorse> ListofHorses(String inputFilePath);
    }
}
