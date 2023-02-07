using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_cji23.Models
{
    public class GradeCalculatorModel
    {
        // assignments
        [Required]
        [Range(1,100)]
        public float Assignments { get; set; }
        //group
        [Required]
        [Range(1, 100)]
        public float Group { get; set; }
        // quizzes
        [Required]
        [Range(1, 100)]
        public float Quizzes { get; set; }
        // midterms
        [Required]
        [Range(1, 100)]
        public float Midterm { get; set; }
        // final
        [Required]
        [Range(1, 100)]
        public float Final { get; set; }
        // intex
        [Required]
        [Range(1, 100)]
        public float Intex { get; set; }
    }
}
