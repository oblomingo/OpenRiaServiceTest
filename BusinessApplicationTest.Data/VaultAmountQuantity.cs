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
    
    public partial class VaultAmountQuantity
    {
        public System.Guid VaultAmountQuantityId { get; set; }
        public System.Guid VaultAmountId { get; set; }
        public int VaultAmountTypeId { get; set; }
        public int VaultCurrencyDenominationId { get; set; }
        public int VaultCurrencyId { get; set; }
        public int Denomination { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> Summ { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual VaultAmount VaultAmount { get; set; }
        public virtual VaultAmountType VaultAmountType { get; set; }
        public virtual VaultCurrency VaultCurrency { get; set; }
        public virtual VaultCurrencyDenomination VaultCurrencyDenomination { get; set; }
    }
}
