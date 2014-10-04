
namespace BusinessApplicationTest.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using OpenRiaServices.DomainServices.Hosting;
    using OpenRiaServices.DomainServices.Server;


    // The MetadataTypeAttribute identifies AppModuleMetadata as the class
    // that carries additional metadata for the AppModule class.
    [MetadataTypeAttribute(typeof(AppModule.AppModuleMetadata))]
    public partial class AppModule
    {

        // This class allows you to attach custom attributes to properties
        // of the AppModule class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppModuleMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppModuleMetadata()
            {
            }

            public ICollection<AppPermission> AppPermissions { get; set; }

            public ICollection<AppRoleModule> AppRoleModules { get; set; }

            public string Module { get; set; }

            public int ModuleID { get; set; }

            public string ModuleX { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppPermissionMetadata as the class
    // that carries additional metadata for the AppPermission class.
    [MetadataTypeAttribute(typeof(AppPermission.AppPermissionMetadata))]
    public partial class AppPermission
    {

        // This class allows you to attach custom attributes to properties
        // of the AppPermission class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppPermissionMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppPermissionMetadata()
            {
            }

            public AppModule AppModule { get; set; }

            public ICollection<AppRolePermission> AppRolePermissions { get; set; }

            public string Description { get; set; }

            public string DescriptionX { get; set; }

            public int ModuleID { get; set; }

            public string Permission { get; set; }

            public int PermissionID { get; set; }

            public string PermissionX { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppRoleMetadata as the class
    // that carries additional metadata for the AppRole class.
    [MetadataTypeAttribute(typeof(AppRole.AppRoleMetadata))]
    public partial class AppRole
    {

        // This class allows you to attach custom attributes to properties
        // of the AppRole class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppRoleMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppRoleMetadata()
            {
            }

            public ICollection<AppRoleModule> AppRoleModules { get; set; }

            public ICollection<AppRolePermission> AppRolePermissions { get; set; }

            public ICollection<AppUser> AppUsers { get; set; }

            public string Description { get; set; }

            public string Description_ru { get; set; }

            public int IsBuiltIn { get; set; }

            public int IsManager { get; set; }

            public Guid RoleID { get; set; }

            public string RoleName { get; set; }

            public TimeSpan WorkingTimeEnd1 { get; set; }

            public TimeSpan WorkingTimeEnd2 { get; set; }

            public Nullable<TimeSpan> WorkingTimeEnd3 { get; set; }

            public TimeSpan WorkingTimeStart1 { get; set; }

            public TimeSpan WorkingTimeStart2 { get; set; }

            public Nullable<TimeSpan> WorkingTimeStart3 { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppRoleModuleMetadata as the class
    // that carries additional metadata for the AppRoleModule class.
    [MetadataTypeAttribute(typeof(AppRoleModule.AppRoleModuleMetadata))]
    public partial class AppRoleModule
    {

        // This class allows you to attach custom attributes to properties
        // of the AppRoleModule class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppRoleModuleMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppRoleModuleMetadata()
            {
            }

            public AppModule AppModule { get; set; }

            public AppRole AppRole { get; set; }

            public int EntryID { get; set; }

            public int ModuleID { get; set; }

            public Guid RoleID { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppRolePermissionMetadata as the class
    // that carries additional metadata for the AppRolePermission class.
    [MetadataTypeAttribute(typeof(AppRolePermission.AppRolePermissionMetadata))]
    public partial class AppRolePermission
    {

        // This class allows you to attach custom attributes to properties
        // of the AppRolePermission class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppRolePermissionMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppRolePermissionMetadata()
            {
            }

            public AppPermission AppPermission { get; set; }

            public AppRole AppRole { get; set; }

            public int EntryID { get; set; }

            public int PermissionID { get; set; }

            public Guid RoleID { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppSettingMetadata as the class
    // that carries additional metadata for the AppSetting class.
    [MetadataTypeAttribute(typeof(AppSetting.AppSettingMetadata))]
    public partial class AppSetting
    {

        // This class allows you to attach custom attributes to properties
        // of the AppSetting class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppSettingMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppSettingMetadata()
            {
            }

            public string Description { get; set; }

            public string DescriptionX { get; set; }

            public int Setting { get; set; }

            public int SettingID { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppStaffMetadata as the class
    // that carries additional metadata for the AppStaff class.
    [MetadataTypeAttribute(typeof(AppStaff.AppStaffMetadata))]
    public partial class AppStaff
    {

        // This class allows you to attach custom attributes to properties
        // of the AppStaff class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppStaffMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppStaffMetadata()
            {
            }

            public AppUser AppUser { get; set; }

            public AppUser AppUser1 { get; set; }

            public int EntryID { get; set; }

            public Guid ManagerID { get; set; }

            public Guid UserID { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppUserMetadata as the class
    // that carries additional metadata for the AppUser class.
    [MetadataTypeAttribute(typeof(AppUser.AppUserMetadata))]
    public partial class AppUser
    {

        // This class allows you to attach custom attributes to properties
        // of the AppUser class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppUserMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppUserMetadata()
            {
            }

            public AppRole AppRole { get; set; }

            public ICollection<AppStaff> AppStaffs { get; set; }

            public ICollection<AppStaff> AppStaffs1 { get; set; }

            public AppUserCompany AppUserCompany { get; set; }

            public AppUserCredential AppUserCredential { get; set; }

            public AppUserInfo AppUserInfo { get; set; }

            public ICollection<AppUserProfile> AppUserProfiles { get; set; }

            public Nullable<Guid> CompanyID { get; set; }

            public string FriendlyName { get; set; }

            public bool IsLockedOut { get; set; }

            public Nullable<DateTime> LastActivityDate { get; set; }

            public string LoweredUserName { get; set; }

            public Guid RoleID { get; set; }

            public Guid UserID { get; set; }

            public string UserName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppUserCompanyMetadata as the class
    // that carries additional metadata for the AppUserCompany class.
    [MetadataTypeAttribute(typeof(AppUserCompany.AppUserCompanyMetadata))]
    public partial class AppUserCompany
    {

        // This class allows you to attach custom attributes to properties
        // of the AppUserCompany class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppUserCompanyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppUserCompanyMetadata()
            {
            }

            public ICollection<AppUserInfo> AppUserInfos { get; set; }

            public ICollection<AppUser> AppUsers { get; set; }

            public string CompanyAddress { get; set; }

            public Guid CompanyID { get; set; }

            public string CompanyName { get; set; }

            public string CompanyShortName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppUserCredentialMetadata as the class
    // that carries additional metadata for the AppUserCredential class.
    [MetadataTypeAttribute(typeof(AppUserCredential.AppUserCredentialMetadata))]
    public partial class AppUserCredential
    {

        // This class allows you to attach custom attributes to properties
        // of the AppUserCredential class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppUserCredentialMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppUserCredentialMetadata()
            {
            }

            public AppUser AppUser { get; set; }

            public DateTime CreateDate { get; set; }

            public Nullable<int> FailedPasswordAttemptCount { get; set; }

            public byte IsAdministrator { get; set; }

            public byte IsLockedOut { get; set; }

            public Nullable<DateTime> LastLockoutDate { get; set; }

            public Nullable<DateTime> LastLoginDate { get; set; }

            public Nullable<DateTime> LastPasswordChangedDate { get; set; }

            public string Password { get; set; }

            public string PasswordSalt { get; set; }

            public Guid UserID { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppUserInfoMetadata as the class
    // that carries additional metadata for the AppUserInfo class.
    [MetadataTypeAttribute(typeof(AppUserInfo.AppUserInfoMetadata))]
    public partial class AppUserInfo
    {

        // This class allows you to attach custom attributes to properties
        // of the AppUserInfo class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppUserInfoMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppUserInfoMetadata()
            {
            }

            public AppUser AppUser { get; set; }

            public AppUserCompany AppUserCompany { get; set; }

            public Nullable<Guid> CompanyID { get; set; }

            public string EMailAddress { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string PhoneNumbers { get; set; }

            public Guid UserID { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AppUserProfileMetadata as the class
    // that carries additional metadata for the AppUserProfile class.
    [MetadataTypeAttribute(typeof(AppUserProfile.AppUserProfileMetadata))]
    public partial class AppUserProfile
    {

        // This class allows you to attach custom attributes to properties
        // of the AppUserProfile class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AppUserProfileMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AppUserProfileMetadata()
            {
            }

            public AppUser AppUser { get; set; }

            public int ProfileID { get; set; }

            public string PropertyName { get; set; }

            public string PropertyValue { get; set; }

            public Guid UserID { get; set; }
        }
    }
}
