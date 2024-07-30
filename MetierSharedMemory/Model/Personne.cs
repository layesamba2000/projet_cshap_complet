using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierSharedMemory.Model
{
    public class Personne
    {
        [Key]
        public int IdPersonne { get; set; }
        [MaxLength(80,ErrorMessage ="Taille max est de 80"),Required(ErrorMessage ="*")]
        [Display(Name ="Nom")]
        public string Nom { get; set; }
        [MaxLength(100, ErrorMessage = "Taille max est de 100"), Required(ErrorMessage = "*")]
        [Display(Name = "Prenom")]
        public string Prenom { get; set; }
    }
}