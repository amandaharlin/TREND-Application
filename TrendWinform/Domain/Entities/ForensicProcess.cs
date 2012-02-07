using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm;

namespace TrendWinForm.Domain.Entities
{
    public class ForensicProcess : BaseEntity<ForensicProcess>
    {
        //reference the case
        public virtual string CollectionLocation { get; set; }
        public virtual string RoomNumber { get; set; }
        public virtual string CustodianOrUser { get; set; }
        public virtual bool PhotoWasTaken { get; set; }
        public virtual bool WasImageOnly { get; set; }
        public virtual bool WasHardDriveOnly { get; set; }
        public virtual string ProcessingPerformed { get; set; }
        public virtual string ForensicDeviceUsed { get; set; }
        public virtual string Software { get; set; }
        
        public virtual string ImagesMade { get; set; }
        public virtual string ImagesVerifiedBy { get; set; }

        public virtual CdfInfo CdfInfo { get; set; }
        public virtual IList<DestinationMedia> DestinationMediae { get; set; }
       

        public virtual IList<HardDrive> ReferenceHardDrives { get; set; }
        public virtual IList<Computer> ReferenceComputers { get; set; }
    }


    
}
