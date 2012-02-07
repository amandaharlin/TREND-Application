using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class ForensicProcessMap : ClassMap<ForensicProcess>
    {
        public ForensicProcessMap()
        {
            Id(x => x.Id);
            Map(x => x.CollectionLocation);
            Map(x => x.RoomNumber);
            Map(x => x.CustodianOrUser);
            Map(x => x.PhotoWasTaken);
            Map(x => x.WasImageOnly);
            Map(x => x.WasHardDriveOnly);
            Map(x => x.ProcessingPerformed);
            Map(x => x.ForensicDeviceUsed);
            Map(x => x.Software);
            Map(x => x.ImagesMade);
            Map(x => x.ImagesVerifiedBy);
            References(x => x.CdfInfo).Cascade.All().Not.LazyLoad();
            HasMany(x => x.DestinationMediae).Cascade.All().Not.LazyLoad();
            HasMany(x => x.ReferenceComputers).Cascade.All().Not.LazyLoad();
            HasMany(x => x.ReferenceHardDrives).Cascade.All().Not.LazyLoad();
            
        }
    }
}
