using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.Domain.ValueObjects
{
    public class PhoneNumber
    {
        public virtual string Type { get; set; }
        public virtual int Number { get; set; }
        //public virtual int FirstThreeDigits { get; set; }
        //public virtual int LastFourDigits { get; set; }
        public virtual int AreaCode { get; set; }
        public virtual string Extension { get; set; }
    }
}
