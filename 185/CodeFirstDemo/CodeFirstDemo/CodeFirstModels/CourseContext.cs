﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.CodeFirstModels
{
    /// <summary>
    /// 数据上下文 映射到DB
    /// </summary>
   public  class CourseContext:DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}
