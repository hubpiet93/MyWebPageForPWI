using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebPageForPWI.Models
{
    public class Zdjecie // zamiarem było stworzenie mechanizmu dodawania zdjęć ale miałem ostatnio trochę za mało czasu 
    {
        [Key]
        public int IdZdjecie { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; } // własciwośc wirtualna która dzięki której łatwo się odwołam kto dodał zdjęcie
        public string Tytul { get; set; }
        public string Opis { get; set; }

    }
}