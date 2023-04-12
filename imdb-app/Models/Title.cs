﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace imdb_app.Models
{
    [Index("PrimaryTitle", Name = "primaryTitle_index")]
    public partial class Title
    {
        public Title()
        {
            Directors = new HashSet<Director>();
            Genres = new HashSet<Genre>();
            KnownForTitles = new HashSet<KnownForTitle>();
            Writers = new HashSet<Writer>();
        }

        [Key]
        [Column("tconst")]
        [StringLength(10)]
        [Unicode(false)]
        public string Tconst { get; set; }
        [Required]
        [Column("titleType")]
        [StringLength(50)]
        [Unicode(false)]
        public string TitleType { get; set; }
        [Required]
        [Column("primaryTitle")]
        [StringLength(500)]
        [Unicode(false)]
        public string PrimaryTitle { get; set; }
        [Required]
        [Column("originalTitle")]
        [StringLength(500)]
        [Unicode(false)]
        public string OriginalTitle { get; set; }
        [Column("isAdult")]
        public bool IsAdult { get; set; }
        [Column("startYear")]
        public short? StartYear { get; set; }
        [Column("endYear")]
        public short? EndYear { get; set; }
        [Column("runtimeMinutes")]
        public int? RuntimeMinutes { get; set; }

        [InverseProperty("TconstNavigation")]
        public virtual ICollection<Director> Directors { get; set; }
        [InverseProperty("TconstNavigation")]
        public virtual ICollection<Genre> Genres { get; set; }
        [InverseProperty("TconstNavigation")]
        public virtual ICollection<KnownForTitle> KnownForTitles { get; set; }
        [InverseProperty("TconstNavigation")]
        public virtual ICollection<Writer> Writers { get; set; }
    }
}