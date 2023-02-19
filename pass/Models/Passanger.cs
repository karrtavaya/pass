using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pass.Models
{
    internal class Passanger
    {
        [Key]
        public int IdPassanger { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
