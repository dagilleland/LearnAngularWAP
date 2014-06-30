using AngWebForm.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngWebForm.Framework.Context
{
    public class ResumeDbContext : IDbContext
    {
        #region Constructors and Properties
        public ResumeDbContext()
        {

        }
        #endregion

        #region IDbContext
        private IQueryable<Resume> _Resumes;
        private IQueryable<User> _Users;
        private IQueryable<WorkExperience> _Jobs;
        private IQueryable<Education> _Training;
        private IQueryable<School> _Schools;
        IQueryable<School> IDbContext.Schools
        {
            get { return _Schools; }
            set { _Schools = value; }
        }
        IQueryable<Education> IDbContext.Training
        {
            get { return _Training; }
            set { _Training = value; }
        }
        IQueryable<WorkExperience> IDbContext.Jobs
        {
            get { return _Jobs; }
            set { _Jobs = value; }
        }
        IQueryable<User> IDbContext.Users
        {
            get { return _Users; }
            set { _Users = value; }
        }
        IQueryable<Resume> IDbContext.Resumes
        {
            get { return _Resumes; }
            set { _Resumes = value; }
        }

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
