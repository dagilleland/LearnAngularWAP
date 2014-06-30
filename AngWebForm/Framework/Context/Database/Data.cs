using AngWebForm.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace AngWebForm.Framework.Context.Database
{
    internal static class Data
    {
        public static IEnumerable<School> Schools
        {
            get
            {
                yield return new School() { SchoolID = 1, Name = "" };
            }
        }

        public static IEnumerable<Education> Training
        {
            get
            {
                foreach (var item in Resumes)
                {
                    foreach (var detail in item.EducationalAchievements)
                    {
                        yield return detail;
                    }
                }
                // new Education() { EducationID = 1, Name = "" }
            }
        }

        public static IEnumerable<WorkExperience> Jobs
        {
            get
            {
                foreach (var item in Resumes)
                {
                    foreach (var detail in item.WorkExperience)
                    {
                        yield return detail;
                    }
                }
                // new WorkExperience() { WorkExperienceID = 1, Name = "" }
            }
        }

        public static IEnumerable<User> Users
        {
            get
            {
                yield return new User() { UserID = 1, FirstName = "", LastName = "", DOB = new DateTime() };
            }
        }

        public static IEnumerable<Resume> Resumes
        {
            get
            {
                yield return new Resume() { ResumeID = 1, User = Users.Single(u=>u.LastName.Equals("")) };
            }
        }
    }
}