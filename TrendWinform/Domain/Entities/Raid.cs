using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrendWinForm.Domain.Entities
{
    public class Raid : BaseEntity<Raid>
    {
        public virtual RaidType SoftwareOrHardware { get; set; }
        public virtual string RaidLevel { get; set; }
        public virtual string RaidType { get; set; }
        public virtual IList<HardDrive> AssociatedHardDrives { get; set; }
        
    }


    public enum RaidType
    {
        Software,
        Hardware
    }


}
