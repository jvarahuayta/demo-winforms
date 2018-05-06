namespace WinForms.Demo.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatetimeIsNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Todoes", "ExpirationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Todoes", "ExpirationDate", c => c.DateTime(nullable: false));
        }
    }
}
