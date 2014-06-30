using AngWebForm.Framework.Context.Database;
using AngWebForm.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AngWebForm.Framework.Context
{
    public class ResumeDbContext : IDbContext
    {
        #region Constructors and Properties
        private const string KEY_Resumes = "KEY_Resumes";
        private const string KEY_Users = "KEY_Users";
        private const string KEY_Jobs = "KEY_Jobs";
        private const string KEY_Training = "KEY_Training";
        private const string KEY_Schools = "KEY_Schools";

        public ResumeDbContext()
        {
            Schools = HttpRuntime.Cache[KEY_Schools] as IQueryable<School>;
            if (Schools == null)
                Schools = ResetCache<School>(KEY_Schools, Data.Schools.AsQueryable());

            Training = HttpRuntime.Cache[KEY_Training] as IQueryable<Education>;
            if (Training == null)
                Training = ResetCache<Education>(KEY_Training, Data.Training.AsQueryable());

            Jobs = HttpRuntime.Cache[KEY_Jobs] as IQueryable<WorkExperience>;
            if (Jobs == null)
                Jobs = ResetCache<WorkExperience>(KEY_Jobs, Data.Jobs.AsQueryable());

            Users = HttpRuntime.Cache[KEY_Users] as IQueryable<User>;
            if (Users == null)
                Users = ResetCache<User>(KEY_Users, Data.Users.AsQueryable());

            Resumes = HttpRuntime.Cache[KEY_Resumes] as IQueryable<Resume>;
            if (Resumes == null)
                Resumes = ResetCache<Resume>(KEY_Resumes, Data.Resumes.AsQueryable());
        }

        private IQueryable<T> ResetCache<T>(string key, IQueryable<T> data)
        {
            HttpRuntime.Cache.Add(key, data, null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 15), System.Web.Caching.CacheItemPriority.Default, null);
            return data;
        }
        #endregion

        #region IDbContext
        public IQueryable<School> Schools { get; set; }
        public IQueryable<Education> Training { get; set; }
        public IQueryable<WorkExperience> Jobs { get; set; }
        public IQueryable<User> Users { get; set; }
        public IQueryable<Resume> Resumes { get; set; }

        void IDbContext.SaveChanges()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
        }
        #endregion
    }
}
