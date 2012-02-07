using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.Domain.Entities
{
    public class Employee : BaseEntity<Employee>
    {
        public virtual decimal EmployeeNumber { get; set; }
        public virtual string EmployeeTitle { get; set; }
        public virtual Name EmployeeName { get; set; }
        public virtual PhoneNumber EmployeePhoneNumber { get; set; }

    }
}
