namespace UniversityManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smallfix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ApplicationUserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ApplicationUserId");
        }
    }
}
