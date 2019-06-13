using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbAdminStatus
    {
        public TbAdminStatus()
        {
            TbAdminAccount = new HashSet<TbAdminAccount>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string StatusNameThai { get; set; }
        public string StatusNameEng { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual ICollection<TbAdminAccount> TbAdminAccount { get; set; }
    }
}
