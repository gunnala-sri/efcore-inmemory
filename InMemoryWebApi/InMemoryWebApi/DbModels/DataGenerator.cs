using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemoryWebApi.DbModels
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<GameDbContext>>()))
            {
                // Look for any board games.
                if (context.Games.Any())
                {
                    return;   // Data was already seeded
                }

                context.Games.AddRange(
                    new Game
                    {
                        ID = 1,
                        Title = "Candy Land",
                        Description = "Hasbro"
                    },
                    new Game
                    {
                        ID = 2,
                        Title = "Sorry!",
                        Description = "Hasbro"
                    });

                context.SaveChanges();
            }
        }
    }
}
