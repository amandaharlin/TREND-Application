using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class FirmMap : ClassMap<Firm>
    {

        public FirmMap()
        {
            Id(x => x.Id).GeneratedBy.Guid();
            Map(x => x.FirmName);
            Map(x => x.FirmDescription);
            Component(x => x.Address);
            Component(x => x.PhoneNumber);
            HasMany(x => x.FirmContacts).Inverse();

        }
    }
}
