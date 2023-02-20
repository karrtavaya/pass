using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace pass.Models
{
    internal class Point
    {
        [Key]
        public int IdPoint { get; set; } 
        public string Value { get; set; }
    }
}
