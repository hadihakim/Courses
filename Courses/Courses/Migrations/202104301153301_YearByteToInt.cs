namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YearByteToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admissions", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admissions", "Year", c => c.Byte(nullable: false));
        }
    }
}
