using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrendWinForm.Domain.Entities
{
    public class CdfInfo : BaseEntity<CdfInfo>
    {
        public virtual Employee TechExaminer { get; set; }
        public virtual DateTime Cdfdate { get; set; }
        public virtual bool IsFinishDate { get; set; }
    }
}
