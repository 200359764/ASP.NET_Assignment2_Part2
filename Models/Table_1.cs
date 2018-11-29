namespace High_M_Music_Records.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_1
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
        [Column("Name of Song", Order = 2)]
        [StringLength(50)]
        public string Name_of_Song { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Artist { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }
    }
}
