namespace CloudLogistic.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Common;
    using Interfaces;
    using System.Data.Entity.Infrastructure;
    using System.Data;

    public partial class DatabaseContext : DbContext, IContext
    {
        public DatabaseContext()
            : base("name=DefaultConnection")
        {

        }

        public DatabaseContext(DbConnection con) : base(con, true)
        {

        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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

        public void ChangeState<T>(T entity, EntityState state) where T : class
        {
            Entry<T>(entity).State = state;
        }

        public IDbSet<T> GetEntitySet<T>()
        where T : class
        {
            return Set<T>();
        }

        public virtual int Commit()
        {
            if (this.ChangeTracker.Entries().Any(IsChanged))
            {
                return this.SaveChanges();
            }
            return 0;
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

        public virtual DbTransaction BeginTransaction()
        {
            var connection = (this as IObjectContextAdapter).ObjectContext.Connection;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            return connection
                .BeginTransaction(IsolationLevel.ReadCommitted);
        }
    }
}
