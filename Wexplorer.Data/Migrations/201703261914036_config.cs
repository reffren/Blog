namespace Wexplorer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class config : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String(maxLength: 100));
            AlterColumn("dbo.Posts", "Description", c => c.String(maxLength: 160));
            AlterColumn("dbo.Posts", "PublishedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Posts", "LastModifiedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Posts", "Picture", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Picture", c => c.String());
            AlterColumn("dbo.Posts", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posts", "PublishedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posts", "Description", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
        }
    }
}
