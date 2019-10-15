using System.Configuration;
using FishAquariumWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Configurations
{
    public partial class FishAquariumContext : DbContext
    {
        public FishAquariumContext()
        {
        }

        public FishAquariumContext(DbContextOptions<FishAquariumContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Allergens> Allergens { get; set; }
        public virtual DbSet<Aquarium> Aquarium { get; set; }
        public virtual DbSet<AquariumInsideHasDecoration> AquariumInsideHasDecoration { get; set; }
        public virtual DbSet<Decoration> Decoration { get; set; }
        //public virtual DbSet<DecorationTypes> DecorationTypes { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentPutInAquarium> EquipmentPutInAquarium { get; set; }
        //public virtual DbSet<EquipmentTypes> EquipmentTypes { get; set; }
        public virtual DbSet<Fish> Fish { get; set; }
        //public virtual DbSet<FishGenderTypes> FishGenderTypes { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<FoodMixedInPortion> FoodMixedInPortion { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        //public virtual DbSet<ParametersTypes> ParametersTypes { get; set; }
        public virtual DbSet<Portion> Portion { get; set; }
        public virtual DbSet<Supplement> Supplement { get; set; }
        public virtual DbSet<SupplementPartOfPortion> SupplementPartOfPortion { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        //public virtual DbSet<TaskStates> TaskStates { get; set; }
        public virtual DbSet<User> User { get; set; }
        //public virtual DbSet<UserTypes> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Database"];
                optionsBuilder.UseMySQL(connectionString.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Allergens>(entity =>
            {
                entity.ToTable("Allergens", "fish_aquarium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(7)");
            });*/

            modelBuilder.Entity<Aquarium>(entity =>
            {
                entity.ToTable("Aquarium", "fish_aquarium");

                entity.HasIndex(e => e.FkPortion)
                    .HasName("Fkc_Portion");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FkPortion)
                    .HasColumnName("Fk_Portion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GlassThickness).HasColumnType("int(11)");
            });

            modelBuilder.Entity<AquariumInsideHasDecoration>(entity =>
            {
                entity.HasKey(e => new { e.FkDecoration, e.FkAquarium });

                entity.ToTable("Aquarium_inside_has_decoration", "fish_aquarium");

                entity.HasIndex(e => e.FkAquarium)
                    .HasName("Fkc_Aquarium");

                entity.Property(e => e.FkDecoration)
                    .HasColumnName("Fk_decoration")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkAquarium)
                    .HasColumnName("Fk_aquarium")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Decoration>(entity =>
            {
                entity.ToTable("Decoration", "fish_aquarium");

                entity.HasIndex(e => e.Type)
                    .HasName("Type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

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

            /*modelBuilder.Entity<DecorationTypes>(entity =>
            {
                entity.ToTable("DecorationTypes", "fish_aquarium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(14)");
            });*/

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.ToTable("Equipment", "fish_aquarium");

                entity.HasIndex(e => e.Type)
                    .HasName("Type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<EquipmentPutInAquarium>(entity =>
            {
                entity.HasKey(e => new { e.FkAquarium, e.FkEquipment });

                entity.ToTable("Equipment_put_in_aquarium", "fish_aquarium");

                entity.HasIndex(e => e.FkEquipment)
                    .HasName("Fkc_Equipment");

                entity.Property(e => e.FkAquarium)
                    .HasColumnName("Fk_aquarium")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkEquipment)
                    .HasColumnName("Fk_equipment")
                    .HasColumnType("int(11)");
            });

            /*modelBuilder.Entity<EquipmentTypes>(entity =>
            {
                entity.ToTable("EquipmentTypes", "fish_aquarium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(11)");
            });*/

            modelBuilder.Entity<Fish>(entity =>
            {
                entity.ToTable("Fish", "fish_aquarium");

                entity.HasIndex(e => e.FkAquarium)
                    .HasName("Fkc_Aquarium");

                entity.HasIndex(e => e.Gender)
                    .HasName("Gender");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

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

            /*modelBuilder.Entity<FishGenderTypes>(entity =>
            {
                entity.ToTable("FishGenderTypes", "fish_aquarium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Male)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(12)");
            });*/

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("Food", "fish_aquarium");

                entity.HasIndex(e => e.Allergen)
                    .HasName("Allergen");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Allergen).HasColumnType("int(11)");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrepManual)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FoodMixedInPortion>(entity =>
            {
                entity.HasKey(e => new { e.FkPortion, e.FkFood });

                entity.ToTable("Food_mixed_in_portion", "fish_aquarium");

                entity.HasIndex(e => e.FkFood)
                    .HasName("Fkc_Food");

                entity.Property(e => e.FkPortion)
                    .HasColumnName("Fk_portion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkFood)
                    .HasColumnName("Fk_food")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Parameters>(entity =>
            {
                entity.ToTable("Parameters", "fish_aquarium");

                entity.HasIndex(e => e.FkAquarium)
                    .HasName("Fkc_Aquarium");

                entity.HasIndex(e => e.FkFish)
                    .HasName("Fk_Fish")
                    .IsUnique();

                entity.HasIndex(e => e.Type)
                    .HasName("Type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

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

            /*modelBuilder.Entity<ParametersTypes>(entity =>
            {
                entity.ToTable("ParametersTypes", "fish_aquarium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(15)");
            });*/

            modelBuilder.Entity<Portion>(entity =>
            {
                entity.ToTable("Portion", "fish_aquarium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreparationDate).HasColumnType("date");
            });

            modelBuilder.Entity<Supplement>(entity =>
            {
                entity.ToTable("Supplement", "fish_aquarium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

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

            modelBuilder.Entity<SupplementPartOfPortion>(entity =>
            {
                entity.HasKey(e => new { e.FkPortion, e.FkSupplement });

                entity.ToTable("Supplement_part_of_portion", "fish_aquarium");

                entity.HasIndex(e => e.FkSupplement)
                    .HasName("Fkc_Supplement");

                entity.Property(e => e.FkPortion)
                    .HasColumnName("Fk_portion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkSupplement)
                    .HasColumnName("Fk_supplement")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.ToTable("Tasks", "fish_aquarium");

                entity.HasIndex(e => e.FkAquarium)
                    .HasName("Fkc_Aquarium");

                entity.HasIndex(e => e.FkUser)
                    .HasName("Fkc_User");

                entity.HasIndex(e => e.State)
                    .HasName("State");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FkAquarium)
                    .HasColumnName("Fk_Aquarium")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkUser)
                    .HasColumnName("Fk_User")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("date");

                entity.Property(e => e.State).HasColumnType("int(11)");
            });

            /*modelBuilder.Entity<TaskStates>(entity =>
            {
                entity.ToTable("TaskStates", "fish_aquarium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(9)");
            });*/

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "fish_aquarium");

                entity.HasIndex(e => e.Type)
                    .HasName("Type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

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

            /*modelBuilder.Entity<UserTypes>(entity =>
            {
                entity.ToTable("UserTypes", "fish_aquarium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(7)");
            });*/
        }
    }
}
