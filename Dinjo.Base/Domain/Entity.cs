using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinjo.Base.Domain
{
    public class Entity
    {
        public int? Id { get; set; }
        //public int? CreatorId { get; set; }
        //public int? ModifierId { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
        public int? Active { get; set; }
    }
}
