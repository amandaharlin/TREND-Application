using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrendWinForm.Domain.ValueObjects
{
    public class Name
    {
        public virtual string FirstName { get; set; }
        public virtual string MiddleNameOrInitial{ get; set; }
        public virtual string LastName{ get; set; }
    }
}
