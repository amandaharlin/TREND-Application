using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.Domain.Entities
{
    public class UtilityList : BaseEntity<UtilityList>
    {
        public virtual string UtilityListKey { get; set; }
        public virtual IList<string> UtilityListValues { get; set; }

    }
}
