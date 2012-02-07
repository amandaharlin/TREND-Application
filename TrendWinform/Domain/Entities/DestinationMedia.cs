using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.FluentMappings;

namespace TrendWinForm.Domain.Entities
{
    public class DestinationMedia : BaseEntity<DestinationMedia>
    {
        public virtual string Type { get; set; }
        public virtual string Brand { get; set; }
        public virtual decimal Size { get; set; }
        public virtual string SerialNumber { get; set; }
        
    }
}
