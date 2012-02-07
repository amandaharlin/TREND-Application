using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class DestiantionMediaMap : ClassMap<DestinationMedia>
    {
       
        public DestiantionMediaMap()
        {
            Id(x => x.Id);
            Map(x => x.Brand);
            Map(x => x.Type);
            Map(x => x.Size);
            Map(x => x.SerialNumber);
            
        }
    }
}
