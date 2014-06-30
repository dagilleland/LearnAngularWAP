using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngWebForm.Framework.Models
{
    public class Resume
    {
        public int ResumeID { get; set; }

        public ResumeStatus Status { get; set; }

        public User User { get; set; }
        public ICollection<Education> EducationalAchievements { get; set; }
        public ICollection<WorkExperience> WorkExperience { get; set; }
    }
}
