using FootballManagerApi.EntityBases;
using System;

namespace FootballManagerApi.Entities
{
    public class NationalTeam : Team, IEntity
    {
        public int TeamId { get; set; }
        public DateTime TeamCreateDate { get; set; }
        public DateTime TeamUpdateDate { get; set; }
    }
}