namespace Web_Assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColToSportTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sport", "APISportID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sport", "APISportID");
        }
    }
}
