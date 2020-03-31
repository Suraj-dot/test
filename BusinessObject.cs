using System;
using Erp;
using Ice;

namespace Stcl.CIFMIS.WarrantReleaseEntry
{
    public class BusinessObject
    {

        public decimal OrigDebitAmount { get; set; }
        public decimal OrigCreditAmount { get; set; }
        public string OrigGLAccount { get; set; }
        public decimal AvailBudget { get; set; }
        public string Vote { get; set; }
        public string VoteCompany { get; set; }
        public string GlAcctDisp { get; set; }
        public Int32 MaxNo { get; set; }
        public DateTime EndDate { get; set; }
        public string Prefix { get; set; }
    }
}
