using System.Configuration;
using FishAquariumWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Configurations
{
    public class FishAquariumContext : DbContext
    {
        public FishAquariumContext()
        {
        }

        public FishAquariumContext(DbContextOptions<FishAquariumContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aquarium> Aquarium { get; set; }
        public virtual DbSet<AquariumDecoration> AquariumDecoration { get; set; }
        public virtual DbSet<AquariumEquipment> AquariumEquipment { get; set; }
        public virtual DbSet<AquariumTask> AquariumTask { get; set; }
        public virtual DbSet<AquariumUser> AquariumUser { get; set; }
        public virtual DbSet<Decoration> Decoration { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Fish> Fish { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<ItemParameter> ItemParameter { get; set; }
        public virtual DbSet<Portion> Portion { get; set; }
        public virtual DbSet<Supplement> Supplement { get; set; }
        public virtual DbSet<UserTypes> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;

            var connectionString = ConfigurationManager.ConnectionStrings["Database"];
            optionsBuilder.UseMySQL(connectionString.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aquarium>(entity =>
            {
                entity.ToTable("Aquarium", "fish_aquarium");

                entity.HasIndex(e => e.FkPortion)
                    .HasName("Fkc_Portion");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FkPortion)
                    .HasColumnName("Fk_Portion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GlassThickness).HasColumnType("int(11)");
            });

            modelBuilder.Entity<AquariumDecoration>(entity =>
            {
                entity.HasKey(e => new { e.FkDecoration, e.FkAquarium });

                entity.ToTable("AquariumDecoration", "fish_aquarium");

                entity.HasIndex(e => e.FkAquarium)
                    .HasName("Fkc_Aquarium");

                entity.Property(e => e.FkDecoration)
                    .HasColumnName("Fk_decoration")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkAquarium)
                    .HasColumnName("Fk_aquarium")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<AquariumEquipment>(entity =>
            {
                entity.HasKey(e => new { e.FkAquarium, e.FkEquipment });

                entity.ToTable("AquariumEquipment", "fish_aquarium");

                entity.HasIndex(e => e.FkEquipment)
                    .HasName("Fkc_Equipment");

                entity.Property(e => e.FkAquarium)
                    .HasColumnName("Fk_aquarium")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkEquipment)
                    .HasColumnName("Fk_equipment")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<AquariumTask>(entity =>
            {
                entity.ToTable("AquariumTask", "fish_aquarium");

                entity.HasIndex(e => e.FkAquarium)
                    .HasName("Fkc_Aquarium");

                entity.HasIndex(e => e.FkAquariumUser)
                    .HasName("Fkc_AquariumUser");

                entity.HasIndex(e => e.State)
                    .HasName("State");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FkAquarium)
                    .HasColumnName("Fk_Aquarium")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkAquariumUser)
                    .HasColumnName("Fk_AquariumUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("date");

                entity.Property(e => e.State).HasColumnType("int(11)");
            });

            modelBuilder.Entity<AquariumUser>(entity =>
            {
                entity.ToTable("AquariumUser", "fish_aquarium");

                entity.HasIndex(e => e.Type)
                    .HasName("Type");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasColumnType("date");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Decoration>(entity =>
            {
                entity.ToTable("Decoration", "fish_aquarium");

                entity.HasIndex(e => e.Type)
                    .HasName("Type");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.ToTable("Equipment", "fish_aquarium");

                entity.HasIndex(e => e.Type)
                    .HasName("Type");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Fish>(entity =>
            {
                entity.ToTable("Fish", "fish_aquarium");

                entity.HasIndex(e => e.FkAquarium)
                    .HasName("Fkc_Aquarium");

                entity.HasIndex(e => e.Gender)
                    .HasName("Gender");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ArrivalDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FkAquarium)
                    .HasColumnName("Fk_Aquarium")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Gender).HasColumnType("int(11)");

                entity.Property(e => e.LifeExpectancy).HasColumnType("int(11)");

                entity.Property(e => e.Origin)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Species)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("Food", "fish_aquarium");

                entity.HasIndex(e => e.Allergen)
                    .HasName("Allergen");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Allergen).HasColumnType("int(11)");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrepManual)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemParameter>(entity =>
            {
                entity.ToTable("ItemParameter", "fish_aquarium");

                entity.HasIndex(e => e.FkAquarium)
                    .HasName("Fkc_Aquarium");

                entity.HasIndex(e => e.FkFish)
                    .HasName("Fk_Fish")
                    .IsUnique();

                entity.HasIndex(e => e.Type)
                    .HasName("Type");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FkAquarium)
                    .HasColumnName("Fk_Aquarium")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkFish)
                    .HasColumnName("Fk_Fish")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnType("int(11)");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Portion>(entity =>
            {
                entity.ToTable("Portion", "fish_aquarium");

                entity.HasIndex(e => e.FkFood)
                    .HasName("Fkc_Food");

                entity.HasIndex(e => e.FkSupplement)
                    .HasName("Fkc_Supplement");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FkFood)
                    .HasColumnName("Fk_food")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkSupplement)
                    .HasColumnName("Fk_supplement")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PreparationDate).HasColumnType("date");
            });

            modelBuilder.Entity<Supplement>(entity =>
            {
                entity.ToTable("Supplement", "fish_aquarium");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.FoodComposition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Manual)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserTypes>(entity =>
            {
                entity.ToTable("UserTypes", "fish_aquarium");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(7)");
            });
        }
    }
}
