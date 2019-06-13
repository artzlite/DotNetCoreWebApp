using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMasterGender
    {
        public TbMasterGender()
        {
            TbAdminAccount = new HashSet<TbAdminAccount>();
            TbMemberAccount = new HashSet<TbMemberAccount>();
        }

        public Guid Oid { get; set; }
        public string GenderNameThai { get; set; }
        public string GenderNameEng { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual ICollection<TbAdminAccount> TbAdminAccount { get; set; }
        public virtual ICollection<TbMemberAccount> TbMemberAccount { get; set; }
    }
}
