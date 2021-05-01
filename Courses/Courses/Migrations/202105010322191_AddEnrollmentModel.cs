namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEnrollmentModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        StudentId = c.Byte(nullable: false),
                        CourseId = c.Byte(nullable: false),
                        TermCode = c.String(nullable: false, maxLength: 9),
                        MajorId = c.Byte(nullable: false),
                        Grade = c.Int(nullable: false),
                        EnrolledIndicator = c.Boolean(nullable: false),
                        PaymentIndicator = c.Boolean(nullable: false),
                        Admission_AdmissionTermCode = c.String(maxLength: 9),
                        Major_MajorId = c.Byte(),
                        Major_DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => new { t.StudentId, t.CourseId })
                .ForeignKey("dbo.Admissions", t => t.Admission_AdmissionTermCode)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Majors", t => new { t.Major_MajorId, t.Major_DepartmentId })
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId)
                .Index(t => t.Admission_AdmissionTermCode)
                .Index(t => new { t.Major_MajorId, t.Major_DepartmentId });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", new[] { "Major_MajorId", "Major_DepartmentId" }, "dbo.Majors");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Enrollments", "Admission_AdmissionTermCode", "dbo.Admissions");
            DropIndex("dbo.Enrollments", new[] { "Major_MajorId", "Major_DepartmentId" });
            DropIndex("dbo.Enrollments", new[] { "Admission_AdmissionTermCode" });
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropTable("dbo.Enrollments");
        }
    }
}
