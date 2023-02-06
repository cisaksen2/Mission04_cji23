using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_cji23.Models
{
    public class GradeCalculatorModel
    {
        [Required]
        [Range(1,100)]
        public float Assignments { get; set; }
        [Required]
        [Range(1, 100)]
        public float Group { get; set; }
        [Required]
        [Range(1, 100)]
        public float Quizzes { get; set; }
        [Required]
        [Range(1, 100)]
        public float Midterm { get; set; }
        [Required]
        [Range(1, 100)]
        public float Final { get; set; }
        [Required]
        [Range(1, 100)]
        public float Intex { get; set; }
    }
}
