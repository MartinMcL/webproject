namespace Web_Assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedRelationships : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Atricle", newName: "Article");
            DropForeignKey("dbo.Sport", "Article_ID", "dbo.Atricle");
            DropForeignKey("dbo.Sport", "User_ID", "dbo.User");
            DropIndex("dbo.Sport", new[] { "Article_ID" });
            DropIndex("dbo.Sport", new[] { "User_ID" });
            RenameColumn(table: "dbo.Article", name: "Sport", newName: "SportID");
            RenameColumn(table: "dbo.User", name: "Sport", newName: "SportID");
            RenameIndex(table: "dbo.Article", name: "IX_Sport", newName: "IX_SportID");
            RenameIndex(table: "dbo.User", name: "IX_Sport", newName: "IX_SportID");
            DropColumn("dbo.Sport", "Article_ID");
            DropColumn("dbo.Sport", "User_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sport", "User_ID", c => c.Int());
            AddColumn("dbo.Sport", "Article_ID", c => c.Int());
            RenameIndex(table: "dbo.User", name: "IX_SportID", newName: "IX_Sport");
            RenameIndex(table: "dbo.Article", name: "IX_SportID", newName: "IX_Sport");
            RenameColumn(table: "dbo.User", name: "SportID", newName: "Sport");
            RenameColumn(table: "dbo.Article", name: "SportID", newName: "Sport");
            CreateIndex("dbo.Sport", "User_ID");
            CreateIndex("dbo.Sport", "Article_ID");
            AddForeignKey("dbo.Sport", "User_ID", "dbo.User", "ID");
            AddForeignKey("dbo.Sport", "Article_ID", "dbo.Atricle", "ID");
            RenameTable(name: "dbo.Article", newName: "Atricle");
        }
    }
}
