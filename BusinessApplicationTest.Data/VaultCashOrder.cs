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
    
    public partial class VaultCashOrder
    {
        public VaultCashOrder()
        {
            this.VaultCashOrderQuantities = new HashSet<VaultCashOrderQuantity>();
        }
    
        public System.Guid VaultCashOrderId { get; set; }
        public System.Guid ToDeviceId { get; set; }
        public System.Guid FromDeviceId { get; set; }
        public string ToTID { get; set; }
        public string FromTID { get; set; }
        public System.DateTime CashOrderDate { get; set; }
        public int NumberIncrement { get; set; }
        public int VaultCashOrderStatusId { get; set; }
        public System.Guid AcceptedBy { get; set; }
        public string AcceptedByNotes { get; set; }
        public System.DateTime AcceptedDate { get; set; }
        public Nullable<System.Guid> DeclinedBy { get; set; }
        public string DeclinedByNotes { get; set; }
        public Nullable<System.DateTime> DeclinedDate { get; set; }
        public Nullable<System.Guid> SentToExecuteBy { get; set; }
        public string SentToExecuteByNotes { get; set; }
        public Nullable<System.DateTime> SentToExecuteDate { get; set; }
        public Nullable<System.Guid> CompletedBy { get; set; }
        public string CompletedByNotes { get; set; }
        public Nullable<System.DateTime> CompletedDate { get; set; }
        public System.DateTime LastChangesDateTime { get; set; }
    
        public virtual ICollection<VaultCashOrderQuantity> VaultCashOrderQuantities { get; set; }
        public virtual VaultCashOrderStatus VaultCashOrderStatus { get; set; }
        public virtual Vault Vault { get; set; }
        public virtual Vault Vault1 { get; set; }
    }
}
