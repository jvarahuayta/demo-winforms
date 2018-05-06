namespace WinForms.Demo.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WinForms.Demo.Core.Domain.Shared.DbTodosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WinForms.Demo.Core.Domain.Shared.DbTodosContext";
        }

        protected override void Seed(WinForms.Demo.Core.Domain.Shared.DbTodosContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
