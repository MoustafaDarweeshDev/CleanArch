﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _dbx;
        public CourseRepository(UniversityDBContext dbx)
        {
            _dbx = dbx;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _dbx.Courses;
        }
    }
}
