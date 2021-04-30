namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPKMajorModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Majors");
            AddPrimaryKey("dbo.Majors", new[] { "MajorId", "DepartmentId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Majors");
            AddPrimaryKey("dbo.Majors", "MajorId");
        }
    }
}
