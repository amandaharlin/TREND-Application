using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;

namespace TrendWinForm.FluentMappings
{
   public class ActiveUserFileMap : ClassMap<ActiveUserFile>
   {
       public ActiveUserFileMap()
       {
           Id(x => x.Id);
           Map(x => x.MemoryUsage);
           Map(x => x.CpuUsage);
           Map(x => x.FileName);
           Map(x => x.Description).Length(10000);
           References(x => x.CdfInfo).Cascade.All().Not.LazyLoad();
           References(x => x.ReferenceComputer).Cascade.All().Not.LazyLoad();
  

       }

   }
}
