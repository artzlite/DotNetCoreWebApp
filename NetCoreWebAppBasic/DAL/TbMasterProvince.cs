using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMasterProvince
    {
        public TbMasterProvince()
        {
            TbMasterAmphur = new HashSet<TbMasterAmphur>();
            TbMemberAddress = new HashSet<TbMemberAddress>();
        }

        public Guid Oid { get; set; }
        public Guid MasterRegionOid { get; set; }
        public string ProvinceNameThai { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual TbMasterRegion MasterRegionO { get; set; }
        public virtual ICollection<TbMasterAmphur> TbMasterAmphur { get; set; }
        public virtual ICollection<TbMemberAddress> TbMemberAddress { get; set; }
    }
}
