using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMemberCommunity
    {
        public TbMemberCommunity()
        {
            TbMemberAccount = new HashSet<TbMemberAccount>();
        }

        public Guid Oid { get; set; }
        public Guid MasterDistrictOid { get; set; }
        public Guid CommunityRatingOid { get; set; }
        public string CommunityNameThai { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual TbMemberCommunityRating CommunityRatingO { get; set; }
        public virtual TbMasterDistrict MasterDistrictO { get; set; }
        public virtual ICollection<TbMemberAccount> TbMemberAccount { get; set; }
    }
}
