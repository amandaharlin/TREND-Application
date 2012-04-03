using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrendWinForm.Domain.Entities
{
   public class ActiveUserFile : BaseEntity<ActiveUserFile>
   {
       
       public virtual Computer ReferenceComputer { get; set; }
    
       public virtual string FileName { get; set; }
       public virtual string Description { get; set; }
       public virtual decimal MemoryUsage { get; set; }
       public virtual decimal CpuUsage { get; set; }
       public virtual CdfInfo CdfInfo { get; set; }
       public virtual string FileType{ get; set; }
       //active user file list + cdfinfo
    }
}
