using Entities.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace StudyListApi.Data
{
    public class StudyListDbContext : IdentityDbContext<Teacher>
    {
        public StudyListDbContext(DbContextOptions<StudyListDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //aspnetusers
            base.OnModelCreating(builder);
            builder.Entity<Teacher>(entity =>
            {
                entity.ToTable(name: "Teacher");
            });

            //aspnetroles
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "TeacherRoles");
            });

            //aspnetuserroles
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("TeacherUserRoles");
                //in case you chagned the TKey type
                //  entity.HasKey(key => new { key.UserId, key.RoleId });
            });

            //aspnetuserclaims
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("TeacherUserClaims");
            });

            //aspnetuserlogins
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("TeacherUserLogins");
                //in case you chagned the TKey type
                //  entity.HasKey(key => new { key.ProviderKey, key.LoginProvider });       
            });

            //aspnetroleclaims
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("TeacherRoleClaims");
            });

            //aspnetusertokens
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("TeacherUserTokens");
                //in case you chagned the TKey type
                // entity.HasKey(key => new { key.UserId, key.LoginProvider, key.Name });
            });

        }


        internal object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public DbSet<Student> Student { get; set; }


    }
}
