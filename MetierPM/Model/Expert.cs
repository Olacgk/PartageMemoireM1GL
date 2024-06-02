using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MetierPM.Model
{
    public class Expert:Personne
    {
        [Required, MaxLength(80)]
        public string Specialite { get; set; }
    }
}