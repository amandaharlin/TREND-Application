using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.Domain.Entities
{
    public class HardDrive : BaseEntity<HardDrive>
    {
        //Basic Info
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
        public virtual string Type { get; set; }
        public virtual string Serial { get; set; }
        public virtual decimal SizeInKilobytes { get; set; }


        public virtual string DriveInterface { get; set; }
        public virtual string DrivePosition { get; set; }
        public virtual string JumperSetting { get; set; }
        public virtual JumperDiagram JumperDiagram { get; set; }

        
        public virtual Computer ReferenceComputer { get; set; }
        public virtual Raid ReferenceRaid { get; set; }

        public virtual CdfInfo CDFInfo { get; set; }
      //  public virtual CdfInfo IsItAFinishDate { get; set; }
        //public virtual CdfInfo FinishDateTime { get; set; }
    }
}
