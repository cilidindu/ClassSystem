﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassCoustmer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CourseManagerEntities2 : DbContext
    {
        public CourseManagerEntities2()
            : base("name=CourseManagerEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<CourseArrange> CourseArrange { get; set; }
        public virtual DbSet<CourseSubeject> CourseSubeject { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
    }
}
