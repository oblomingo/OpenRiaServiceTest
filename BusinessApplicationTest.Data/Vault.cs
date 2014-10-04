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
    
    public partial class Vault
    {
        public Vault()
        {
            this.VaultAmounts = new HashSet<VaultAmount>();
            this.VaultCashOrders = new HashSet<VaultCashOrder>();
            this.VaultCashOrders1 = new HashSet<VaultCashOrder>();
            this.VaultCashPoints = new HashSet<VaultCashPoint>();
            this.VaultEvents = new HashSet<VaultEvent>();
            this.VaultRecepients = new HashSet<VaultRecepient>();
            this.VaultRecepients1 = new HashSet<VaultRecepient>();
        }
    
        public System.Guid VaultId { get; set; }
        public string TID { get; set; }
        public int VaultTypeId { get; set; }
        public bool IsActive { get; set; }
        public string VaultAddress { get; set; }
        public int VaultServiceCompanyId { get; set; }
        public System.TimeSpan WorkingTimeStart { get; set; }
        public System.TimeSpan WorkingTimeEnd { get; set; }
        public Nullable<int> OrderDuration { get; set; }
        public Nullable<decimal> MaxLimit { get; set; }
        public Nullable<decimal> MinLimit { get; set; }
    
        public virtual ICollection<VaultAmount> VaultAmounts { get; set; }
        public virtual ICollection<VaultCashOrder> VaultCashOrders { get; set; }
        public virtual ICollection<VaultCashOrder> VaultCashOrders1 { get; set; }
        public virtual ICollection<VaultCashPoint> VaultCashPoints { get; set; }
        public virtual ICollection<VaultEvent> VaultEvents { get; set; }
        public virtual ICollection<VaultRecepient> VaultRecepients { get; set; }
        public virtual ICollection<VaultRecepient> VaultRecepients1 { get; set; }
        public virtual VaultServiceCompany VaultServiceCompany { get; set; }
        public virtual VaultType VaultType { get; set; }
    }
}