using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebPageForPWI.Models
{
    public class Zdjecie
    {
        [Key]
        public int IdZdjecie { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
    }
}