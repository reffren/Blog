namespace Wexplorer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newconfig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "UrlPost", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "UrlPost", c => c.String());
        }
    }
}
