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
    
    public partial class AppRole
    {
        public AppRole()
        {
            this.AppRoleModules = new HashSet<AppRoleModule>();
            this.AppRolePermissions = new HashSet<AppRolePermission>();
            this.AppUsers = new HashSet<AppUser>();
        }
    
        public System.Guid RoleID { get; set; }
        public string RoleName { get; set; }
        public int IsManager { get; set; }
        public int IsBuiltIn { get; set; }
        public System.TimeSpan WorkingTimeStart1 { get; set; }
        public System.TimeSpan WorkingTimeEnd1 { get; set; }
        public System.TimeSpan WorkingTimeStart2 { get; set; }
        public System.TimeSpan WorkingTimeEnd2 { get; set; }
        public Nullable<System.TimeSpan> WorkingTimeStart3 { get; set; }
        public Nullable<System.TimeSpan> WorkingTimeEnd3 { get; set; }
        public string Description { get; set; }
        public string Description_ru { get; set; }
    
        public virtual ICollection<AppRoleModule> AppRoleModules { get; set; }
        public virtual ICollection<AppRolePermission> AppRolePermissions { get; set; }
        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
