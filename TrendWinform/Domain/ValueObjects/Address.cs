using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TrendWinForm.Domain.ValueObjects
{
    public class Address
    {
        public virtual string StreetLine1 { get; set; } 
        public virtual string StreetLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string ZipCode { get; set; }

    }




}
