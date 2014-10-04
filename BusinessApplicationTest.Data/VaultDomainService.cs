
using System.Data.Entity;

namespace BusinessApplicationTest.Web
{
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using OpenRiaServices.DomainServices.EntityFramework;
    using OpenRiaServices.DomainServices.Hosting;
    using OpenRiaServices.DomainServices.Server;


    // Implements application logic using the VaultsEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    //[RequiresAuthentication]
    [EnableClientAccess()]
    public class VaultDomainService : DbDomainService<VaultsEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Vaults' query.
        public IQueryable<Vault> GetVaults()
        {
            return this.DbContext.Vaults;
        }

        public void InsertVault(Vault vault)
        {
            DbEntityEntry<Vault> entityEntry = this.DbContext.Entry(vault);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.Vaults.Add(vault);
            }
        }

        public void UpdateVault(Vault currentVault)
        {
            this.DbContext.Vaults.AttachAsModified(currentVault, this.ChangeSet.GetOriginal(currentVault), this.DbContext);
        }

        public void DeleteVault(Vault vault)
        {
            DbEntityEntry<Vault> entityEntry = this.DbContext.Entry(vault);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.Vaults.Attach(vault);
                this.DbContext.Vaults.Remove(vault);
            }
        }
    }
}


