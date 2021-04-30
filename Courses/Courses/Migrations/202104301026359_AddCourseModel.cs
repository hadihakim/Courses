namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Byte(nullable: false),
                        CourseName = c.String(nullable: false),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
