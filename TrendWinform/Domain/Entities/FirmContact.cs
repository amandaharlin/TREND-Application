using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.Domain.Entities
{
    public class FirmContact : BaseEntity<FirmContact>
    {
        public virtual Name Name { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual PhoneNumber PhoneNumber { get; set; }
        public virtual string Position { get; set; }
        public virtual string Notes { get; set; }

    }
}
