using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMemberDrink
    {
        public TbMemberDrink()
        {
            TbMemberAccount = new HashSet<TbMemberAccount>();
        }

        public Guid Oid { get; set; }
        public int StartDrinkYear { get; set; }
        public DateTime StopDrinkDate { get; set; }
        public string StartDrinkReason { get; set; }
        public string StopDrinkTechnic { get; set; }
        public string StartDrinkEffect { get; set; }
        public string StopDrinkMostEffect { get; set; }
        public string StopDrinkLifeEffect { get; set; }
        public string StopDrinkHealthEffect { get; set; }
        public string StopDrinkSavingEffect { get; set; }
        public string StopDrinkOtherEffect { get; set; }
        public string StopDrinkInviteReason { get; set; }
        public string StopDrinkInspiration { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual ICollection<TbMemberAccount> TbMemberAccount { get; set; }
    }
}
