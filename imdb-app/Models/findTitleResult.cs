﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace imdb_app.Models
{
    public partial class findTitleResult
    {
        public string tconst { get; set; }
        public string titleType { get; set; }
        public string primaryTitle { get; set; }
        public string originalTitle { get; set; }
        public bool isAdult { get; set; }
        public short? startYear { get; set; }
        public short? endYear { get; set; }
        public int? runtimeMinutes { get; set; }
    }
}