using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge
{
    public class RacingHorse
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Participant Tags
        /// </summary>
        public ParticipantTags Tags { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public double Price { get; set; }
    }
}
