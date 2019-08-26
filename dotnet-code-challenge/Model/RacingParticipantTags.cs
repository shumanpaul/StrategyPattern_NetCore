using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Model
{
    public class RacingParticipantTags
    {
        private long drawn;

        /// <summary>
        /// Weight
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// Drawn
        /// </summary>
        public long Drawn { get => drawn; set => drawn = value; }

        /// <summary>
        /// Jockey
        /// </summary>
        public string Jockey { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        public long Number { get; set; }

        /// <summary>
        /// Trainer
        /// </summary>
        public string Trainer { get; set; }
    }
}
