using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMemberAddress
    {
        public TbMemberAddress()
        {
            TbMemberAccount = new HashSet<TbMemberAccount>();
        }

        public Guid Oid { get; set; }
        public string AddressDetail { get; set; }
        public Guid MasterDistrictOid { get; set; }
        public Guid MasterAmphurOid { get; set; }
        public Guid MasterProvinceOid { get; set; }
        public Guid MasterRegionOid { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual TbMasterAmphur MasterAmphurO { get; set; }
        public virtual TbMasterDistrict MasterDistrictO { get; set; }
        public virtual TbMasterProvince MasterProvinceO { get; set; }
        public virtual TbMasterRegion MasterRegionO { get; set; }
        public virtual ICollection<TbMemberAccount> TbMemberAccount { get; set; }
    }
}
