using BirthdayRegister.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayRegister.Models
{
    public class CoursePersonViewModel
    {
        public Course course { get; set; }
        public List<Student> students { get; set; }
    }
}
