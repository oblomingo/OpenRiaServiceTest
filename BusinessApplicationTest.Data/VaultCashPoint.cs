//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessApplicationTest.Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class VaultCashPoint
    {
        public System.Guid EntryId { get; set; }
        public System.Guid VaultId { get; set; }
        public System.Guid CashPointId { get; set; }
        public string CashPointTID { get; set; }
        public Nullable<bool> IsReturnCashToVault { get; set; }
        public Nullable<bool> IsReturnBadCashToVault { get; set; }
        public System.Guid AddedBy { get; set; }
        public System.DateTime AddDate { get; set; }
    
        public virtual Vault Vault { get; set; }
    }
}