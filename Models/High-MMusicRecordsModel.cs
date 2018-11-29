namespace High_M_Music_Records.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class High_MMusicRecordsModel : DbContext
    {
        public High_MMusicRecordsModel()
            : base("name=HighMMusicRecordsModel")
        {
        }

        public virtual DbSet<artistsAlbums> ArtistsAlbums { get; set; }
        public virtual DbSet<dbo> dboes { get; set; }

        internal object Table_1ToList()
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<Table_1> Table_1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<artistsAlbums>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<artistsAlbums>()
                .Property(e => e.Genre)
                .IsUnicode(false);

            modelBuilder.Entity<artistsAlbums>()
                .Property(e => e.Name_of_Song)
                .IsUnicode(false);

            modelBuilder.Entity<artistsAlbums>()
                .Property(e => e.Artist_name)
                .IsUnicode(false);

            modelBuilder.Entity<dbo>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<dbo>()
                .Property(e => e.Name_of_Song)
                .IsUnicode(false);

            modelBuilder.Entity<dbo>()
                .Property(e => e.Artist_name)
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.Genre)
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.Name_of_Song)
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.Artist)
                .IsUnicode(false);
        }
    }
}
