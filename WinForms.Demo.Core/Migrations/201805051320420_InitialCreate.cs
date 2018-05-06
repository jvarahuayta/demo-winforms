namespace WinForms.Demo.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Modified = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Active = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamMembers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Modified = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Active = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ExpirationDate = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Active = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamMemberRoles",
                c => new
                    {
                        TeamMember_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamMember_Id, t.Role_Id })
                .ForeignKey("dbo.TeamMembers", t => t.TeamMember_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.TeamMember_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.TodoRoles",
                c => new
                    {
                        Todo_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Todo_Id, t.Role_Id })
                .ForeignKey("dbo.Todoes", t => t.Todo_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Todo_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.TodoTeamMembers",
                c => new
                    {
                        Todo_Id = c.Int(nullable: false),
                        TeamMember_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Todo_Id, t.TeamMember_Id })
                .ForeignKey("dbo.Todoes", t => t.Todo_Id, cascadeDelete: true)
                .ForeignKey("dbo.TeamMembers", t => t.TeamMember_Id, cascadeDelete: true)
                .Index(t => t.Todo_Id)
                .Index(t => t.TeamMember_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TodoTeamMembers", "TeamMember_Id", "dbo.TeamMembers");
            DropForeignKey("dbo.TodoTeamMembers", "Todo_Id", "dbo.Todoes");
            DropForeignKey("dbo.TodoRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.TodoRoles", "Todo_Id", "dbo.Todoes");
            DropForeignKey("dbo.TeamMemberRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.TeamMemberRoles", "TeamMember_Id", "dbo.TeamMembers");
            DropIndex("dbo.TodoTeamMembers", new[] { "TeamMember_Id" });
            DropIndex("dbo.TodoTeamMembers", new[] { "Todo_Id" });
            DropIndex("dbo.TodoRoles", new[] { "Role_Id" });
            DropIndex("dbo.TodoRoles", new[] { "Todo_Id" });
            DropIndex("dbo.TeamMemberRoles", new[] { "Role_Id" });
            DropIndex("dbo.TeamMemberRoles", new[] { "TeamMember_Id" });
            DropTable("dbo.TodoTeamMembers");
            DropTable("dbo.TodoRoles");
            DropTable("dbo.TeamMemberRoles");
            DropTable("dbo.Todoes");
            DropTable("dbo.TeamMembers");
            DropTable("dbo.Roles");
        }
    }
}
