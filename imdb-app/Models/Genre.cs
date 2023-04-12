﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace imdb_app.Models
{
    public partial class Genre
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("genre")]
        [StringLength(50)]
        [Unicode(false)]
        public string Genre1 { get; set; }
        [Column("tconst")]
        [StringLength(10)]
        [Unicode(false)]
        public string Tconst { get; set; }

        [ForeignKey("Tconst")]
        [InverseProperty("Genres")]
        public virtual Title TconstNavigation { get; set; }
    }
}