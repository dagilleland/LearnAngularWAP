using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngWebForm.Framework.Models
{
    public class Education
    {
        public int EducationID { get; set; }

        public School EducationalInstutue { get; set; }
        public EducationalLevel LevelAchieved { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
