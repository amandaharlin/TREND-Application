using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class FirmContactMap :ClassMap<FirmContact>
    {
        public FirmContactMap()
        {
            Id(x => x.Id);
            Map(x => x.Position);
            Map(x => x.Notes);
            Component(x => x.Name);
            References(x => x.Firm).Not.Nullable();
            Component(x => x.PhoneNumber);

        }



    }
}
