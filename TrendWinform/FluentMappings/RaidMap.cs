using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class RaidMap : ClassMap<Raid>
    {
        public RaidMap()
        {
            Id(x => x.Id);
            Map(x => x.SoftwareOrHardware);
            Map(x => x.RaidLevel);
            Map(x => x.RaidType);
            HasMany(x => x.AssociatedHardDrives).Not.LazyLoad();
            
            

        }
    }
}
