namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdmissionModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admissions",
                c => new
                    {
                        AdmissionTermCode = c.String(nullable: false, maxLength: 9),
                        Semester = c.String(nullable: false, maxLength: 9),
                        Year = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.AdmissionTermCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admissions");
        }
    }
}
