using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class RPState: BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string PictureURL  { get; set; }

    }
}