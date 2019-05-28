using Microsoft.AspNetCore.Mvc.Rendering;
using StudentExerciseAPI.Models;
using StudentExercisesMVC.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentEditViewModel
    {
        // A single student
        public Student Student { get; set; } = new Student();

        // All cohorts
        public List<SelectListItem> Cohorts;

        public SqlConnection Connection;


        public StudentEditViewModel() { }

        public StudentEditViewModel(int id)
        {
            Student = StudentRepository.GetStudent(id);
            BuildCohortOptions();
        }

        public void BuildCohortOptions()
        {
            Cohorts = CohortRepository.GetCohorts()
                .Select(li => new SelectListItem
                {
                    Text = li.cohortName,
                    Value = li.Id.ToString()
                }).ToList();

            Cohorts.Insert(0, new SelectListItem
            {
                Text = "Choose cohort...",
                Value = "0"
            });
        }

    }
}

