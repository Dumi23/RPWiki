using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class RPChars: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureURL { get; set; }
        public RPCharType RPCharType { get; set; }
        public int RPCharTypeId { get; set; }
        public RPCharRace RPCharRace { get; set; }
        public int RPCharRaceId { get; set; }
    }
}