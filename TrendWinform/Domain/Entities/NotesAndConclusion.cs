using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.Domain.Entities
{
    public class NotesAndConclusion : BaseEntity<NotesAndConclusion>
    {
        
        public virtual string Notes { get; set; }
        public virtual string Conclusion { get; set; }
        public virtual CdfInfo CdfInfo { get; set; }
        public virtual Case ReferenceCase { get; set; }
    }
}
