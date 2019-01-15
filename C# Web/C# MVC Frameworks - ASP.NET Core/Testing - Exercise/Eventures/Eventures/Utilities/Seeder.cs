using Eventures.Data;
using Eventures.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Eventures.Utilities
{
    public static class Seeder
    {
        public static void Seed(IServiceProvider provider)
        {
            var roleManager = provider.GetService<RoleManager<IdentityRole>>();
            SeedRoles(roleManager);

            var dbContext = provider.GetRequiredService<EventuresDbContext>();
            SeedEvents(dbContext);
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
                roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();

            if (!roleManager.RoleExistsAsync("User").Result)
                roleManager.CreateAsync(new IdentityRole("User")).GetAwaiter().GetResult();
        }

        private static void SeedEvents(EventuresDbContext dbContext)
        {
            if (dbContext.Events.Count() != 0)
                return;

            for (int i = 0; i < 14; i++)
            {
                var @event = new Event
                {
                    End = DateTime.UtcNow.AddHours(2),
                    Name = "event" + i,
                    Place = "place" + i,
                    PricePerTicket = i + 100,
                    Start = DateTime.UtcNow,
                    TotalTickets = i + 1000,
                };

                dbContext.Events.Add(@event);
            }
            
            dbContext.SaveChanges();
        }
    }
}
