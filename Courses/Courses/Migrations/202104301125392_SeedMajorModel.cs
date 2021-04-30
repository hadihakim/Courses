namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMajorModel : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Majors(MajorId, MajorName, DepartmentId) values(1,'Computing',1)");
            Sql("Insert into Majors(MajorId, MajorName, DepartmentId) values(2,'Network and Security',1)");
            Sql("Insert into Majors(MajorId, MajorName, DepartmentId) values(3,'Data science',1)");
            
        }
        
        public override void Down()
        {
        }
    }
}
