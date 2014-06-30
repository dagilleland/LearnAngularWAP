using AngWebForm.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngWebForm.Framework.Context
{
    public interface IDbContext
    {
        IQueryable<School> Schools { get; set; }
        IQueryable<Education> Training { get; set; }
        IQueryable<WorkExperience> Jobs { get; set; }
        IQueryable<User> Users { get; set; }
        IQueryable<Resume> Resumes { get; set; }

        void SaveChanges();
    }
}
