namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStudentModel : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Students(Id, FirstName, LastName, DateOfBirth, MajorId, AdmissionTermCode ) values(1,'hadi', 'hakim','2-2-2000',1,'202110')");
            Sql("Insert into Students(Id, FirstName, LastName, DateOfBirth, MajorId, AdmissionTermCode ) values(2,'jamal', 'hakim','2-5-2000',1,'202110')");
            Sql("Insert into Students(Id, FirstName, LastName, DateOfBirth, MajorId, AdmissionTermCode ) values(3,'hadi', 'daher','1-2-1999',2,'202110')");
            Sql("Insert into Students(Id, FirstName, LastName, DateOfBirth, MajorId, AdmissionTermCode ) values(4,'samir', 'mhmd','4-6-2001',3,'202120')");
            
        }
        
        public override void Down()
        {
        }
    }
}
