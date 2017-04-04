namespace Wexplorer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "NameUser", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Comments", "Email", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Comments", "Site", c => c.String(maxLength: 100));
            AlterColumn("dbo.Comments", "PublishedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "PublishedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Comments", "Site", c => c.String());
            AlterColumn("dbo.Comments", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "NameUser", c => c.String(nullable: false));
        }
    }
}
