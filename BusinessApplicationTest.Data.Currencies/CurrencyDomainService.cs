
using System.Data.Entity;

namespace BusinessApplicationTest.Data.Currencies
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using BusinessApplicationTest.Web;
    using OpenRiaServices.DomainServices.EntityFramework;
    using OpenRiaServices.DomainServices.Hosting;
    using OpenRiaServices.DomainServices.Server;


    // Implements application logic using the VaultsEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class CurrencyDomainService : DbDomainService<VaultsEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'VaultCurrencies' query.
        public IQueryable<VaultCurrency> GetVaultCurrencies()
        {
            return this.DbContext.VaultCurrencies;
        }

        public void InsertVaultCurrency(VaultCurrency vaultCurrency)
        {
            DbEntityEntry<VaultCurrency> entityEntry = this.DbContext.Entry(vaultCurrency);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.VaultCurrencies.Add(vaultCurrency);
            }
        }

        public void UpdateVaultCurrency(VaultCurrency currentVaultCurrency)
        {
            this.DbContext.VaultCurrencies.AttachAsModified(currentVaultCurrency, this.ChangeSet.GetOriginal(currentVaultCurrency), this.DbContext);
        }

        public void DeleteVaultCurrency(VaultCurrency vaultCurrency)
        {
            DbEntityEntry<VaultCurrency> entityEntry = this.DbContext.Entry(vaultCurrency);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.VaultCurrencies.Attach(vaultCurrency);
                this.DbContext.VaultCurrencies.Remove(vaultCurrency);
            }
        }
    }
}


