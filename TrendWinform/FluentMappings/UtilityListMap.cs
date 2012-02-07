using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.FluentMappings
{
    public class UtilityListMap : ClassMap<UtilityList>
    {

        public UtilityListMap()
        {
            
            Id(x => x.Id);
            Map(x => x.UtilityListKey);

            HasMany<string>(x => x.UtilityListValues).Element("UtilityListItems");



        }

        
        
    }



}
