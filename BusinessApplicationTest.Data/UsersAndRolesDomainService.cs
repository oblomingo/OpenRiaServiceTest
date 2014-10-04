
using System.Data.Entity;

namespace BusinessApplicationTest.Data
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
    public class UsersAndRolesDomainService : DbDomainService<VaultsEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppModules' query.
        public IQueryable<AppModule> GetAppModules()
        {
            return this.DbContext.AppModules;
        }

        public void InsertAppModule(AppModule appModule)
        {
            DbEntityEntry<AppModule> entityEntry = this.DbContext.Entry(appModule);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppModules.Add(appModule);
            }
        }

        public void UpdateAppModule(AppModule currentAppModule)
        {
            this.DbContext.AppModules.AttachAsModified(currentAppModule, this.ChangeSet.GetOriginal(currentAppModule), this.DbContext);
        }

        public void DeleteAppModule(AppModule appModule)
        {
            DbEntityEntry<AppModule> entityEntry = this.DbContext.Entry(appModule);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppModules.Attach(appModule);
                this.DbContext.AppModules.Remove(appModule);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppPermissions' query.
        public IQueryable<AppPermission> GetAppPermissions()
        {
            return this.DbContext.AppPermissions;
        }

        public void InsertAppPermission(AppPermission appPermission)
        {
            DbEntityEntry<AppPermission> entityEntry = this.DbContext.Entry(appPermission);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppPermissions.Add(appPermission);
            }
        }

        public void UpdateAppPermission(AppPermission currentAppPermission)
        {
            this.DbContext.AppPermissions.AttachAsModified(currentAppPermission, this.ChangeSet.GetOriginal(currentAppPermission), this.DbContext);
        }

        public void DeleteAppPermission(AppPermission appPermission)
        {
            DbEntityEntry<AppPermission> entityEntry = this.DbContext.Entry(appPermission);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppPermissions.Attach(appPermission);
                this.DbContext.AppPermissions.Remove(appPermission);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppRoles' query.
        public IQueryable<AppRole> GetAppRoles()
        {
            return this.DbContext.AppRoles;
        }

        public void InsertAppRole(AppRole appRole)
        {
            DbEntityEntry<AppRole> entityEntry = this.DbContext.Entry(appRole);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppRoles.Add(appRole);
            }
        }

        public void UpdateAppRole(AppRole currentAppRole)
        {
            this.DbContext.AppRoles.AttachAsModified(currentAppRole, this.ChangeSet.GetOriginal(currentAppRole), this.DbContext);
        }

        public void DeleteAppRole(AppRole appRole)
        {
            DbEntityEntry<AppRole> entityEntry = this.DbContext.Entry(appRole);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppRoles.Attach(appRole);
                this.DbContext.AppRoles.Remove(appRole);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppRoleModules' query.
        public IQueryable<AppRoleModule> GetAppRoleModules()
        {
            return this.DbContext.AppRoleModules;
        }

        public void InsertAppRoleModule(AppRoleModule appRoleModule)
        {
            DbEntityEntry<AppRoleModule> entityEntry = this.DbContext.Entry(appRoleModule);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppRoleModules.Add(appRoleModule);
            }
        }

        public void UpdateAppRoleModule(AppRoleModule currentAppRoleModule)
        {
            this.DbContext.AppRoleModules.AttachAsModified(currentAppRoleModule, this.ChangeSet.GetOriginal(currentAppRoleModule), this.DbContext);
        }

        public void DeleteAppRoleModule(AppRoleModule appRoleModule)
        {
            DbEntityEntry<AppRoleModule> entityEntry = this.DbContext.Entry(appRoleModule);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppRoleModules.Attach(appRoleModule);
                this.DbContext.AppRoleModules.Remove(appRoleModule);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppRolePermissions' query.
        public IQueryable<AppRolePermission> GetAppRolePermissions()
        {
            return this.DbContext.AppRolePermissions;
        }

        public void InsertAppRolePermission(AppRolePermission appRolePermission)
        {
            DbEntityEntry<AppRolePermission> entityEntry = this.DbContext.Entry(appRolePermission);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppRolePermissions.Add(appRolePermission);
            }
        }

        public void UpdateAppRolePermission(AppRolePermission currentAppRolePermission)
        {
            this.DbContext.AppRolePermissions.AttachAsModified(currentAppRolePermission, this.ChangeSet.GetOriginal(currentAppRolePermission), this.DbContext);
        }

        public void DeleteAppRolePermission(AppRolePermission appRolePermission)
        {
            DbEntityEntry<AppRolePermission> entityEntry = this.DbContext.Entry(appRolePermission);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppRolePermissions.Attach(appRolePermission);
                this.DbContext.AppRolePermissions.Remove(appRolePermission);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppSettings' query.
        public IQueryable<AppSetting> GetAppSettings()
        {
            return this.DbContext.AppSettings;
        }

        public void InsertAppSetting(AppSetting appSetting)
        {
            DbEntityEntry<AppSetting> entityEntry = this.DbContext.Entry(appSetting);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppSettings.Add(appSetting);
            }
        }

        public void UpdateAppSetting(AppSetting currentAppSetting)
        {
            this.DbContext.AppSettings.AttachAsModified(currentAppSetting, this.ChangeSet.GetOriginal(currentAppSetting), this.DbContext);
        }

        public void DeleteAppSetting(AppSetting appSetting)
        {
            DbEntityEntry<AppSetting> entityEntry = this.DbContext.Entry(appSetting);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppSettings.Attach(appSetting);
                this.DbContext.AppSettings.Remove(appSetting);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppStaffs' query.
        public IQueryable<AppStaff> GetAppStaffs()
        {
            return this.DbContext.AppStaffs;
        }

        public void InsertAppStaff(AppStaff appStaff)
        {
            DbEntityEntry<AppStaff> entityEntry = this.DbContext.Entry(appStaff);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppStaffs.Add(appStaff);
            }
        }

        public void UpdateAppStaff(AppStaff currentAppStaff)
        {
            this.DbContext.AppStaffs.AttachAsModified(currentAppStaff, this.ChangeSet.GetOriginal(currentAppStaff), this.DbContext);
        }

        public void DeleteAppStaff(AppStaff appStaff)
        {
            DbEntityEntry<AppStaff> entityEntry = this.DbContext.Entry(appStaff);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppStaffs.Attach(appStaff);
                this.DbContext.AppStaffs.Remove(appStaff);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppUsers' query.
        public IQueryable<AppUser> GetAppUsers()
        {
            return this.DbContext.AppUsers;
        }

        public void InsertAppUser(AppUser appUser)
        {
            DbEntityEntry<AppUser> entityEntry = this.DbContext.Entry(appUser);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppUsers.Add(appUser);
            }
        }

        public void UpdateAppUser(AppUser currentAppUser)
        {
            this.DbContext.AppUsers.AttachAsModified(currentAppUser, this.ChangeSet.GetOriginal(currentAppUser), this.DbContext);
        }

        public void DeleteAppUser(AppUser appUser)
        {
            DbEntityEntry<AppUser> entityEntry = this.DbContext.Entry(appUser);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppUsers.Attach(appUser);
                this.DbContext.AppUsers.Remove(appUser);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppUserCompanies' query.
        public IQueryable<AppUserCompany> GetAppUserCompanies()
        {
            return this.DbContext.AppUserCompanies;
        }

        public void InsertAppUserCompany(AppUserCompany appUserCompany)
        {
            DbEntityEntry<AppUserCompany> entityEntry = this.DbContext.Entry(appUserCompany);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppUserCompanies.Add(appUserCompany);
            }
        }

        public void UpdateAppUserCompany(AppUserCompany currentAppUserCompany)
        {
            this.DbContext.AppUserCompanies.AttachAsModified(currentAppUserCompany, this.ChangeSet.GetOriginal(currentAppUserCompany), this.DbContext);
        }

        public void DeleteAppUserCompany(AppUserCompany appUserCompany)
        {
            DbEntityEntry<AppUserCompany> entityEntry = this.DbContext.Entry(appUserCompany);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppUserCompanies.Attach(appUserCompany);
                this.DbContext.AppUserCompanies.Remove(appUserCompany);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppUserCredentials' query.
        public IQueryable<AppUserCredential> GetAppUserCredentials()
        {
            return this.DbContext.AppUserCredentials;
        }

        public void InsertAppUserCredential(AppUserCredential appUserCredential)
        {
            DbEntityEntry<AppUserCredential> entityEntry = this.DbContext.Entry(appUserCredential);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppUserCredentials.Add(appUserCredential);
            }
        }

        public void UpdateAppUserCredential(AppUserCredential currentAppUserCredential)
        {
            this.DbContext.AppUserCredentials.AttachAsModified(currentAppUserCredential, this.ChangeSet.GetOriginal(currentAppUserCredential), this.DbContext);
        }

        public void DeleteAppUserCredential(AppUserCredential appUserCredential)
        {
            DbEntityEntry<AppUserCredential> entityEntry = this.DbContext.Entry(appUserCredential);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppUserCredentials.Attach(appUserCredential);
                this.DbContext.AppUserCredentials.Remove(appUserCredential);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppUserInfos' query.
        public IQueryable<AppUserInfo> GetAppUserInfos()
        {
            return this.DbContext.AppUserInfos;
        }

        public void InsertAppUserInfo(AppUserInfo appUserInfo)
        {
            DbEntityEntry<AppUserInfo> entityEntry = this.DbContext.Entry(appUserInfo);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppUserInfos.Add(appUserInfo);
            }
        }

        public void UpdateAppUserInfo(AppUserInfo currentAppUserInfo)
        {
            this.DbContext.AppUserInfos.AttachAsModified(currentAppUserInfo, this.ChangeSet.GetOriginal(currentAppUserInfo), this.DbContext);
        }

        public void DeleteAppUserInfo(AppUserInfo appUserInfo)
        {
            DbEntityEntry<AppUserInfo> entityEntry = this.DbContext.Entry(appUserInfo);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppUserInfos.Attach(appUserInfo);
                this.DbContext.AppUserInfos.Remove(appUserInfo);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AppUserProfiles' query.
        public IQueryable<AppUserProfile> GetAppUserProfiles()
        {
            return this.DbContext.AppUserProfiles;
        }

        public void InsertAppUserProfile(AppUserProfile appUserProfile)
        {
            DbEntityEntry<AppUserProfile> entityEntry = this.DbContext.Entry(appUserProfile);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.AppUserProfiles.Add(appUserProfile);
            }
        }

        public void UpdateAppUserProfile(AppUserProfile currentAppUserProfile)
        {
            this.DbContext.AppUserProfiles.AttachAsModified(currentAppUserProfile, this.ChangeSet.GetOriginal(currentAppUserProfile), this.DbContext);
        }

        public void DeleteAppUserProfile(AppUserProfile appUserProfile)
        {
            DbEntityEntry<AppUserProfile> entityEntry = this.DbContext.Entry(appUserProfile);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.AppUserProfiles.Attach(appUserProfile);
                this.DbContext.AppUserProfiles.Remove(appUserProfile);
            }
        }
    }
}


