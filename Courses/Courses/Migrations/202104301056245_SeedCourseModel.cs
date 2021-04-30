namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCourseModel : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Courses(CourseId, CourseName, Credits, DepartmentId) values(1,'Appdev',4,1)");
            Sql("Insert into Courses(CourseId, CourseName, Credits, DepartmentId) values(2,'Webdev',4,1)");
            Sql("Insert into Courses(CourseId, CourseName, Credits, DepartmentId) values(3,'Database',3,1)");


        }
        
        public override void Down()
        {
        }
    }
}
