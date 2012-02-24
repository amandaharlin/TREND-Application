using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class PhoneNumberMap : ComponentMap<PhoneNumber>
    {
        public PhoneNumberMap()
        {
            Map(x => x.Type);
            Map(x => x.Number);
            //Map(x => x.FirstThreeDigits);
            //Map(x => x.LastFourDigits);
            Map(x => x.AreaCode);
            Map(x => x.Extension);
        }
    }
}
