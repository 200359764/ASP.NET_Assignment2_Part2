namespace High_M_Music_Records.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtistsAlbum")]
    public partial class artistsAlbums
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Genre { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Name_of_Song { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Artist_name { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year_of_Release { get; set; }

        internal static string ToList()
        {
            throw new NotImplementedException();
        }

        public static implicit operator string(artistsAlbums v)
        {
            throw new NotImplementedException();
        }

        public static object OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
