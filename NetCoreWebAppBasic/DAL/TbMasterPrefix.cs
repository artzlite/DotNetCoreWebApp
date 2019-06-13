using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMasterPrefix
    {
        public TbMasterPrefix()
        {
            TbMemberAccount = new HashSet<TbMemberAccount>();
        }

        public Guid Oid { get; set; }
        public string PrefixName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual ICollection<TbMemberAccount> TbMemberAccount { get; set; }
    }
}
