using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class CdfInfoMap : ClassMap<CdfInfo>
    {
        public CdfInfoMap()
        {
            Id(x => x.Id);
            Map(x => x.Cdfdate);
            Map(x => x.IsFinishDate);
            References(x => x.TechExaminer).Not.LazyLoad();
            
        }
    }
}
