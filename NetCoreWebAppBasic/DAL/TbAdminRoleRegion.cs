using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbAdminRoleRegion
    {
        public Guid Oid { get; set; }
        public Guid AdminRoleOid { get; set; }
        public Guid MasterRegionOid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual TbAdminRole AdminRoleO { get; set; }
        public virtual TbMasterRegion MasterRegionO { get; set; }
    }
}
