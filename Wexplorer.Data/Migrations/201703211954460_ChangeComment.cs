namespace Wexplorer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeComment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Post_PostID", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "Post_PostID" });
            RenameColumn(table: "dbo.Comments", name: "Post_PostID", newName: "PostID");
            AlterColumn("dbo.Comments", "PostID", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "PostID");
            AddForeignKey("dbo.Comments", "PostID", "dbo.Posts", "PostID", cascadeDelete: true);
            DropColumn("dbo.Comments", "ArticleID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "ArticleID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Comments", "PostID", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "PostID" });
            AlterColumn("dbo.Comments", "PostID", c => c.Int());
            RenameColumn(table: "dbo.Comments", name: "PostID", newName: "Post_PostID");
            CreateIndex("dbo.Comments", "Post_PostID");
            AddForeignKey("dbo.Comments", "Post_PostID", "dbo.Posts", "PostID");
        }
    }
}
