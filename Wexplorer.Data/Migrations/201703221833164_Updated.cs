namespace Wexplorer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "NameUser", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "Commentary", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "Commentary", c => c.String());
            AlterColumn("dbo.Comments", "Email", c => c.String());
            AlterColumn("dbo.Comments", "NameUser", c => c.String());
        }
    }
}
