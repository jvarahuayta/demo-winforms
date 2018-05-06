using Dinjo.Base.Domain;
using Dinjo.Base.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Demo.Core.Domain.Shared
{
    public class DbTodosContext: DbContext
    {
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Todo> Todos { get; set; }

        public DbTodosContext(): base()
        {

        }

        public DbSet<T> GetDbSet<T>(DbSetEnum dbSet) where T: Entity
        {
            switch (dbSet)
            {
                case DbSetEnum.TEAM_MEMBERS:
                    return TeamMembers as DbSet<T>;
                case DbSetEnum.ROLES:
                    return Roles as DbSet<T>;
                case DbSetEnum.TODOS:
                    return Todos as DbSet<T>;
            }
            return null;
        }

        public enum DbSetEnum
        {
            TEAM_MEMBERS,
            ROLES,
            TODOS
        }
    }
}
