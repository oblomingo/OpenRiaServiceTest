using System;
using System.Collections.Generic;

namespace BusinessApplicationTest.Web
{
    using System.Runtime.Serialization;
    using OpenRiaServices.DomainServices.Server.ApplicationServices;

    /// <summary>
    /// Class containing information about the authenticated user.
    /// </summary>
    public partial class User : UserBase
    {
        /// <summary>
        /// Gets and sets the friendly name of the user.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Gets or sets <c>UserID</c>
        /// </summary>
        public Guid UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// Gets or sets <c>RoleID</c>
        /// </summary>s
        public Guid RoleID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<int> Permissions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool AddSpecialReports { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool AutoLogoffMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TimeSpan AutoLogoffTimeout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MapsCredentials { get; set; }
    }
}
