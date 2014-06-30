using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngWebForm.Framework.Models
{
    public class WorkExperience
    {
        public int WorkExperienceID { get; set; }

        public string Employer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
