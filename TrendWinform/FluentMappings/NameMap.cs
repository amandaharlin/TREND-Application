using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.ValueObjects;
using TrendWinForm.Domain.Entities;

namespace TrendWinForm.FluentMappings
{
    public class NameMap : ComponentMap<Name>
    {
        public  NameMap()
        {
            Map(x => x.FirstName).Not.Nullable().Length(50);
            Map(x => x.MiddleNameOrInitial).Length(50);
            Map(x => x.LastName).Not.Nullable().Length(50);
        }

    
    }
}
