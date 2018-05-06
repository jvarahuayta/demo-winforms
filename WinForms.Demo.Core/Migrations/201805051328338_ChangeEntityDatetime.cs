namespace WinForms.Demo.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEntityDatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Roles", "Modified", c => c.DateTime());
            AlterColumn("dbo.Roles", "Created", c => c.DateTime());
            AlterColumn("dbo.TeamMembers", "Modified", c => c.DateTime());
            AlterColumn("dbo.TeamMembers", "Created", c => c.DateTime());
            AlterColumn("dbo.Todoes", "Modified", c => c.DateTime());
            AlterColumn("dbo.Todoes", "Created", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Todoes", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Todoes", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TeamMembers", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TeamMembers", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Roles", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Roles", "Modified", c => c.DateTime(nullable: false));
        }
    }
}
