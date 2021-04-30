namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMajorModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        MajorId = c.Byte(nullable: false),
                        MajorName = c.String(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MajorId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Majors", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Majors", new[] { "DepartmentId" });
            DropTable("dbo.Majors");
        }
    }
}
