namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 60),
                        LastName = c.String(nullable: false, maxLength: 60),
                        DateOfBirth = c.DateTime(nullable: false),
                        MajorId = c.Byte(nullable: false),
                        AdmissionTermCode = c.String(maxLength: 9),
                        Major_MajorId = c.Byte(),
                        Major_DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admissions", t => t.AdmissionTermCode)
                .ForeignKey("dbo.Majors", t => new { t.Major_MajorId, t.Major_DepartmentId })
                .Index(t => t.AdmissionTermCode)
                .Index(t => new { t.Major_MajorId, t.Major_DepartmentId });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", new[] { "Major_MajorId", "Major_DepartmentId" }, "dbo.Majors");
            DropForeignKey("dbo.Students", "AdmissionTermCode", "dbo.Admissions");
            DropIndex("dbo.Students", new[] { "Major_MajorId", "Major_DepartmentId" });
            DropIndex("dbo.Students", new[] { "AdmissionTermCode" });
            DropTable("dbo.Students");
        }
    }
}
