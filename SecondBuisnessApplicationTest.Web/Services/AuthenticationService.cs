using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using BusinessApplicationTest.Data;
using BusinessApplicationTest.Data.Enum;
using BusinessApplicationTest.Data.Helpers;
using BusinessApplicationTest.Web;
using OpenRiaServices.DomainServices.EntityFramework;
using OpenRiaServices.DomainServices.Hosting;
using OpenRiaServices.DomainServices.Server.ApplicationServices;

namespace SecondBuisnessApplicationTest.Web
{


    // TODO: Switch to a secure endpoint when deploying the application.
    //       The user's name and password should only be passed using https.
    //       To do this, set the RequiresSecureEndpoint property on EnableClientAccessAttribute to true.
    //   
    //       [EnableClientAccess(RequiresSecureEndpoint = true)]
    //
    //       More information on using https with a Domain Service can be found on MSDN.

    /// <summary>
    /// Domain Service responsible for authenticating users when they log on to the application.
    ///
    /// Most of the functionality is already provided by the AuthenticationBase class.
    /// </summary>
    [EnableClientAccess]
    public class AuthenticationService : DbDomainService<VaultsEntities>, IAuthentication<User> //AuthenticationBase<User>
    {
        #region "Private Data"
        private static readonly User DefaultUser = new User
        {
            Name = String.Empty,
            FriendlyName = String.Empty,
            UserID = Guid.Empty,
            Role = String.Empty,
            RoleID = Guid.Empty,
            Roles = null,
            Permissions = null,
            AddSpecialReports = false,
            AutoLogoffMode = false,
            AutoLogoffTimeout = TimeSpan.Zero
        };
        #endregion "Private Data"
        /// <summary>
        /// Gets anonymous User when user is not authenticated.
        /// </summary>
        /// <returns><c>DefaultUser</c></returns>
        protected User GetAnonymousUser()
        {
            return AuthenticationService.DefaultUser;
        }
        /// <summary>
        /// Gets authenticated User or <c>DefaultUser</c>
        /// </summary>
        /// <param name="principal"><c>IPrincipal</c> either <c>Authenticated</c> or not</param>
        /// <returns>Object of type <c>User</c> when <c>Authenticated</c> otherwise <c>DefaultUser</c></returns>
        protected User GetAuthenticatedUser(System.Security.Principal.IPrincipal principal)
        {
            if (principal.Identity.IsAuthenticated)
            {
                return this.GetUser(principal.Identity.Name);
            }
            else
            {
                return DefaultUser;
            }
        }
        /// <summary>
        /// Returns <c>DefaultUser</c>
        /// </summary>
        /// <returns><c>DefaultUser</c></returns>
        protected User CreateUser()
        {
            return AuthenticationService.DefaultUser;
        }
        public User Login(string userName, string password, bool isPersistent, string customData)
        {
            if (this.ValidateUser(userName, password))
            {
                FormsAuthentication.SetAuthCookie(userName, isPersistent);
                return this.GetUser(userName);
            }
            return null;
        }

        public User Logout()
        {
            FormsAuthentication.SignOut();
            return AuthenticationService.DefaultUser;
        }

