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
    
    public partial class AppUser
    {
        public AppUser()
        {
            this.AppStaffs = new HashSet<AppStaff>();
            this.AppStaffs1 = new HashSet<AppStaff>();
            this.AppUserProfiles = new HashSet<AppUserProfile>();
        }
    
        public System.Guid UserID { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string FriendlyName { get; set; }
        public System.Guid RoleID { get; set; }
        public Nullable<System.Guid> CompanyID { get; set; }
        public Nullable<System.DateTime> LastActivityDate { get; set; }
        public bool IsLockedOut { get; set; }
    
        public virtual AppRole AppRole { get; set; }
        public virtual ICollection<AppStaff> AppStaffs { get; set; }
        public virtual ICollection<AppStaff> AppStaffs1 { get; set; }
        public virtual AppUserCompany AppUserCompany { get; set; }
        public virtual AppUserCredential AppUserCredential { get; set; }
        public virtual AppUserInfo AppUserInfo { get; set; }
        public virtual ICollection<AppUserProfile> AppUserProfiles { get; set; }
    }
}
