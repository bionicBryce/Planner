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
                        OpeningHymn = "God Speed the Right 106",
                        Invocation = "Bro. Kearns",
                        SacramentHymn = "Reverently and Meekly Now 185",
                        FirstSpeaker = "Bro. Stately",
                        SecondSpeaker = "Sis. Morley",
                        RestHymn = "Put Your Shoulder to the Wheel 252",
                        ThirdSpeaker = "Bro. Morley",
                        ClosingHymn = "The Time Is Far Spent 266",
                        Convocation = "Bro. Andrews"

                     },

                      new Sacrament
                      {
                        SacramentDate = DateTime.Parse("1-8-2017"),
                        Conducting = "Bro. Smith",
                        OpeningHymn = "God Speed the Right 106",
                        Invocation = "Sis. Heart",
                        SacramentHymn = "While These Emblems We Partake 173",
                        FirstSpeaker = "Sis. Black",
                        SecondSpeaker = "Sis. Black",
                        RestHymn = "Count Your Blessings 241",
                        ThirdSpeaker = "Bro. Black",
                        ClosingHymn = "God Be With You Till We Meet Again 152",
                        Convocation = "Bro. Burns"

                     },

                     new Sacrament
                     {
                        SacramentDate = DateTime.Parse("1-15-2017"),
                        Conducting = "Bro. Smith",
                        OpeningHymn = "Families Can Be Together Forever",
                        Invocation = "Sis. Traeger",
                        SacramentHymn = "God of Power, God of Right 20",
                        FirstSpeaker = "Bro. Stinely",
                        SecondSpeaker = "Sis. Love",
                        RestHymn = "Home Can Be A Heaven On Earth 298",
                        ThirdSpeaker = "Bro. Hormel",
                        ClosingHymn = "Let Us Oft Speak Kind Words 232",
                        Convocation = "Sis. Yiu"

                     },

                     new Sacrament
                     {
                        SacramentDate = DateTime.Parse("1-22-2017"),
                        Conducting = "Bro. Smith",
                        OpeningHymn = "Who's On The Lords Side 260",
                        Invocation = "Bro. Jenkins",
                        SacramentHymn = "Sweet Hour Of Prayer 142",
                        FirstSpeaker = "Sis. Henley",
                        SecondSpeaker = "Bro. John",
                        RestHymn = "There Is Sunshine In My Soul Today 227",
                        ThirdSpeaker = "Sis. Slade",
                        ClosingHymn = "Now The Day Is Over 159",
                        Convocation = "Bro. Lester"

                     }
                );
                context.SaveChanges();
            }
        }
    }
}
