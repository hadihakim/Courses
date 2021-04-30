namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDepartmentModel : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Departments ON Insert into Departments(DepartmentId, DepartmentName) values(1,'CS')");
            Sql("SET IDENTITY_INSERT Departments ON Insert into Departments(DepartmentId, DepartmentName) values(2,'Media')");
            Sql("SET IDENTITY_INSERT Departments ON Insert into Departments(DepartmentId, DepartmentName) values(3,'Business')");
            Sql("SET IDENTITY_INSERT Departments ON Insert into Departments(DepartmentId, DepartmentName) values(4,'EL')");
        }
        
        public override void Down()
        {
        }
    }
}
