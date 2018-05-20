using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Move2._0.Models;
using Move2._0.Models.Move;
using Move2._0.Models.ShoppingCart;
using Move2._0.Models.PlacementTest;
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

        #region Move
        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Pregunta> Pregunta { get; set; }
        public DbSet<Respuesta> Respuesta { get; set; }
        #endregion

        #region ShoppingCart
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Feature> Feature { get; set; }

        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<Client> Client { get; set; }

        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<Payment> Payment { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }

        #endregion

        #region PlacementTest
        public DbSet<NivelTest> NivelTest { get; set; }
        public DbSet<PreguntasTest> PreguntasTest { get; set; }
        public DbSet<RespuestasTest> RespuestasTest { get; set; }
        public DbSet<PlacementTest> PlacementTest { get; set; }

        #endregion


    }
}