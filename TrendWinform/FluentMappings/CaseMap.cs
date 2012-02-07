using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.Entities;
using FluentNHibernate.Mapping;

namespace TrendWinForm.FluentMappings
{
    public class CaseMap : ClassMap<Case>
    {
        public CaseMap()
        {
            Id(x => x.Id).GeneratedBy.Guid();
            Map(x => x.CaseNumber);
            Map(x => x.Matter);
            Map(x => x.ItemNumber);
            Map(x => x.StartDate);
            Map(x => x.Barcode);
            Map(x => x.BarcodeDateVerified);

            References(x => x.Firm);
            References(x => x.Requester);
            References(x => x.Examiner);
            References(x => x.NotesAndConclusion).Cascade.All();


            HasMany(x => x.Computers).Cascade.All();
            HasMany(x => x.HardDrives).Cascade.All();
            HasMany(x => x.ForensicProcesses).Cascade.All();
            HasMany(x => x.ActiveUserFiles).Cascade.All();
            


        }
    }
}
//object references an unsaved transient instance - 
//save the transient instance before flushing. 
//Type: TrendWinForm.Domain.Entities.NotesAndConclusion, 
//Entity: TrendWinForm.Domain.Entities.NotesAndConclusion