using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
   public class JumperDiagramMap : ComponentMap<JumperDiagram>
   {
       public JumperDiagramMap()
       {
           Map(x => x.Jumper_0);
           Map(x => x.Jumper_1);
           Map(x => x.Jumper_2);
           Map(x => x.Jumper_3);
           Map(x => x.Jumper_4);
           Map(x => x.Jumper_5);
           Map(x => x.Jumper_6);
           Map(x => x.Jumper_7);
           Map(x => x.Jumper_8);
           Map(x => x.Jumper_9);
           
       }
   }
}
