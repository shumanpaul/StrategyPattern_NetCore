using dotnet_code_challenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotnet_code_challenge
{
    /// <summary>
    /// Implementaion for Context Strategy Objects
    /// </summary>
    public class ContextRacingAnimalOperator
    {
        private IInputFileParser _inputFileParser;


        public ContextRacingAnimalOperator(IInputFileParser inputFileParser)
        {
            _inputFileParser = inputFileParser;
        }

        public void SetContextRacingAnimalOperator(IInputFileParser inputFileParser) => _inputFileParser = inputFileParser;

        public List<RacingHorse> returnListOfHorsesPriceAscending(String path)
        {
            List<RacingHorse> listRacingHorses;

            listRacingHorses = _inputFileParser.ListofHorses(path);

            return listRacingHorses.OrderBy(horse => horse.Price).ToList();
        }

    }
}
