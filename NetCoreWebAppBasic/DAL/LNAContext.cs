using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCoreWebAppBasic.DAL
{
    public partial class LNAContext : DbContext
    {
        public LNAContext()
        {
        }

        public LNAContext(DbContextOptions<LNAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAdminAccount> TbAdminAccount { get; set; }
        public virtual DbSet<TbAdminRole> TbAdminRole { get; set; }
        public virtual DbSet<TbAdminRoleRegion> TbAdminRoleRegion { get; set; }
        public virtual DbSet<TbAdminStatus> TbAdminStatus { get; set; }
        public virtual DbSet<TbMasterAmphur> TbMasterAmphur { get; set; }
        public virtual DbSet<TbMasterDistrict> TbMasterDistrict { get; set; }
        public virtual DbSet<TbMasterGender> TbMasterGender { get; set; }
        public virtual DbSet<TbMasterPrefix> TbMasterPrefix { get; set; }
        public virtual DbSet<TbMasterProvince> TbMasterProvince { get; set; }
        public virtual DbSet<TbMasterRegion> TbMasterRegion { get; set; }
        public virtual DbSet<TbMemberAccount> TbMemberAccount { get; set; }
        public virtual DbSet<TbMemberAddress> TbMemberAddress { get; set; }
        public virtual DbSet<TbMemberCommunity> TbMemberCommunity { get; set; }
        public virtual DbSet<TbMemberCommunityRating> TbMemberCommunityRating { get; set; }
        public virtual DbSet<TbMemberDrink> TbMemberDrink { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=103.91.207.110;Database=LNA;user id=sa;password=P@ssw0rd2019;Trusted_Connection=False;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<TbAdminAccount>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_ADMIN_ACCOUNT");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdminId)
                    .IsRequired()
                    .HasColumnName("ADMIN_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.AdminNo)
                    .HasColumnName("ADMIN_NO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdminRoleOid).HasColumnName("ADMIN_ROLE_OID");

                entity.Property(e => e.AdminStatusOid).HasColumnName("ADMIN_STATUS_OID");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("BIRTHDATE")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderOid).HasColumnName("GENDER_OID");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("LASTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(100);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasColumnName("PASSWORD_SALT")
                    .HasMaxLength(100);

                entity.Property(e => e.Picture)
                    .HasColumnName("PICTURE")
                    .HasColumnType("image");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdminRoleO)
                    .WithMany(p => p.TbAdminAccount)
                    .HasForeignKey(d => d.AdminRoleOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_ADMIN_ACCOUNT_TB_ADMIN_ROLE");

                entity.HasOne(d => d.AdminStatusO)
                    .WithMany(p => p.TbAdminAccount)
                    .HasForeignKey(d => d.AdminStatusOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_ADMIN_ACCOUNT_TB_ADMIN_STATUS");

                entity.HasOne(d => d.GenderO)
                    .WithMany(p => p.TbAdminAccount)
                    .HasForeignKey(d => d.GenderOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_ADMIN_ACCOUNT_TB_MASTER_GENDER");
            });

            modelBuilder.Entity<TbAdminRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_ADMIN_ROLE");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.RoleNameEng)
                    .IsRequired()
                    .HasColumnName("ROLE_NAME_ENG")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleNameThai)
                    .IsRequired()
                    .HasColumnName("ROLE_NAME_THAI")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbAdminRoleRegion>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_ADMIN_ROLE_REGION");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdminRoleOid).HasColumnName("ADMIN_ROLE_OID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.MasterRegionOid).HasColumnName("MASTER_REGION_OID");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AdminRoleO)
                    .WithMany(p => p.TbAdminRoleRegion)
                    .HasForeignKey(d => d.AdminRoleOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_ADMIN_ROLE_REGION_TB_ADMIN_ROLE");

                entity.HasOne(d => d.MasterRegionO)
                    .WithMany(p => p.TbAdminRoleRegion)
                    .HasForeignKey(d => d.MasterRegionOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_ADMIN_ROLE_REGION_TB_MASTER_REGION");
            });

            modelBuilder.Entity<TbAdminStatus>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_ADMIN_STATUS");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.StatusNameEng)
                    .IsRequired()
                    .HasColumnName("STATUS_NAME_ENG")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusNameThai)
                    .IsRequired()
                    .HasColumnName("STATUS_NAME_THAI")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TbMasterAmphur>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MASTER_AMPHUR");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AmphurNameThai)
                    .IsRequired()
                    .HasColumnName("AMPHUR_NAME_THAI")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.MasterProvinceOid).HasColumnName("MASTER_PROVINCE_OID");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MasterProvinceO)
                    .WithMany(p => p.TbMasterAmphur)
                    .HasForeignKey(d => d.MasterProvinceOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MASTER_AMPHUR_TB_MASTER_PROVINCE");
            });

            modelBuilder.Entity<TbMasterDistrict>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MASTER_DISTRICT");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.DistrictNameThai)
                    .IsRequired()
                    .HasColumnName("DISTRICT_NAME_THAI")
                    .HasMaxLength(50);

                entity.Property(e => e.MasterAmphurOid).HasColumnName("MASTER_AMPHUR_OID");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("ZIPCODE")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MasterAmphurO)
                    .WithMany(p => p.TbMasterDistrict)
                    .HasForeignKey(d => d.MasterAmphurOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MASTER_DISTRICT_TB_MASTER_AMPHUR");
            });

            modelBuilder.Entity<TbMasterGender>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MASTER_GENDER");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.GenderNameEng)
                    .IsRequired()
                    .HasColumnName("GENDER_NAME_ENG")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderNameThai)
                    .IsRequired()
                    .HasColumnName("GENDER_NAME_THAI")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbMasterPrefix>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MASTER_PREFIX");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.PrefixName)
                    .IsRequired()
                    .HasColumnName("PREFIX_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbMasterProvince>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MASTER_PROVINCE");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.MasterRegionOid).HasColumnName("MASTER_REGION_OID");

                entity.Property(e => e.ProvinceNameThai)
                    .IsRequired()
                    .HasColumnName("PROVINCE_NAME_THAI")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MasterRegionO)
                    .WithMany(p => p.TbMasterProvince)
                    .HasForeignKey(d => d.MasterRegionOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MASTER_PROVINCE_TB_MASTER_REGION");
            });

            modelBuilder.Entity<TbMasterRegion>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MASTER_REGION");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.Orderby).HasColumnName("ORDERBY");

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasColumnName("REGION_CODE")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegionNameThai)
                    .IsRequired()
                    .HasColumnName("REGION_NAME_THAI")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TbMemberAccount>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MEMBER_ACCOUNT");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("BIRTHDATE")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.GenerationId)
                    .IsRequired()
                    .HasColumnName("GENERATION_ID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("LASTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.LecturerFlag).HasColumnName("LECTURER_FLAG");

                entity.Property(e => e.MasterGenderOid).HasColumnName("MASTER_GENDER_OID");

                entity.Property(e => e.MasterPrefixOid).HasColumnName("MASTER_PREFIX_OID");

                entity.Property(e => e.MemberAddressOid).HasColumnName("MEMBER_ADDRESS_OID");

                entity.Property(e => e.MemberCommunityOid).HasColumnName("MEMBER_COMMUNITY_OID");

                entity.Property(e => e.MemberDrinkOid).HasColumnName("MEMBER_DRINK_OID");

                entity.Property(e => e.MemberGenId).HasColumnName("MEMBER_GEN_ID");

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasColumnName("MEMBER_ID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherVolunteerFlag).HasColumnName("OTHER_VOLUNTEER_FLAG");

                entity.Property(e => e.Picture)
                    .HasColumnName("PICTURE")
                    .HasColumnType("image");

                entity.Property(e => e.Talent).HasColumnName("TALENT");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.VolunteerFlag).HasColumnName("VOLUNTEER_FLAG");

                entity.HasOne(d => d.MasterGenderO)
                    .WithMany(p => p.TbMemberAccount)
                    .HasForeignKey(d => d.MasterGenderOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_ACCOUNT_TB_MASTER_GENDER");

                entity.HasOne(d => d.MasterPrefixO)
                    .WithMany(p => p.TbMemberAccount)
                    .HasForeignKey(d => d.MasterPrefixOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_ACCOUNT_TB_MASTER_PREFIX");

                entity.HasOne(d => d.MemberAddressO)
                    .WithMany(p => p.TbMemberAccount)
                    .HasForeignKey(d => d.MemberAddressOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_ACCOUNT_TB_MEMBER_ADDRESS");

                entity.HasOne(d => d.MemberCommunityO)
                    .WithMany(p => p.TbMemberAccount)
                    .HasForeignKey(d => d.MemberCommunityOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_ACCOUNT_TB_MEMBER_COMMUNITY");

                entity.HasOne(d => d.MemberDrinkO)
                    .WithMany(p => p.TbMemberAccount)
                    .HasForeignKey(d => d.MemberDrinkOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_ACCOUNT_TB_MEMBER_DRINK");
            });

            modelBuilder.Entity<TbMemberAddress>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MEMBER_ADDRESS");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressDetail).HasColumnName("ADDRESS_DETAIL");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.MasterAmphurOid).HasColumnName("MASTER_AMPHUR_OID");

                entity.Property(e => e.MasterDistrictOid).HasColumnName("MASTER_DISTRICT_OID");

                entity.Property(e => e.MasterProvinceOid).HasColumnName("MASTER_PROVINCE_OID");

                entity.Property(e => e.MasterRegionOid).HasColumnName("MASTER_REGION_OID");

                entity.Property(e => e.Remark).HasColumnName("REMARK");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MasterAmphurO)
                    .WithMany(p => p.TbMemberAddress)
                    .HasForeignKey(d => d.MasterAmphurOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_ADDRESS_TB_MASTER_AMPHUR");

                entity.HasOne(d => d.MasterDistrictO)
                    .WithMany(p => p.TbMemberAddress)
                    .HasForeignKey(d => d.MasterDistrictOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_ADDRESS_TB_MASTER_DISTRICT");

                entity.HasOne(d => d.MasterProvinceO)
                    .WithMany(p => p.TbMemberAddress)
                    .HasForeignKey(d => d.MasterProvinceOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_ADDRESS_TB_MASTER_PROVINCE");

                entity.HasOne(d => d.MasterRegionO)
                    .WithMany(p => p.TbMemberAddress)
                    .HasForeignKey(d => d.MasterRegionOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_ADDRESS_TB_MASTER_REGION");
            });

            modelBuilder.Entity<TbMemberCommunity>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MEMBER_COMMUNITY");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CommunityNameThai)
                    .IsRequired()
                    .HasColumnName("COMMUNITY_NAME_THAI")
                    .HasMaxLength(50);

                entity.Property(e => e.CommunityRatingOid).HasColumnName("COMMUNITY_RATING_OID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.MasterDistrictOid).HasColumnName("MASTER_DISTRICT_OID");

                entity.Property(e => e.Remark).HasColumnName("REMARK");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CommunityRatingO)
                    .WithMany(p => p.TbMemberCommunity)
                    .HasForeignKey(d => d.CommunityRatingOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_COMMUNITY_TB_MEMBER_COMMUNITY_RATING");

                entity.HasOne(d => d.MasterDistrictO)
                    .WithMany(p => p.TbMemberCommunity)
                    .HasForeignKey(d => d.MasterDistrictOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MEMBER_COMMUNITY_TB_MASTER_DISTRICT");
            });

            modelBuilder.Entity<TbMemberCommunityRating>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MEMBER_COMMUNITY_RATING");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CommunityRatingName)
                    .IsRequired()
                    .HasColumnName("COMMUNITY_RATING_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.Orderby).HasColumnName("ORDERBY");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbMemberDrink>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TB_MEMBER_DRINK");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");

                entity.Property(e => e.StartDrinkEffect)
                    .IsRequired()
                    .HasColumnName("START_DRINK_EFFECT");

                entity.Property(e => e.StartDrinkReason)
                    .IsRequired()
                    .HasColumnName("START_DRINK_REASON");

                entity.Property(e => e.StartDrinkYear).HasColumnName("START_DRINK_YEAR");

                entity.Property(e => e.StopDrinkDate)
                    .HasColumnName("STOP_DRINK_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.StopDrinkHealthEffect)
                    .IsRequired()
                    .HasColumnName("STOP_DRINK_HEALTH_EFFECT");

                entity.Property(e => e.StopDrinkInspiration)
                    .IsRequired()
                    .HasColumnName("STOP_DRINK_INSPIRATION");

                entity.Property(e => e.StopDrinkInviteReason)
                    .IsRequired()
                    .HasColumnName("STOP_DRINK_INVITE_REASON");

                entity.Property(e => e.StopDrinkLifeEffect)
                    .IsRequired()
                    .HasColumnName("STOP_DRINK_LIFE_EFFECT");

                entity.Property(e => e.StopDrinkMostEffect)
                    .IsRequired()
                    .HasColumnName("STOP_DRINK_MOST_EFFECT");

                entity.Property(e => e.StopDrinkOtherEffect)
                    .IsRequired()
                    .HasColumnName("STOP_DRINK_OTHER_EFFECT");

                entity.Property(e => e.StopDrinkSavingEffect)
                    .IsRequired()
                    .HasColumnName("STOP_DRINK_SAVING_EFFECT");

                entity.Property(e => e.StopDrinkTechnic)
                    .IsRequired()
                    .HasColumnName("STOP_DRINK_TECHNIC");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });
        }
    }
}
