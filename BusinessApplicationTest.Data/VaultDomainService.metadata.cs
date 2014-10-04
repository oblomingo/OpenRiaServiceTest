
namespace BusinessApplicationTest.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using OpenRiaServices.DomainServices.Hosting;
    using OpenRiaServices.DomainServices.Server;


    // The MetadataTypeAttribute identifies VaultMetadata as the class
    // that carries additional metadata for the Vault class.
    [MetadataTypeAttribute(typeof(Vault.VaultMetadata))]
    public partial class Vault
    {

        // This class allows you to attach custom attributes to properties
        // of the Vault class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class VaultMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private VaultMetadata()
            {
            }

            public bool IsActive { get; set; }

            public Nullable<decimal> MaxLimit { get; set; }

            public Nullable<decimal> MinLimit { get; set; }

            public Nullable<int> OrderDuration { get; set; }

            public string TID { get; set; }

            public string VaultAddress { get; set; }

            public ICollection<VaultAmount> VaultAmounts { get; set; }

            public ICollection<VaultCashOrder> VaultCashOrders { get; set; }

            public ICollection<VaultCashOrder> VaultCashOrders1 { get; set; }

            public ICollection<VaultCashPoint> VaultCashPoints { get; set; }

            public ICollection<VaultEvent> VaultEvents { get; set; }

            public Guid VaultId { get; set; }

            public ICollection<VaultRecepient> VaultRecepients { get; set; }

            public ICollection<VaultRecepient> VaultRecepients1 { get; set; }

            public VaultServiceCompany VaultServiceCompany { get; set; }

            public int VaultServiceCompanyId { get; set; }

            public VaultType VaultType { get; set; }

            public int VaultTypeId { get; set; }

            public TimeSpan WorkingTimeEnd { get; set; }

            public TimeSpan WorkingTimeStart { get; set; }
        }
    }
}
