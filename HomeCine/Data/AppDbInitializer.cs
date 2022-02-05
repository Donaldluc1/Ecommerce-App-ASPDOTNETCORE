using HomeCine.Data.Static;
using HomeCine.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCine.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the second Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the 3 Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the 4 Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the 5 Cinema"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the third actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the forth actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the Producer 1",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the Producer 2",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the Producer 3",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the Producer 4",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the Producer 4",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-4.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie 1",
                            Description = "This is the Scoob Movie description",
                            Price = 35.50,
                            ImgUrl = "https://dotnethow.net/images/movies/movie-1.jpeg",
                            StarteDate = DateTime.Now.AddDays(-10),
                            EndDtate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Movie 2",
                            Description = "This is the Movie 2 description",
                            Price = 43.50,
                            ImgUrl = "https://dotnethow.net/images/movies/movie-2.jpeg",
                            StarteDate = DateTime.Now.AddDays(-10),
                            EndDtate = DateTime.Now.AddDays(-5),
                            CinemaId = 2,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Movie 3",
                            Description = "This is the Movie 3 description",
                            Price = 55.50,
                            ImgUrl = "https://dotnethow.net/images/movies/movie-3.jpeg",
                            StarteDate = DateTime.Now.AddDays(-10),
                            EndDtate = DateTime.Now.AddDays(-1),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Movie 4",
                            Description = "This is the Movie 4 description",
                            Price = 75.50,
                            ImgUrl = "https://dotnethow.net/images/movies/movie-4.jpeg",
                            StarteDate = DateTime.Now.AddDays(-10),
                            EndDtate = DateTime.Now.AddDays(-2),
                            CinemaId = 5,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Movie 5",
                            Description = "This is the Movie 5 description",
                            Price = 60.00,
                            ImgUrl = "https://dotnethow.net/images/movies/movie-5.jpeg",
                            StarteDate = DateTime.Now.AddDays(-10),
                            EndDtate = DateTime.Now.AddDays(-3),
                            CinemaId = 4,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Movie 6",
                            Description = "This is the Movie 6 description",
                            Price = 36.50,
                            ImgUrl = "https://dotnethow.net/images/movies/movie-6.jpeg",
                            StarteDate = DateTime.Now.AddDays(-6),
                            EndDtate = DateTime.Now.AddDays(-1),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Movie 7",
                            Description = "This is the Movie 7 description",
                            Price = 23.90,
                            ImgUrl = "https://dotnethow.net/images/movies/movie-7.jpeg",
                            StarteDate = DateTime.Now.AddDays(-10),
                            EndDtate = DateTime.Now.AddDays(-1),
                            CinemaId = 1,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Movie 8",
                            Description = "This is the  Movie 8 description",
                            Price = 35.50,
                            ImgUrl = "https://dotnethow.net/images/movies/movie-.jpeg",
                            StarteDate = DateTime.Now.AddDays(-10),
                            EndDtate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 4
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
        
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@homecine.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appnUserEmail = "user@homecine.com";

                var appUser = await userManager.FindByEmailAsync(appnUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appnUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }

            }
        }

    }
}
