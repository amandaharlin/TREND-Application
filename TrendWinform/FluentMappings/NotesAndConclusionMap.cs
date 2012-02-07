using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class NotesAndConclusionMap : ClassMap<NotesAndConclusion>
    {
        public NotesAndConclusionMap()
        {
            Id(x => x.Id);
            Map(x => x.Notes).Length(100000);
            Map(x => x.Conclusion).Length(100000);
            References(x => x.CdfInfo).Cascade.All().Not.LazyLoad();
            References(x => x.ReferenceCase).Not.LazyLoad();
        }
    }
}

