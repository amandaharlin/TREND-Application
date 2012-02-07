using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrendWinForm.Domain.Entities
{
    public class Computer : BaseEntity<Computer>
    {
        
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
        public virtual string Type { get; set; }
        public virtual string SerialNumber { get; set; }
        public virtual string SvcTag { get; set; }

        public virtual IList<Raid> Raids { get; set; }
        public virtual IList<HardDrive> HardDrives { get; set; }
        


        public virtual CdfInfo CdfInfo { get; set; }

        //System Info
        public virtual bool SystemWasRunning { get; set; }
        public virtual bool PlugWasPulled { get; set; }
        public virtual bool AppsWereRunning { get; set; }
        public virtual bool WasServer { get; set; }
        public virtual bool WasPoweredOn { get; set; }
        public virtual Employee WhoShutDown { get; set; }
        public virtual string ServerType { get; set; }
        public virtual bool WasVirtualMachine { get; set; }
        public virtual bool WasHostedSystem { get; set; }
        public virtual string Hostname { get; set; }

        //Cmos Info
        public virtual DateTime CmosDate { get; set; }
        public virtual DateTime CurrentDate { get; set; }
        public virtual string ActualTimeProvidedBy { get; set; }
        public virtual string KeystrokeForCmosSetup { get; set; }
        public virtual bool CmosWasChanged { get; set; }
        public virtual string DescriptionOfCmosChanges { get; set; }

    }
}
