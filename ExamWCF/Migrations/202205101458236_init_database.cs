namespace ExamWCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_database : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Employee", newName: "Employees");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Employees", newName: "Employee");
        }
    }
}
