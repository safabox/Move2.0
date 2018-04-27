using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Move2._0.Models;
using Move2._0.Models.Move;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Move2._0.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<IdentityUser>().ToTable("user");
            //modelBuilder.Entity<ApplicationUser>().ToTable("user");
            //modelBuilder.Entity<IdentityRole>().ToTable("role");
            //modelBuilder.Entity<IdentityUserRole>().ToTable("userrole");
            //modelBuilder.Entity<IdentityUserClaim>().ToTable("userclaim");
            //modelBuilder.Entity<IdentityUserLogin>().ToTable("userlogin");
        }

        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Pregunta> Pregunta { get; set; }
        public DbSet<Respuesta> Respuesta { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Feature> Feature { get; set; }




    }
}