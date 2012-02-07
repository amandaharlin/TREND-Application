using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.Domain.Entities
{
    public class Firm : BaseEntity<Firm>
    {
        public virtual string FirmName { get; set; }
        public virtual string FirmDescription { get; set; }
        public virtual Address Address { get; set; }
        public virtual PhoneNumber PhoneNumber { get; set; }
        public virtual IList<FirmContact> FirmContacts { get; set; }

    }
}
