using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreWithIdentity.Areas.Identity.Seeds
{
    public class SeedingData
    {
        public static async Task ExecAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            try
            {
                await DefaultRoles.SeedAsync(userManager, roleManager);
                await DefaultUsers.SeedBasicUserAsync(userManager, roleManager);
                await DefaultUsers.SeedSuperAdminAsync(userManager, roleManager);
                Console.WriteLine("seeding is done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString(), "An error occurred seeding the DB");
            }
        }
    }
}
