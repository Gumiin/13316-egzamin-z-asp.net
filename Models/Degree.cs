using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13316_egzamin_z_asp.net.Models
{
    public class Degree
    {

        public int Index { get; set; }
        [Required]
        public double Grade { get; set; }
        public List<double> AvregeGrade { get; set; }

        public string Subject { get; set; }

        

    }
}
