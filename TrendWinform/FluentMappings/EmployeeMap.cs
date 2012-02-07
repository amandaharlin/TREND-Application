using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id);
            Map(x => x.EmployeeNumber);
            Map(x => x.EmployeeTitle);
            Component(x => x.EmployeeName);
            Component(x => x.EmployeePhoneNumber);
        }
    }
}
