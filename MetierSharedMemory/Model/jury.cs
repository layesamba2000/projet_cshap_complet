﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierSharedMemory.Model
{
    public class jury:Personne
    {
        [MaxLength(20, ErrorMessage = "Taille max est de 20"), Required(ErrorMessage = "*")]
        [Display(Name = "Grade membre du jury")]
        public string Grade { get; set; }
        [MaxLength(50, ErrorMessage = "Taille max est de 50"), Required(ErrorMessage = "*")]
        [Display(Name = "Specialite membre du jury")]
        public string Specialite { get; set; }
        //public virtual ICollection<Memoire> Memoires { get; set; }
    }
}