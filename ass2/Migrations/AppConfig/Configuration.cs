namespace ass2.Migrations.AppConfig
{
    using ass2.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ass2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations/AppConfig";
        }

        protected override void Seed(ass2.Models.ApplicationDbContext context)
        {
            var um = new ApplicationUserManager( new UserStore<ApplicationUser>(context) );
            var rm = new RoleManager<IdentityRole>( new RoleStore<IdentityRole>(context) );

            string[] roles = { "Administrator", "Worker", "Reporter" };
            string[] names = { "adam@gs.ca", "wendy@gs.ca", "rob@gs.ca" };

            foreach (string role in roles)
                if (!rm.RoleExists(role))
                    rm.Create( new IdentityRole( role ) );

            int i = 0;
            ApplicationUser user;
            foreach( string name in names )
            {
                user = new ApplicationUser();
                user.UserName = name;
                um.AddToRole(user.Id, roles[i++]);
            }
        }
    }
}
