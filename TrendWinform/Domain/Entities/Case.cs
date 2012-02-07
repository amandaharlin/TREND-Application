using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm;

namespace TrendWinForm.Domain.Entities
{
    public class Case : BaseEntity<Case>
    {
        public virtual decimal CaseNumber { get; set; }
        public virtual string Matter { get; set; }
        public virtual int ItemNumber { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual string Barcode { get; set; }
        public virtual DateTime BarcodeDateVerified { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual FirmContact Requester { get; set; }
        public virtual Employee Examiner { get; set; }

        public virtual IList<Computer> Computers { get; set; }
        public virtual IList<HardDrive> HardDrives { get; set; }
        public virtual IList<ForensicProcess> ForensicProcesses { get; set; }
        public virtual IList<ActiveUserFile> ActiveUserFiles { get; set; }
        public virtual NotesAndConclusion NotesAndConclusion { get; set; }
    }
}
