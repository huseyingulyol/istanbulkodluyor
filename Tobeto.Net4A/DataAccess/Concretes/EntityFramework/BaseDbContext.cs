using Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace DataAccess.Concretes.EntityFramework
{
    // Veritabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BrandCategory> BrandCategories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3CUTFEI; Database=Tobeto4A2; Trusted_Connection=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasOne(i=>i.Category); //Bir product'ın bir category'si olabilir.
            modelBuilder.Entity<Product>().Property(i=> i.Name).HasColumnName("Name").HasMaxLength(50);

            //Seed Data
            Brand lcwaikiki = new Brand(1, "LC Waikiki", "lc waikiki waikiki");
            Brand vestel = new Brand(2, "Vestel", "vestel sloganı");

            Category category = new Category(1, "Giyim", "Giyim Kategorisi");
            Category category2 = new Category(2, "Elektronik", "Elektronik Kategorisi");

            Product product = new Product(1, "Kazak", 1, 100, 15, "Dünyanın en güzel kazağı",1);
            Product product2 = new Product(2, "Terlik", 1, 50, 15, "Dünyanın en güzel terliği",1);
            Product product3 = new Product(3, "Gaming PC", 2, 5, 75000, "Dünyanın en güzel gaming pc",2);


            modelBuilder.Entity<Brand>().HasData(lcwaikiki);
            modelBuilder.Entity<Brand>().HasData(vestel);

            modelBuilder.Entity<Category>().HasData(category);
            modelBuilder.Entity<Category>().HasData(category2);

            modelBuilder.Entity<Product>().HasData(product);
            modelBuilder.Entity<Product>().HasData(product2);
            modelBuilder.Entity<Product>().HasData(product3);

            modelBuilder.Entity<BrandCategory>().HasKey(pt => new { pt.BrandId, pt.CategoryId });

            modelBuilder.Entity<BrandCategory>().HasOne(pt => pt.Brand)
            .WithMany(p => p.BrandCategories)
            .HasForeignKey(pt => pt.BrandId);

            modelBuilder.Entity<BrandCategory>().HasOne(pt => pt.Category)
            .WithMany(p => p.BrandCategories)
            .HasForeignKey(pt => pt.CategoryId);

            BrandCategory brandCategory = new BrandCategory(1, 1);
            BrandCategory brandCategory2 = new BrandCategory(2, 2);
            modelBuilder.Entity<BrandCategory>().HasData(brandCategory);
            modelBuilder.Entity<BrandCategory>().HasData(brandCategory2);


            base.OnModelCreating(modelBuilder);
        }
    }
}
