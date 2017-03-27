namespace CloudLogistic.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Common;
    using Interfaces;
    using System.Data.Entity.Infrastructure;

    public partial class CLContext : DbContext, IContext
    {
        public CLContext()
            : base("name=DefaultConnection")
        {

        }
        public CLContext(string connectionName) : base(connectionName)
        {

        }

        public CLContext(DbConnection conn)
            : base(conn, true)
        {

        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Organisations> Organisations { get; set; }
        public virtual DbSet<OrganisationsMembers> OrganisationsMembers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);
        }

        public void Commit()
        {
            if (this.ChangeTracker.Entries().Any(IsChanged))
            {
                this.SaveChanges();
            }

        }


        public void MarkUpdated<T>(T entity) where T : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        public void MarkDeleted<T>(T entity) where T : class
        {
            Entry(entity).State = EntityState.Deleted;
        }

        public void MarkAdded<T>(T entity) where T : class
        {
            Entry(entity).State = EntityState.Added;
        }


        private static bool IsChanged(DbEntityEntry entity)
        {
            return IsStateEqual(entity, EntityState.Added) ||
                   IsStateEqual(entity, EntityState.Deleted) ||
                   IsStateEqual(entity, EntityState.Modified);
        }

        private static bool IsStateEqual(DbEntityEntry entity, EntityState state)
        {
            return (entity.State & state) == state;
        }

    }
}
