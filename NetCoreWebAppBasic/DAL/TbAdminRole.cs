using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbAdminRole
    {
        public TbAdminRole()
        {
            TbAdminAccount = new HashSet<TbAdminAccount>();
            TbAdminRoleRegion = new HashSet<TbAdminRoleRegion>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string RoleNameThai { get; set; }
        public string RoleNameEng { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual ICollection<TbAdminAccount> TbAdminAccount { get; set; }
        public virtual ICollection<TbAdminRoleRegion> TbAdminRoleRegion { get; set; }
    }
}
