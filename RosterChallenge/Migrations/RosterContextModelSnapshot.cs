// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RosterChallenge.ContextClasses;

namespace RosterChallenge.Migrations
{
    [DbContext(typeof(RosterContext))]
    partial class RosterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RosterChallenge.Models.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("paid")
                        .HasColumnType("bit");

                    b.Property<double>("rate")
                        .HasColumnType("float");

                    b.Property<int>("streams")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Artists");
                });
#pragma warning restore 612, 618
        }
    }
}
