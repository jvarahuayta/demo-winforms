namespace WinForms.Demo.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFinished : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "finished", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "finished");
        }
    }
}
