using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbAdminAccount
    {
        public Guid Oid { get; set; }
        public Guid AdminRoleOid { get; set; }
        public Guid GenderOid { get; set; }
        public Guid AdminStatusOid { get; set; }
        public int AdminNo { get; set; }
        public string AdminId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual TbAdminRole AdminRoleO { get; set; }
        public virtual TbAdminStatus AdminStatusO { get; set; }
        public virtual TbMasterGender GenderO { get; set; }
    }
}
