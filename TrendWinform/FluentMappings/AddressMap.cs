using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class AddressMap : ComponentMap<Address>
    {
        public AddressMap()
        {
            Map(x => x.StreetLine1);
            Map(x => x.StreetLine2);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.ZipCode);
        }
    }
}
