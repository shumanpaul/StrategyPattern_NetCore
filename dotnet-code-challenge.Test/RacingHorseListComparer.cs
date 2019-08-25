using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Test
{
    //Implementaion of IComparer interface
    public class RacingHorseListComparer : Comparer<RacingHorse>
    {
        public override int Compare(RacingHorse x, RacingHorse y)
        {
            // compare the two horses
            // they are considered equal when their identifiers match
            return x.Id.CompareTo(y.Id);
        }
    }
}
