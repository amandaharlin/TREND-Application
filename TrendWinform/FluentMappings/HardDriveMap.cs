using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class HardDriveMap : ClassMap<HardDrive>
    {
        public HardDriveMap()
        {
            Id(x => x.Id);
            Map(x => x.Make);
            Map(x => x.Model);
            Map(x => x.Type);
            Map(x => x.Serial);
            Map(x => x.SizeInGB);
            Map(x => x.DriveInterface);
            Map(x => x.DrivePosition);
            Map(x => x.JumperSetting);
            Component(x => x.JumperDiagram); //virtual member call in constructor
            References(x => x.ReferenceComputer).Not.LazyLoad();
            References(x => x.ReferenceRaid).Cascade.All().Not.LazyLoad();

            References(x => x.CDFInfo).Cascade.All().Not.LazyLoad();
        }
    }
}
