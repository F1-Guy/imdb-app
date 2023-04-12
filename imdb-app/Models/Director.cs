﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace imdb_app.Models
{
    public partial class Director
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("tconst")]
        [StringLength(10)]
        [Unicode(false)]
        public string Tconst { get; set; }
        [Required]
        [Column("nconst")]
        [StringLength(10)]
        [Unicode(false)]
        public string Nconst { get; set; }

        [ForeignKey("Nconst")]
        [InverseProperty("Directors")]
        public virtual Name NconstNavigation { get; set; }
        [ForeignKey("Tconst")]
        [InverseProperty("Directors")]
        public virtual Title TconstNavigation { get; set; }
    }
}