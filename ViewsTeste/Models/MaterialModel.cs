using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewsTeste.Models
{
    public class MaterialModel
    {
        public int ID { get; set; }
        [Display(Name = "Pião")]
        public string nome { get; set; }
        public double valor { get; set; }
        public double quantidade { get; set; }
        public string tipo { get; set; }
    }
}
