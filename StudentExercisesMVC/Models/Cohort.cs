using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExerciseAPI.Models
{
    public class Cohort
    {
        public int Id { get; set; }
        [Display(Name = "Cohort Name")]
        public string cohortName { get; set; }
    }
}
