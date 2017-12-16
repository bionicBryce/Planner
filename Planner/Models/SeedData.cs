using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Planner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlannerContext(
                serviceProvider.GetRequiredService<DbContextOptions<PlannerContext>>()))
            {
                // Look for any movies.
                if (context.Sacrament.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sacrament
                    .AddRange(
                     new Sacrament
                     {
                        SacramentDate = DateTime.Parse("2017-1-1"),
                        Conducting = "Bro. Smith",
                        Hymns = "God Speed the Right 106"
                               + "Reverently and Meekly Now 185"
                               + "Put Your Shoulder to the Wheel 252"
                               + "The Time Is Far Spent 266"  ,
                        Prayer = "Bro. Kearns"
                               + "Bro. Andrews"  ,
                        Speakers = "Bro. Stately"
                                 + "Sis. Morley"
                                 + "Bro. Morley",
                        Subject = "October Conference Talk",

                     },

                      new Sacrament
                      {
                        SacramentDate = DateTime.Parse("1-8-2017"),
                        Conducting = "Bro. Smith",
                        Hymns = "God Speed the Right 106"
                                + "While These Emblems We Partake 173"
                                + "Count Your Blessings 241"
                                + "God Be With You Till We Meet Again 152" ,
                        Prayer = "Sis. Heart"
                                + "Bro. Burns" ,
                        Speakers = "Sis. Black"
                                + "Sis. Black"
                                + "Bro. Black",
                        Subject = "Faith",

                     },

                     new Sacrament
                     {
                        SacramentDate = DateTime.Parse("1-15-2017"),
                        Conducting = "Bro. Smith",
                        Hymns = "Families Can Be Together Forever"
                                + "God of Power, God of Right 20"
                                + "Home Can Be A Heaven On Earth 298"
                                + "Let Us Oft Speak Kind Words 232" ,
                        Prayer = "Sis. Traeger"
                                + "Sis. Yiu",
                        Speakers = "Bro. Stinely"
                                  + "Sis. Love" 
                                  + "Bro. Love",
                        Subject = "Repentance",

                     },

                     new Sacrament
                     {
                        SacramentDate = DateTime.Parse("1-22-2017"),
                        Conducting = "Bro. Smith",
                        Hymns = "Who's On The Lords Side 260"
                                + "Sweet Hour Of Prayer 142"
                                + "There Is Sunshine In My Soul Today 227"
                                + "Now The Day Is Over 159",
                        Prayer = "Bro. Jenkins, "
                                + "Sis. Jenkins" ,
                        Speakers = "Sis. Henley"  
                                   + "Bro. John"  
                                   + "Bro. Lester",
                        Subject = "Prayer",

                     }
                );
                context.SaveChanges();
            }
        }
    }
}
