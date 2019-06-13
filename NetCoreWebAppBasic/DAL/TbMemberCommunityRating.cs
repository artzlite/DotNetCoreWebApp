using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMemberCommunityRating
    {
        public TbMemberCommunityRating()
        {
            TbMemberCommunity = new HashSet<TbMemberCommunity>();
        }

        public Guid Oid { get; set; }
        public string CommunityRatingName { get; set; }
        public int Orderby { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual ICollection<TbMemberCommunity> TbMemberCommunity { get; set; }
    }
}
