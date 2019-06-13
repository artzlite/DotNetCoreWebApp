using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMasterAmphur
    {
        public TbMasterAmphur()
        {
            TbMasterDistrict = new HashSet<TbMasterDistrict>();
            TbMemberAddress = new HashSet<TbMemberAddress>();
        }

        public Guid Oid { get; set; }
        public Guid MasterProvinceOid { get; set; }
        public string AmphurNameThai { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual TbMasterProvince MasterProvinceO { get; set; }
        public virtual ICollection<TbMasterDistrict> TbMasterDistrict { get; set; }
        public virtual ICollection<TbMemberAddress> TbMemberAddress { get; set; }
    }
}
