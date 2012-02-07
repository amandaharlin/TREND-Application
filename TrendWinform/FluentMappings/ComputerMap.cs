using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class ComputerMap : ClassMap<Computer>
    {
        public ComputerMap()
        {
            Id(x => x.Id).GeneratedBy.Guid();

            //General info
            Map(x => x.Make);
            Map(x => x.Model);
            Map(x => x.Type);
            Map(x => x.SerialNumber);
            Map(x => x.SvcTag);

            //CMOS SETup
            Map(x => x.CmosDate);
            Map(x => x.CurrentDate);
            Map(x => x.ActualTimeProvidedBy);
            Map(x => x.KeystrokeForCmosSetup);
            Map(x => x.CmosWasChanged);
            Map(x => x.DescriptionOfCmosChanges);

            //System info
            Map(x => x.SystemWasRunning);
            Map(x => x.PlugWasPulled);
            Map(x => x.AppsWereRunning);
            References(x => x.WhoShutDown).Not.LazyLoad();
            Map(x => x.WasPoweredOn);
            Map(x => x.WasServer);
            Map(x => x.ServerType);
            Map(x => x.WasVirtualMachine);
            Map(x => x.WasHostedSystem);
            Map(x => x.Hostname);

            //HD/Raid
            HasMany(x => x.Raids).Cascade.All().Not.LazyLoad();
            HasMany(x => x.HardDrives).Cascade.All().Not.LazyLoad();


            //CDF Info
            References(x => x.CdfInfo).Cascade.All().Not.LazyLoad();


            
            




        }


    }
}
