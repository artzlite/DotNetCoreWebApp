using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMasterDistrict
    {
        public TbMasterDistrict()
        {
            TbMemberAddress = new HashSet<TbMemberAddress>();
            TbMemberCommunity = new HashSet<TbMemberCommunity>();
        }

        public Guid Oid { get; set; }
        public Guid MasterAmphurOid { get; set; }
        public string DistrictNameThai { get; set; }
        public string Zipcode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual TbMasterAmphur MasterAmphurO { get; set; }
        public virtual ICollection<TbMemberAddress> TbMemberAddress { get; set; }
        public virtual ICollection<TbMemberCommunity> TbMemberCommunity { get; set; }
    }
}
