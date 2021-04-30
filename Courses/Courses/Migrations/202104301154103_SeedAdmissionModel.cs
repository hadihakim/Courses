namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdmissionModel : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Admissions(AdmissionTermCode, Semester, Year) values('202110','fall',2021)");
            Sql("Insert into Admissions(AdmissionTermCode, Semester, Year) values('202120','spring',2021)");
            Sql("Insert into Admissions(AdmissionTermCode, Semester, Year) values('202130','summer',2021)");
        }
        
        public override void Down()
        {
        }
    }
}