        public User GetUser()
        {
            if ((this.ServiceContext != null) &&
                (this.ServiceContext.User != null) &&
                this.ServiceContext.User.Identity.IsAuthenticated)
            {
                return this.GetUser(this.ServiceContext.User.Identity.Name);
            }
            return AuthenticationService.DefaultUser;
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validates a user by provided <c>friendlyName</c> and <c>password</c>
        /// </summary>
        /// <param name="userName">friendlyName</param>
        /// <param name="password">password</param>
        /// <returns><c>true</c> if user is valid otherwise returns <c>false</c></returns>
        protected bool ValidateUser(string userName, string password)
        {
            using (UsersAndRolesDomainService users = new UsersAndRolesDomainService())
            {
                string loweredUserName = userName.ToLower();
                //
                try
                {
                    AppUser user = (from u in users.GetAppUsers()
                                    where u.LoweredUserName == loweredUserName
                                    select u).FirstOrDefault();

                    if (user == null) { return false; }
                    //
                    AppUserCredential credential = (from c in users.GetAppUserCredentials()
                                                    where c.UserID == user.UserID && c.IsLockedOut == 0
                                                    select c).FirstOrDefault();
                    //
                    if (credential == null) { return false; }
                    //
                    // Generate password hash.
                    string passwordHash = HashHelper.ComputeSaltedHash(password, credential.PasswordSalt);
                    //
                    return credential.Password.Equals(passwordHash, System.StringComparison.Ordinal);
                }
                catch (Exception ex)
                {

                    throw;
                }

                //

            }
            return true;
        }
        /// <summary>
        /// Throws <c>NotImplementedException</c> because a <c>User</c> cannot be updated in this method.  
        /// </summary>
        /// <param name="user">Not used</param>
        protected void UpdateUserCore(User user)
        {
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Sets <c>FormsAuthentication.SetAuthCookie</c> for provided authenticated <c>IPrincipal</c> 
        /// </summary>
        /// <param name="principal"><c>IPrincipal</c></param>
        /// <param name="isPersistent">Indicates whether to create persistent <c>Cookie</c></param>
        protected void IssueAuthenticationToken(System.Security.Principal.IPrincipal principal, bool isPersistent)
        {
            if (principal.Identity.IsAuthenticated)
            {
                string userName = principal.Identity.Name.ToLower();
                FormsAuthentication.SetAuthCookie(userName, isPersistent /*, cookiePath*/);
            }
            //
            //base.IssueAuthenticationToken(principal, isPersistent);
        }
        /// <summary>
        /// Gets <c>User</c> by its <c>friendlyName</c>
        /// </summary>
        /// <param name="userName">friendlyName</param>
        /// <returns>Object of type <c>User</c></returns>
        private User GetUser(string userName)
        {
            AppUser user = null;
            ////
            ////using (UsersAndRolesDomainService users = new UsersAndRolesDomainService())
            using (VaultsEntities users = new VaultsEntities())
            {
                string loweredUserName = userName.ToLower();
                //
                //user = (from u in users.GetAppUsers()
                //        where u.LoweredUserName == loweredUserName
                //        select u).FirstOrDefault();
                user = (from u in users.AppUsers
                        where u.LoweredUserName == loweredUserName
                        select u).FirstOrDefault();
                //
                if (user == null)
                {
                    return AuthenticationService.DefaultUser;
                }
                else
                {
                    IEnumerable<string> roles = new string[] { user.AppRole.RoleName };
                    IEnumerable<int> permissions = user.AppRole.AppRolePermissions.Select(p => p.PermissionID).ToArray();
                    //
                    bool autoLogoffMode = true;
                    TimeSpan autoLogoffTimeout = TimeSpan.FromMinutes(15);
                    //
                    try
                    {
                        AppSetting setting = users.AppSettings.FirstOrDefault(d => d.SettingID == (int)BS2AppSetting.AutoLogoffMode);
                        if (setting != null)
                        {
                            autoLogoffMode = Convert.ToBoolean(setting.Setting);
                        }
                        //
                        if (autoLogoffMode == true)
                        {
                            setting = users.AppSettings.FirstOrDefault(d => d.SettingID == (int)BS2AppSetting.AutoLogoffTimeout);
                            if (setting != null)
                            {
                                autoLogoffTimeout = TimeSpan.FromMinutes(Convert.ToInt32(setting.Setting));
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    //
                    bool addSpecialReports = false;
                    string mapsCredentials = null;

                    try
                    {
                        string strAddSpecialReports = WebConfigurationManager.AppSettings.Get("AddSpecialReports");
                        Boolean.TryParse(strAddSpecialReports, out addSpecialReports);
                        //
                        mapsCredentials = WebConfigurationManager.AppSettings.Get("MapsCredentials");
                    }
                    catch (Exception) { }
                    //
                    user.LastActivityDate = DateTime.Now;
                    users.SaveChanges();
                    //
                    return new User
                    {
                        Name = user.UserName,
                        FriendlyName = user.FriendlyName,
                        UserID = user.UserID,
                        Role = user.AppRole.RoleName,
                        RoleID = user.AppRole.RoleID,
                        Roles = roles,
                        Permissions = permissions,
                        AddSpecialReports = addSpecialReports,
                        AutoLogoffMode = autoLogoffMode,
                        AutoLogoffTimeout = autoLogoffTimeout,
                        MapsCredentials = mapsCredentials
                    };
                }
            }
        }
    }
}
