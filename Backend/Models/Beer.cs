﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Beer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BeerID { get; set; }

        public int Name { get; set; }

        public int BrandID { get; set; }

        [ForeignKey("BrandID")]
        public virtual Brand Brand { get; set; }
    }
}
