using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMasterRegion
    {
        public TbMasterRegion()
        {
            TbAdminRoleRegion = new HashSet<TbAdminRoleRegion>();
            TbMasterProvince = new HashSet<TbMasterProvince>();
            TbMemberAddress = new HashSet<TbMemberAddress>();
        }

        public Guid Oid { get; set; }
        public string RegionNameThai { get; set; }
        public string RegionCode { get; set; }
        public int Orderby { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual ICollection<TbAdminRoleRegion> TbAdminRoleRegion { get; set; }
        public virtual ICollection<TbMasterProvince> TbMasterProvince { get; set; }
        public virtual ICollection<TbMemberAddress> TbMemberAddress { get; set; }
    }
}
