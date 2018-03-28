using System;

namespace DAL.Entities
{
    class Player
    {
        public int PlayerId { get; set; }
        public int? ShirtNumber { get; set; }
        public int? InTheTeamSince { get; set; }
        public int? Position { get; set; }
    }
}
