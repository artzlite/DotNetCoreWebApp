using System;
using System.Collections.Generic;

namespace NetCoreWebAppBasic.DAL
{
    public partial class TbMemberAccount
    {
        public Guid Oid { get; set; }
        public Guid MasterPrefixOid { get; set; }
        public Guid MasterGenderOid { get; set; }
        public Guid MemberCommunityOid { get; set; }
        public Guid MemberAddressOid { get; set; }
        public Guid MemberDrinkOid { get; set; }
        public string GenerationId { get; set; }
        public int MemberGenId { get; set; }
        public string MemberId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Talent { get; set; }
        public byte[] Picture { get; set; }
        public bool LecturerFlag { get; set; }
        public bool OtherVolunteerFlag { get; set; }
        public bool VolunteerFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool DeleteFlag { get; set; }

        public virtual TbMasterGender MasterGenderO { get; set; }
        public virtual TbMasterPrefix MasterPrefixO { get; set; }
        public virtual TbMemberAddress MemberAddressO { get; set; }
        public virtual TbMemberCommunity MemberCommunityO { get; set; }
        public virtual TbMemberDrink MemberDrinkO { get; set; }
    }
}
