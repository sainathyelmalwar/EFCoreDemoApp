﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFLibrary.Models
{
    public class Email
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar(50)")]
        public string EmailAddress { get; set; }
    }
}
