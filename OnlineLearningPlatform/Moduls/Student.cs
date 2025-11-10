using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.OnlineLearningPlatform.Moduls
{
    public class Student
    {
        public int StudentId { get; set; }
        public string  FullName { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public List<Cources> cources { get; set; } = new List<Cources>();

    }
}
