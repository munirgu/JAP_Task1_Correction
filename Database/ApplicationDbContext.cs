using JAP_Task_Backend.Entities;
using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace JAP_Task_Backend.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Actor> VideoActors { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<TopTenMoviesByRatings> TopTenMoviesByRatings { get; set; }
        public DbSet<TopTenMoviesByScreenings> TopTenMoviesByScreenings { get; set; }
        public DbSet<TopMoviesByMostSoldTickets> TopMoviesByMostSoldTickets { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Videos Data
            modelBuilder.Entity<Video>().HasData(
                /// Movies
                new Video
                {
                    Id = 1,
                    Title = "Saving Private Ryan",
                    Description = "Saving Private Ryan is a 1998 American epic war film directed by Steven Spielberg and written by Robert Rodat. Set during the Invasion of Normandy in World War II, the film is known for its graphic portrayal of war, especially its depiction of the Omaha Beach assault during the Normandy landings.",
                    ReleaseDate = new DateTime(1998, 7, 21),
                    Type = VideoType.Movie,
                    ImageUrl = "https://fanart.tv/fanart/movies/857/movieposter/saving-private-ryan-521a5ad8ab73e.jpg",

                },


                new Video
                {
                    Id = 2,
                    Title = "Inception",
                    Description = "Dominic Cobb is an industrial spy who instead of breaking into a person's home, office, or even computer, gets the information he needs by getting into the person's mind through their dreams.",
                    ReleaseDate = new DateTime(2010, 7, 22),
                    Type = VideoType.Movie,
                    ImageUrl = "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg"

                },

                 new Video
                 {
                     Id = 3,
                     Title = "The Witcher",
                     Description = "The witcher Geralt, a mutated monster hunter, struggles to find his place in a world in which people often prove more wicked than beasts.",
                     ReleaseDate = new DateTime(2019, 12, 20),
                     Type = VideoType.Movie,
                     ImageUrl = "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg"

                 },


                 new Video
                 {
                     Id = 4,
                     Title = "Forrest Gump",
                     Description = "Forrest Gump is a 1994 American drama film directed by Robert Zemeckis and written by Eric Roth with comedic aspects. It is based on the 1986 novel of the same name by Winston Groom and stars Tom Hanks, Robin Wright, Gary Sinise, Mykelti Williamson and Sally Field.",
                     ReleaseDate = new DateTime(1994, 6, 23),
                     Type = VideoType.Movie,
                     ImageUrl = "https://cinecalidad.in/wp-content/uploads/2020/03/forrest-gump-7240-poster-683x1024.jpg"

                 },

                 new Video
                 {
                     Id = 5,
                     Title = "Fight Club",
                     Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                     ReleaseDate = new DateTime(1999, 9, 10),
                     Type = VideoType.Movie,
                     ImageUrl = "https://www.new-video.de/co/fightclu.jpg"

                 },

                 new Video
                 {
                     Id = 6,
                     Title = "Bad Boys",
                     Description = "Two loose-cannon narcotics cops investigate the flow of Ecstasy into Florida from a Cuban drug cartel.",
                     ReleaseDate = new DateTime(1995, 4, 6),
                     Type = VideoType.Movie,
                     ImageUrl = "https://i.pinimg.com/736x/f8/a5/5d/f8a55dd993b59363dcf4b6e410305f44--hd-movies-action-movies.jpg"

                 },

                   new Video
                   {
                       Id = 7,
                       Title = "Bad Boys II",
                       Description = "Two hip detectives protect a witness to a murder while investigating a case of stolen heroin from the evidence storage room from their police precinct.",
                       ReleaseDate = new DateTime(2003, 6, 9),
                       Type = VideoType.Movie,
                       ImageUrl = "https://th.bing.com/th/id/OIP.M5Y738m_1kCMg-Fef-fI2gHaLH?pid=ImgDet&rs=1"

                   },

                   new Video
                   {
                       Id = 8,
                       Title = "Bad Boys For Life",
                       Description = "Miami detectives Mike Lowrey and Marcus Burnett must face off against a mother-and-son pair of drug lords who wreak vengeful havoc on their city.",
                       ReleaseDate = new DateTime(2020, 1, 7),
                       Type = VideoType.Movie,
                       ImageUrl = "https://th.bing.com/th/id/OIP.Ox-F7hWGAUkWLucz4B7ggwHaLH?pid=ImgDet&rs=1"

                   },

                    new Video
                    {
                        Id = 9,
                        Title = "The Tomorrow War",
                        Description = "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.",
                        ReleaseDate = new DateTime(2021, 7, 2),
                        Type = VideoType.Movie,
                        ImageUrl = "https://www.okdrama.com/wp-content/uploads/2021/07/The-Tomorrow-War.jpg"

                    },

                     new Video
                     {
                         Id = 10,
                         Title = "Jurassic Park",
                         Description = "A pragmatic paleontologist visiting an almost complete theme park is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                         ReleaseDate = new DateTime(1993, 6, 9),
                         Type = VideoType.Movie,
                         ImageUrl = "https://th.bing.com/th/id/R.795762624b2ebe035d8ebe1000397e70?rik=tM2O0EXzddMb7g&riu=http%3a%2f%2fwww.sf-fan.de%2fwp-content%2fuploads%2f2011%2f07%2fjurassic-park-poster.jpg&ehk=ISz78v6xTLdiIOGEtMFG9Qxj29cLWqZWOeZ9OUA8rGk%3d&risl=&pid=ImgRaw&r=0"

                     },
                      new Video
                      {
                          Id = 11,
                          Title = "The Lost World: Jurassic Park",
                          Description = "A research team is sent to the Jurassic Park Site B island to study the dinosaurs there, while an InGen team approaches with another agenda.",
                          ReleaseDate = new DateTime(1997, 5, 19),
                          Type = VideoType.Movie,
                          ImageUrl = "https://vignette.wikia.nocookie.net/cinemorgue/images/d/d8/11168888_800.jpg/revision/latest?cb=20150519044035"

                      },
                      new Video
                      {
                          Id = 12,
                          Title = "Jurassic Park III",
                          Description = "A decidedly odd couple with ulterior motives convince Dr. Grant to go to Isla Sorna for a holiday, but their unexpected landing startles the island's new inhabitants.",
                          ReleaseDate = new DateTime(2001, 7, 16),
                          Type = VideoType.Movie,
                          ImageUrl = "https://th.bing.com/th/id/OIP.mMwLmfEru8a0Y86217RLJwHaLH?pid=ImgDet&rs=1"

                      },
                      new Video
                      {
                          Id = 13,
                          Title = "Jurassic World",
                          Description = "A new theme park, built on the original site of Jurassic Park, creates a genetically modified hybrid dinosaur, the Indominus Rex, which escapes containment and goes on a killing spree.",
                          ReleaseDate = new DateTime(2015, 5, 29).ToUniversalTime(),
                          Type = VideoType.Movie,
                          ImageUrl = "https://th.bing.com/th/id/OIP.-3smAFf-8f3Xye1-VODc5AHaLH?pid=ImgDet&rs=1"

                      },
                       new Video
                       {
                           Id = 14,
                           Title = "Jurassic World: Fallen Kingdom",
                           Description = "When the island's dormant volcano begins roaring to life, Owen and Claire mount a campaign to rescue the remaining dinosaurs from this extinction-level event.",
                           ReleaseDate = new DateTime(2018, 5, 21),

                           Type = VideoType.Movie,
                           ImageUrl = "https://vignette.wikia.nocookie.net/cinemorgue/images/d/df/322699f120c17c2728457969b59af12c.jpg/revision/latest?cb=20180325190743"

                       },
                        new Video
                        {
                            Id = 15,
                            Title = "Spider-Man",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2002, 4, 30),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 31,
                            Title = "Spider 2",
                            Description = "Famous movie, first time displayed in 2003",
                            ReleaseDate = new DateTime(2003, 10, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 32,
                            Title = "The Godfather 4",
                            Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                            ReleaseDate = new DateTime(1972, 3, 24),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 33,
                            Title = "The Dark Knight 4",
                            Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            ReleaseDate = new DateTime(2008, 7, 18),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 34,
                            Title = "Band of Brothers",
                            Description = "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.",
                            ReleaseDate = new DateTime(2001, 9, 9),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 35,
                            Title = "Chernobyl",
                            Description = "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
                            ReleaseDate = new DateTime(1986, 4, 26),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 36,
                            Title = "Blue Planet II",
                            Description = "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.",
                            ReleaseDate = new DateTime(2017, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 37,
                            Title = "Our Planet",
                            Description = "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.",
                            ReleaseDate = new DateTime(2019, 4, 5),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 38,
                            Title = "Cosmos",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2012, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 39,
                            Title = "Spider",
                            Description = "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.",
                            ReleaseDate = new DateTime(2016, 8, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 40,
                            Title = "The Shawshank Redemption 2",
                            Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                            ReleaseDate = new DateTime(2018, 5, 10),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 41,
                            Title = "12 Angry Men 3",
                            Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                            ReleaseDate = new DateTime(2013, 10, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 42,
                            Title = "Schindler's List 3",
                            Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                            ReleaseDate = new DateTime(2004, 3, 2),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 43,
                            Title = "The Lord of the Rings: The Fellowship of the Ring 3",
                            Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                            ReleaseDate = new DateTime(2011, 10, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 44,
                            Title = "Pulp Fiction 4",
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            ReleaseDate = new DateTime(2020, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 45,
                            Title = "Fight Club 4",
                            Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                            ReleaseDate = new DateTime(1999, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 46,
                            Title = "Spider 5",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2019, 4, 11),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 47,
                            Title = "Forrest Gump 4",
                            Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                            ReleaseDate = new DateTime(2012, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 48,
                            Title = "Fight Club 5",
                            Description = "An office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                            ReleaseDate = new DateTime(1999, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 49,
                            Title = "Fight Club 6",
                            Description = "An worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                            ReleaseDate = new DateTime(1999, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 50,
                            Title = "The Shawshank Redemption 5",
                            Description = "Life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                            ReleaseDate = new DateTime(2011, 5, 11),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 51,
                            Title = "Fight Club 6",
                            Description = "An office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                            ReleaseDate = new DateTime(2001, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 52,
                            Title = "Forrest Gump 4",
                            Description = "The Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                            ReleaseDate = new DateTime(2013, 1, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 53,
                            Title = "Fight Club 7",
                            Description = "An office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                            ReleaseDate = new DateTime(2005, 10, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 54,
                            Title = "Spider 9",
                            Description = "High school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2019, 2, 11),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 55,
                            Title = "Star Wars: A New Hope (Episode IV)",
                            Description = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.",
                            ReleaseDate = new DateTime(2009, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 56,
                            Title = "Star Wars: A New Hope (Episode V)",
                            Description = "Luke and Han Solo must free Leilas and destroy the powerful weapon created by the Galactic Empire.",
                            ReleaseDate = new DateTime(2011, 4, 5),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 57,
                            Title = "Star Wars: A New Hope (Episode VI)",
                            Description = "Luke and Han Solo must free Leilas and destroy the powerful weapon created by the Galactic Empire.",
                            ReleaseDate = new DateTime(2013, 10, 5),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 58,
                            Title = "Star Wars: A New Hope (Episode VII)",
                            Description = "Luke and Han Solo must free Leilas and destroy the powerful weapon created by the Galactic Empire.",
                            ReleaseDate = new DateTime(2014, 11, 11),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 59,
                            Title = "Star Wars: A New Hope (Episode VIII)",
                            Description = "Luke and Han Solo must free Leilas and destroy the powerful weapon created by the Galactic Empire.",
                            ReleaseDate = new DateTime(2015, 4, 5),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 60,
                            Title = "Avatar",
                            Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.",
                            ReleaseDate = new DateTime(2009, 11, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 61,
                            Title = "Avatar 1",
                            Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.",
                            ReleaseDate = new DateTime(2010, 11, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 62,
                            Title = "Avatar 2",
                            Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.",
                            ReleaseDate = new DateTime(2011, 11, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 63,
                            Title = "Avatar 3",
                            Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.",
                            ReleaseDate = new DateTime(2012, 11, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 64,
                            Title = "Harry Potter and the Philosopher's Stone",
                            Description = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.",
                            ReleaseDate = new DateTime(1999, 8, 8),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 65,
                            Title = "Harry Potter and The Chamber Of Secrets",
                            Description = "An eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.",
                            ReleaseDate = new DateTime(2012, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 66,
                            Title = "Shang-Chi and the Legend of the Ten Rings",
                            Description = "Shang-Chi must confront the past he thought he left behind when he is drawn into the web of the mysterious Ten Rings organization.",
                            ReleaseDate = new DateTime(2003, 10, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 67,
                            Title = "Don't Breathe 2",
                            Description = "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a young girl orphaned from a devastating house fire. Their quiet life together is shattered when a group of criminals kidnap the girl.",
                            ReleaseDate = new DateTime(2017, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 68,
                            Title = "Don't Breathe 3",
                            Description = "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a young girl orphaned from a devastating house fire. Their quiet life together is shattered when a group of criminals kidnap the girl.",
                            ReleaseDate = new DateTime(2018, 5, 9),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 69,
                            Title = "Don't Breathe 4",
                            Description = "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a young girl orphaned from a devastating house.",
                            ReleaseDate = new DateTime(2012, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 70,
                            Title = "The Suicide Squad",
                            Description = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                            ReleaseDate = new DateTime(2007, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 71,
                            Title = "The Suicide Squad 1",
                            Description = "Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                            ReleaseDate = new DateTime(2011, 7, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 72,
                            Title = "The Suicide Squad 2",
                            Description = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                            ReleaseDate = new DateTime(2014, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 73,
                            Title = "The Suicide Squad 3",
                            Description = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                            ReleaseDate = new DateTime(2019, 4, 10),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 74,
                            Title = "Jungle Cruise",
                            Description = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.",
                            ReleaseDate = new DateTime(2017, 11, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 75,
                            Title = "Jungle Cruise 1",
                            Description = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.",
                            ReleaseDate = new DateTime(2018, 11, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 76,
                            Title = "Jungle Cruise 2",
                            Description = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.",
                            ReleaseDate = new DateTime(2019, 6, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 77,
                            Title = "Cinderella",
                            Description = "Cinderella, an orphaned girl with an evil stepmother, has big dreams and with the help of her Fabulous Godmother, she perseveres to make them come true.",
                            ReleaseDate = new DateTime(2015, 9, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 78,
                            Title = "Cinderella 2",
                            Description = "An orphaned girl with an evil stepmother, has big dreams and with the help of her Fabulous Godmother, she perseveres to make them come true.",
                            ReleaseDate = new DateTime(2017, 1, 5),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 79,
                            Title = "Gladiator",
                            Description = "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2002, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 80,
                            Title = "Gladiator 1",
                            Description = "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2012, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 81,
                            Title = "Gladiator 2",
                            Description = "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2013, 4, 11),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 82,
                            Title = "Gladiator 3",
                            Description = "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2014, 4, 11),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 83,
                            Title = "Gladiator 4",
                            Description = "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2015, 6, 11),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 84,
                            Title = "Movie 1",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2007, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 85,
                            Title = "Movie 2",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2019, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 86,
                            Title = "Movie 3",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2005, 7, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 87,
                            Title = "Movie 4",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2002, 4, 4),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 88,
                            Title = "Movie 5",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2001, 4, 7),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 89,
                            Title = "Movie 6",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(1999, 9, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 90,
                            Title = "Movie 7",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2000, 4, 3),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 91,
                            Title = "Movie 8",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2001, 4, 2),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 92,
                            Title = "Movie 9",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2012, 4, 1),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 93,
                            Title = "Movie Number 1",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2012, 4, 8),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 94,
                            Title = "Movie Number 2",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2006, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 95,
                            Title = "Movie Number 3",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2007, 4, 6),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 96,
                            Title = "Movie Number 4",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2008, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 97,
                            Title = "Movie Number 5",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2009, 4, 6),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 98,
                            Title = "Movie Number 6",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2003, 4, 9),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 99,
                            Title = "Movie Number 7",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2008, 4, 10),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 100,
                            Title = "Movie Number 8",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2020, 4, 8),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 101,
                            Title = "Movie Number 9",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2021, 4, 8),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 102,
                            Title = "Fast and Furious",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(1997, 4, 3),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 103,
                            Title = "Fast and Furious 1",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(1999, 4, 8),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 104,
                            Title = "Fast and Furious 2",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(2001, 9, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 105,
                            Title = "Fast and Furious 3",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(2002, 9, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 106,
                            Title = "Fast and Furious 4",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(2003, 9, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 107,
                            Title = "Fast and Furious 5",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(2004, 9, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 108,
                            Title = "Fast and Furious 6",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(2005, 9, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 109,
                            Title = "Fast and Furious 7",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(2008, 9, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 110,
                            Title = "Fast and Furious 8",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(2011, 9, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 111,
                            Title = "Fast and Furious 9",
                            Description = "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.",
                            ReleaseDate = new DateTime(2015, 9, 6),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 112,
                            Title = "The Terminator",
                            Description = "Directed by James Cameron. With Arnold Schwarzenegger, Michael Biehn, Linda Hamilton, Paul Winfield. A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.",
                            ReleaseDate = new DateTime(1984, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 113,
                            Title = "The Terminator 1",
                            Description = "Directed by James Cameron. With Arnold Schwarzenegger, Michael Biehn, Linda Hamilton, Paul Winfield. A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.",
                            ReleaseDate = new DateTime(1989, 4, 8),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 114,
                            Title = "The Terminator 2",
                            Description = "Directed by James Cameron. With Arnold Schwarzenegger, Michael Biehn, Linda Hamilton, Paul Winfield. A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.",
                            ReleaseDate = new DateTime(1991, 4, 7),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                        new Video
                        {
                            Id = 115,
                            Title = "The Terminator 3",
                            Description = "Directed by James Cameron. With Arnold Schwarzenegger, Michael Biehn, Linda Hamilton, Paul Winfield. A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.",
                            ReleaseDate = new DateTime(1995, 4, 5),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"
                        },
                      


                        /// TvShow videos
                        new Video
                        {
                            Id = 16,
                            Title = "Clickbait",
                            Description = "When family man Nick Brewer is abducted in a crime with a sinister online twist, those closest to him race to uncover who is behind it and why.",
                            ReleaseDate = new DateTime(2021, 8, 25),
                            Type = VideoType.TvShow,
                            ImageUrl = "https://www.what-song.com/_next/image?url=https:%2F%2Fimage.tmdb.org%2Ft%2Fp%2Fw500%2Fq42t4S113jebD1khigJt8z3m1mD.jpg&w=828&q=75"

                        },
                         new Video
                         {
                             Id = 17,
                             Title = "Money Heist",
                             Description = "An unusual group of robbers attempt to carry out the most perfect robbery in Spanish history - stealing 2.4 billion euros from the Royal Mint of Spain.",
                             ReleaseDate = new DateTime(2017, 5, 2),
                             Type = VideoType.TvShow,
                             ImageUrl = "https://i1.wp.com/www.realhypegh.com/wp-content/uploads/2021/09/Money-Heist.jpg?resize=696%2C1031&ssl=1"

                         },
                         new Video
                         {
                             Id = 18,
                             Title = "Nine Perfect Strangers",
                             Description = "Nine stressed city dwellers visit a boutique health-and-wellness resort that promises healing and transformation. The resort's director is a woman on a mission to reinvigorate their tired minds and bodies.",
                             ReleaseDate = new DateTime(2021, 8, 18),
                             Type = VideoType.TvShow,
                             ImageUrl = "https://th.bing.com/th/id/OIP.yclr5qYMsedWaCB1yJRQdgHaLU?pid=ImgDet&rs=1"

                         },
                          new Video
                          {
                              Id = 19,
                              Title = "The Walking Dead",
                              Description = "Sheriff Deputy Rick Grimes wakes up from a coma to learn the world is in ruins and must lead a group of survivors to stay alive.",
                              ReleaseDate = new DateTime(2010, 10, 31),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/R.b904983728868f3ed5ce79fb819c8699?rik=LmhMRcd0HZRPew&riu=http%3a%2f%2fpics.filmaffinity.com%2fThe_Walking_Dead_TV_Series-285470099-large.jpg&ehk=8lZYkdu%2fiSDQQ%2f9RKV8aveMd7qagFCj573%2fZ1rNnfzQ%3d&risl=&pid=ImgRaw&r=0"

                          },
                          new Video
                          {
                              Id = 20,
                              Title = "Game of Thrones",
                              Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                              ReleaseDate = new DateTime(2011, 4, 17),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/R.e024c02d31c823d7d68e23550207fb3e?rik=p3JUYI%2bmYV91RA&pid=ImgRaw&r=0"

                          },
                          new Video
                          {
                              Id = 21,
                              Title = "Manifest",
                              Description = "A commercial airliner suddenly reappears after being missing for five years. As those aboard reintegrate into society, they experience guiding voices and visions of events yet to occur, and soon a deeper mystery unfolds.",
                              ReleaseDate = new DateTime(2018, 9, 24),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://image.tmdb.org/t/p/original/moaCMoZYVifaQnNJGDr3M6rBglB.jpg"

                          },
                          new Video
                          {
                              Id = 22,
                              Title = "Brooklyn Nine-Nine",
                              Description = "Comedy series following the exploits of Det. Jake Peralta and his diverse, lovable colleagues as they police the NYPD's 99th Precinct.",
                              ReleaseDate = new DateTime(2013, 9, 17),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/R.6ed153b03e7aae27d1c14006c3ffd4eb?rik=E9ceeJRcwZwm5w&pid=ImgRaw&r=0"

                          },
                          new Video
                          {
                              Id = 23,
                              Title = "Breaking Bad",
                              Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                              ReleaseDate = new DateTime(2008, 1, 20),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/R.7daca6eab99b67e6cd63f01bfdf3a41a?rik=QqKBdpltIOVmrw&riu=http%3a%2f%2fwww.notrecinema.com%2fimages%2fcache%2fbreaking-bad-poster_399299_31440.jpg&ehk=YPzSvSux8LNPKZgfHqAfYce7Rz6%2fafdR6GZvT1TE6J8%3d&risl=&pid=ImgRaw&r=0"

                          },
                          new Video
                          {
                              Id = 24,
                              Title = "Friends",
                              Description = "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.",
                              ReleaseDate = new DateTime(1994, 9, 22),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://images.saymedia-content.com/.image/t_share/MTc2NTc0ODUzMDQ0Nzc0NjE5/tv-shows-like-friends.jpg"

                          },
                          new Video
                          {
                              Id = 25,
                              Title = "Prison Break",
                              Description = "Due to a political conspiracy, an innocent man is sent to death row and his only hope is his brother, who makes it his mission to deliberately get himself sent to the same prison in order to break the both of them out, from the inside.",
                              ReleaseDate = new DateTime(2005, 8, 29),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://cdn.cinematerial.com/p/500x/rkevtzje/prison-break-movie-cover.jpg"

                          },
                          new Video
                          {
                              Id = 26,
                              Title = "Criminal Minds",
                              Description = "The cases of the F.B.I. Behavioral Analysis Unit (B.A.U.), an elite group of profilers who analyze the nation's most dangerous serial killers and individual heinous crimes in an effort to anticipate their next moves before they strike again.",
                              ReleaseDate = new DateTime(2005, 9, 22),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/OIP.ZUzAwzdzq780bQ9KjtJ2xgHaKd?pid=ImgDet&rs=1"

                          },
                          new Video
                          {
                              Id = 27,
                              Title = "The Empire",
                              Description = "The series focuses on the rise and fall of Mughal Empire through generations from Babur to Aurangzeb.",
                              ReleaseDate = new DateTime(2021, 8, 27),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://i1.wp.com/hdmoviez.biz/wp-content/uploads/2021/08/The-Empire-2021-S01.png?w=500"

                          },
                          new Video
                          {
                              Id = 28,
                              Title = "The Blacklist",
                              Description = "A new FBI profiler, Elizabeth Keen, has her entire life uprooted when a mysterious criminal, Raymond Reddington, who has eluded capture for decades, turns himself in and insists on speaking only to her.",
                              ReleaseDate = new DateTime(2013, 9, 23),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6259/6259110_so.jpg"

                          },
                           new Video
                           {
                               Id = 29,
                               Title = "House",
                               Description = "An antisocial maverick doctor who specializes in diagnostic medicine does whatever it takes to solve puzzling cases that come his way using his crack team of doctors and his wits.",
                               ReleaseDate = new DateTime(2004, 11, 16),
                               Type = VideoType.TvShow,
                               ImageUrl = "https://www.pelisxd.com/wp-content/uploads/2020/04/house-15611-poster.jpg"

                           },
                            new Video
                            {
                                Id = 30,
                                Title = "The Defeated",
                                Description = "Max McLaughlin is an American cop who arrives in Berlin in the summer of 1946 to help create a police force in the chaotic aftermath of the war.",
                                ReleaseDate = new DateTime(2020, 10, 10),
                                Type = VideoType.TvShow,
                                ImageUrl = "https://d2iltjk184xms5.cloudfront.net/uploads/photo/file/382771/e6aace1d14a77a2badd179ba926ac1b3-defeatedposter.jpg"

                            }


            );
            #endregion


            /// Actors and related movies and Tv Shows
            #region VideosActors Data
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, FirstName = "Tom", LastName="Hanks", VideoId = 1 },
                new Actor { Id = 2, FirstName = "Matt", LastName = "Damon", VideoId = 1 },
                new Actor { Id = 3, FirstName = "Leonardo", LastName = "DiCaprio", VideoId = 2 },
                new Actor { Id = 4, FirstName = "Joseph", LastName = "Gordon-Levitt", VideoId = 2 },
                new Actor { Id = 5, FirstName = "Henry", LastName = "Cavill", VideoId = 3 },
                new Actor { Id = 6, FirstName = "Anna", LastName = "Shaffer", VideoId = 3 },
                new Actor { Id = 7, FirstName = "Tom", LastName = "Hanks", VideoId = 4 },
                new Actor { Id = 8, FirstName = "Robin", LastName = "Wright", VideoId = 4 },
                new Actor { Id = 9, FirstName= "Brad", LastName = "Pitt", VideoId = 5 },
                new Actor { Id = 10, FirstName = "Edward", LastName = "Norton", VideoId = 5 },
                new Actor { Id = 11, FirstName = "Will", LastName = "Smith", VideoId = 6 },
                new Actor { Id = 12, FirstName = "Martin", LastName = "Lawrence", VideoId = 6 },
                new Actor { Id = 13, FirstName = "Will", LastName = "Smith", VideoId = 7 },
                new Actor { Id = 14, FirstName = "Martin", LastName = "Lawrence", VideoId = 7 },
                new Actor { Id = 15, FirstName = "Will", LastName = "Smith", VideoId = 8 },
                new Actor { Id = 16, FirstName = "Martin", LastName = "Lawrence", VideoId = 8 },
                new Actor { Id = 17, FirstName = "Chris", LastName = "Pratt", VideoId = 9 },
                new Actor { Id = 18, FirstName = "Yvonne", LastName = "Strahovski", VideoId = 9 },
                new Actor { Id = 19, FirstName = "Sam", LastName = "Neill", VideoId = 10 },
                new Actor { Id = 20, FirstName = "Laura", LastName = "Dern", VideoId = 10 },
                new Actor { Id = 21, FirstName = "Jeff", LastName = "Goldblum", VideoId = 11 },
                new Actor { Id = 22, FirstName = "Julianne", LastName = "Moore", VideoId = 11 },
                new Actor { Id = 23, FirstName = "Sam", LastName = "Hanks", VideoId = 12 },
                new Actor { Id = 24, FirstName = "William", LastName = "H. Macy", VideoId = 12 },
                new Actor { Id = 25, FirstName = "Chris", LastName = "Pratt", VideoId = 13 },
                new Actor { Id = 26, FirstName = "Bryce", LastName = "Dallas Howard", VideoId = 13 },
                new Actor { Id = 27, FirstName = "Chris", LastName = "Pratt", VideoId = 14 },
                new Actor { Id = 28, FirstName = "Bryce", LastName = "Dallas Howard", VideoId = 14 },
                new Actor { Id = 29, FirstName = "Tobey", LastName = "Maguire", VideoId = 15 },
                new Actor { Id = 30, FirstName = "Kristen", LastName = " Dunst", VideoId = 15 },
                new Actor { Id = 61, FirstName = "Tom", LastName = "Hanks", VideoId = 31 },
                new Actor { Id = 62, FirstName = "Matt", LastName = "Damon", VideoId = 31 },
                new Actor { Id = 63, FirstName = "Leonardo", LastName = "DiCaprio", VideoId = 32 },
                new Actor { Id = 64, FirstName = "Joseph", LastName = "Gordon-Levitt", VideoId = 32 },
                new Actor { Id = 65, FirstName = "Henry", LastName = "Cavill", VideoId = 33 },
                new Actor { Id = 66, FirstName = "Anna", LastName = " Shaffer", VideoId = 33 },
                new Actor { Id = 67, FirstName = "Tom", LastName = "Hanks", VideoId = 34 },
                new Actor { Id = 68, FirstName = "Robin", LastName = "Wright", VideoId = 34 },
                new Actor { Id = 69, FirstName = "Brad", LastName = "Pitt", VideoId = 35 },
                new Actor { Id = 70, FirstName = "Edward", LastName = "Norton", VideoId = 35 },
                new Actor { Id = 71, FirstName = "Will", LastName = "Smith", VideoId = 36 },
                new Actor { Id = 72, FirstName = "Martin", LastName = "Lawrence", VideoId = 36 },
                new Actor { Id = 73, FirstName = "Will", LastName = "Smith", VideoId = 37 },
                new Actor { Id = 74, FirstName = "Martin", LastName = "Lawrence", VideoId = 37 },
                new Actor { Id = 75, FirstName = "Will", LastName = "Smith", VideoId = 38 },
                new Actor { Id = 76, FirstName = "Martin", LastName= " Lawrence", VideoId = 38 },
                new Actor { Id = 77, FirstName = "Chris", LastName = " Pratt", VideoId = 39 },
                new Actor { Id = 78, FirstName = "Yvonne", LastName = "Strahovski", VideoId = 39 },
                new Actor { Id = 79, FirstName = "Sam", LastName = "Neill", VideoId = 40 },
                new Actor { Id = 80, FirstName = "Laura", LastName = "Dern", VideoId = 40 },
                new Actor { Id = 81, FirstName = "Jeff", LastName = "Goldblum", VideoId = 41 },
                new Actor { Id = 82, FirstName = "Julianne", LastName = "Moore", VideoId = 41 },
                new Actor { Id = 83, FirstName = "Sam", LastName = "Neill", VideoId = 42 },
                new Actor { Id = 84, FirstName = "William", LastName = "H. Macy", VideoId = 42 },
                new Actor { Id = 85, FirstName = "Chris", LastName = "Pratt", VideoId = 43 },
                new Actor { Id = 86, FirstName = "Bryce", LastName = "Dallas Howard", VideoId = 43 },
                new Actor { Id = 87, FirstName = "Chris", LastName = "Pratt", VideoId = 44 },
                new Actor { Id = 88, FirstName = "Bryce", LastName = "Dallas Howard", VideoId = 44 },
                new Actor { Id = 89, FirstName = "Tobey", LastName = "Maguire", VideoId = 45 },
                new Actor { Id = 90, FirstName = "Kristen", LastName = "Dunst", VideoId = 45 },
                new Actor { Id = 91, FirstName = "Tom", LastName = "Hanks", VideoId = 46 },
                new Actor { Id = 92, FirstName = "Matt", LastName = "Damon", VideoId = 46 },
                new Actor { Id = 93, FirstName = "Leonardo", LastName = "DiCaprio", VideoId = 47 },
                new Actor { Id = 94, FirstName = "Joseph", LastName = "Gordon-Levitt", VideoId = 47 },
                new Actor { Id = 95, FirstName = "Henry", LastName = "Cavill", VideoId = 48 },
                new Actor { Id = 96, FirstName = "Anna", LastName = "Shaffer", VideoId = 48 },
                new Actor { Id = 97, FirstName = "Tom", LastName = "Hanks", VideoId = 49 },
                new Actor { Id = 98, FirstName = "Robin", LastName = "Wright", VideoId = 49 },
                new Actor { Id = 99, FirstName= "Brad Pitt", LastName = "Hanks", VideoId = 50 },
                new Actor { Id = 100, FirstName = "Edward", LastName = "Norton", VideoId = 50 },
                new Actor { Id = 101, FirstName = "Will", LastName = "Smith", VideoId = 51 },
                new Actor { Id = 102, FirstName = "Martin", LastName = "Lawrence", VideoId = 51 },
                new Actor { Id = 103, FirstName = "Will", LastName = "Smith", VideoId = 52 },
                new Actor { Id = 104, FirstName = "Martin", LastName = "Lawrence", VideoId = 52 },
                new Actor { Id = 105, FirstName = "Will", LastName = "Smith", VideoId = 53 },
                new Actor { Id = 106, FirstName = "Martin", LastName = "Lawrence", VideoId = 53 },
                new Actor { Id = 107, FirstName = "Chris", LastName = "Pratt", VideoId = 54 },
                new Actor { Id = 108, FirstName = "Yvonne", LastName = "Strahovski", VideoId = 54 },
                new Actor { Id = 109, FirstName = "Sam", LastName = "Hanks", VideoId = 55 },
                new Actor { Id = 110, FirstName = "Laura", LastName = "Dern", VideoId = 55 },
                new Actor { Id = 111, FirstName = "Jeff", LastName = "Hanks", VideoId = 56 },
                new Actor { Id = 112, FirstName = "Julianne", LastName = "Moore", VideoId = 56 },
                new Actor { Id = 113, FirstName = "Sam", LastName = "Hanks", VideoId = 57 },
                new Actor { Id = 114, FirstName = "William", LastName = "Hanks", VideoId = 57 },
                new Actor { Id = 115, FirstName = "Chris", LastName = "Hanks", VideoId = 58 },
                new Actor { Id = 116, FirstName = "Bryce", LastName = "Hanks", VideoId = 58 },
                new Actor { Id = 117, FirstName = "Chris", LastName = "Hanks", VideoId = 59 },
                new Actor { Id = 118, FirstName = "Bryce", LastName = "Hanks", VideoId = 59 },
                new Actor { Id = 119, FirstName = "Tobey", LastName = "Maguire", VideoId = 60 },
                new Actor { Id = 120, FirstName = "Kristen", LastName = "Dunst", VideoId = 60 },
                new Actor { Id = 121, FirstName = "Tobey", LastName = "Maguire", VideoId = 62 },
                new Actor { Id = 122, FirstName = "Kristen", LastName = "Dunst", VideoId = 62 },
                new Actor { Id = 123, FirstName = "Tobey", LastName = "Maguire", VideoId = 63 },
                new Actor { Id = 124, FirstName = "Kristen", LastName = "Dunst", VideoId = 63 },
                new Actor { Id = 125, FirstName = "Tobey", LastName = "Maguire", VideoId = 64 },
                new Actor { Id = 126, FirstName = "Kristen", LastName = "Dunst", VideoId = 64 },
                new Actor { Id = 127, FirstName = "Tobey", LastName = "Maguire", VideoId = 65 },
                new Actor { Id = 128, FirstName = "Kristen", LastName = "Dunst", VideoId = 65 },
                new Actor { Id = 129, FirstName = "Tobey", LastName = "Maguire", VideoId = 66 },
                new Actor { Id = 130, FirstName = "Kristen", LastName = "Dunst", VideoId = 66 },
                new Actor { Id = 131, FirstName = "Tobey", LastName = "Maguire", VideoId = 67 },
                new Actor { Id = 132, FirstName = "Kristen", LastName = "Dunst", VideoId = 67 },
                new Actor { Id = 133, FirstName = "Tobey", LastName = "Maguire", VideoId = 68 },
                new Actor { Id = 134, FirstName = "Kristen", LastName = "Dunst", VideoId = 68 },
                new Actor { Id = 135, FirstName = "Tobey", LastName = "Maguire", VideoId = 69 },
                new Actor { Id = 136, FirstName = "Kristen", LastName = "Dunst", VideoId = 69 },
                new Actor { Id = 137, FirstName = "Tobey", LastName = "Maguire", VideoId = 70 },
                new Actor { Id = 138, FirstName = "Kristen", LastName = "Dunst", VideoId = 70 },
                new Actor { Id = 139, FirstName = "Tobey", LastName = "Maguire", VideoId = 71 },
                new Actor { Id = 140, FirstName = "Kristen", LastName = "Dunst", VideoId = 71 },
                new Actor { Id = 141, FirstName = "Tobey", LastName = "Maguire", VideoId = 72 },
                new Actor { Id = 142, FirstName = "Kristen", LastName = "Dunst", VideoId = 72 },
                new Actor { Id = 143, FirstName = "Tobey", LastName = "Maguire", VideoId = 73 },
                new Actor { Id = 144, FirstName = "Kristen", LastName = "Dunst", VideoId = 73 },
                new Actor { Id = 145, FirstName = "Tobey", LastName = "Maguire", VideoId = 74 },
                new Actor { Id = 146, FirstName = "Kristen", LastName = "Dunst", VideoId = 74 },
                new Actor { Id = 147, FirstName = "Tobey", LastName = "Maguire", VideoId = 75 },
                new Actor { Id = 148, FirstName = "Kristen", LastName = "Dunst", VideoId = 75 },
                new Actor { Id = 149, FirstName = "Tobey", LastName = "Maguire", VideoId = 76 },
                new Actor { Id = 151, FirstName = "Kristen", LastName = "Dunst", VideoId = 76 },
                new Actor { Id = 152, FirstName = "Tobey", LastName = "Maguire", VideoId = 77 },
                new Actor { Id = 153, FirstName = "Kristen", LastName = "Dunst", VideoId = 77 },
                new Actor { Id = 154, FirstName = "Tobey", LastName = "Maguire", VideoId = 78 },
                new Actor { Id = 155, FirstName = "Kristen", LastName = "Dunst", VideoId = 78 },
                new Actor { Id = 156, FirstName = "Tobey", LastName = "Maguire", VideoId = 79 },
                new Actor { Id = 157, FirstName = "Kristen", LastName = "Dunst", VideoId = 79 },
                new Actor { Id = 158, FirstName = "Tobey", LastName = "Dunst", VideoId = 80 },
                new Actor { Id = 159, FirstName = "Kristen", LastName = "Maguire", VideoId = 80 },
                new Actor { Id = 160, FirstName = "Tobey", LastName = "Dunst", VideoId = 81 },
                new Actor { Id = 161, FirstName = "Kristen", LastName = "Maguire", VideoId = 81 },
                new Actor { Id = 162, FirstName = "Tobey", LastName = "Dunst", VideoId = 82 },
                new Actor { Id = 163, FirstName = "Kristen", LastName = "Maguire", VideoId = 82 },
                new Actor { Id = 164, FirstName = "Tobey", LastName = "Dunst", VideoId = 83 },
                new Actor { Id = 165, FirstName = "Kristen", LastName = "Maguire", VideoId = 83 },
                new Actor { Id = 166, FirstName = "Tobey", LastName = "Dunst", VideoId = 84 },
                new Actor { Id = 167, FirstName = "Kristen", LastName = "Maguire", VideoId = 84 },
                new Actor { Id = 168, FirstName = "Tobey", LastName = "Dunst", VideoId = 85 },
                new Actor { Id = 169, FirstName = "Kristen", LastName = "Maguire", VideoId = 85 },
                new Actor { Id = 170, FirstName = "Tobey", LastName = "Dunst", VideoId = 86 },
                new Actor { Id = 171, FirstName = "Kristen", LastName = "Maguire", VideoId = 86 },
                new Actor { Id = 172, FirstName = "Tobey", LastName = "Dunst", VideoId = 87 },
                new Actor { Id = 173, FirstName = "Kristen", LastName = "Maguire", VideoId = 87 },
                new Actor { Id = 174, FirstName = "Tobey", LastName = "Dunst", VideoId = 88 },
                new Actor { Id = 175, FirstName = "Kristen", LastName = "Maguire", VideoId = 88 },
                new Actor { Id = 176, FirstName = "Tobey", LastName = "Dunst", VideoId = 89 },
                new Actor { Id = 177, FirstName = "Kristen", LastName = "Maguire", VideoId = 89 },
                new Actor { Id = 178, FirstName = "Tobey", LastName = "Dunst", VideoId = 90 },
                new Actor { Id = 179, FirstName = "Kristen", LastName = "Maguire", VideoId = 90 },
                new Actor { Id = 180, FirstName = "Tobey", LastName = "Dunst", VideoId = 91 },
                new Actor { Id = 181, FirstName = "Kristen", LastName = "Maguire", VideoId = 91 },
                new Actor { Id = 182, FirstName = "Tobey", LastName = "Dunst", VideoId = 92 },
                new Actor { Id = 183, FirstName = "Kristen", LastName = "Maguire", VideoId = 92 },
                new Actor { Id = 184, FirstName = "Tobey", LastName = "Dunst", VideoId = 94 },
                new Actor { Id = 185, FirstName = "Kristen", LastName = "Maguire", VideoId = 95 },
                new Actor { Id = 186, FirstName = "Tobey", LastName = "Dunst", VideoId = 96 },
                new Actor { Id = 187, FirstName = "Kristen", LastName = "Maguire", VideoId = 97 },
                new Actor { Id = 188, FirstName = "Tobey", LastName = "Dunst", VideoId = 98 },
                new Actor { Id = 189, FirstName = "Kristen", LastName = "Maguire", VideoId = 99 },
                new Actor { Id = 190, FirstName = "Tobey", LastName = "Dunst", VideoId = 100 },
                new Actor { Id = 191, FirstName = "Kristen", LastName = "Maguire", VideoId = 101 },
                new Actor { Id = 192, FirstName = "Tobey", LastName = "Dunst", VideoId = 102 },
                new Actor { Id = 193, FirstName = "Kristen", LastName = "Maguire", VideoId = 103 },
                new Actor { Id = 194, FirstName = "Tobey", LastName = "Dunst", VideoId = 104 },
                new Actor { Id = 195, FirstName = "Kristen", LastName = "Maguire", VideoId = 105 },
                new Actor { Id = 196, FirstName = "Tobey", LastName = "Dunst", VideoId = 106 },
                new Actor { Id = 197, FirstName = "Kristen", LastName = "Maguire", VideoId = 107 },
                new Actor { Id = 198, FirstName = "Tobey", LastName = "Dunst", VideoId = 108 },
                new Actor { Id = 199, FirstName = "Kristen", LastName = "Maguire", VideoId = 109 },
                new Actor { Id = 200, FirstName = "Tobey", LastName = "Dunst", VideoId = 110 },
                new Actor { Id = 201, FirstName = "Kristen", LastName = "Maguire", VideoId = 111 },
                new Actor { Id = 202, FirstName = "Tobey", LastName = "Dunst", VideoId = 112 },
                new Actor { Id = 203, FirstName = "Kristen", LastName = "Maguire", VideoId = 113 },
                new Actor { Id = 204, FirstName = "Tobey", LastName = "Dunst", VideoId = 114 },
                new Actor { Id = 205, FirstName= "Kristen",  LastName = "Dunst", VideoId = 115 },
                ///TActor
                new Actor { Id = 31, FirstName = "Zoe", LastName= " Kazan", VideoId = 16 },
                new Actor { Id = 32, FirstName = "Betty", LastName = "Gabriel", VideoId = 16 },
                new Actor { Id = 33, FirstName = "Ursula", LastName = "Cobero", VideoId = 17 },
                new Actor { Id = 34, FirstName = "Alvaro", LastName = "Morte", VideoId = 17 },
                new Actor { Id = 35, FirstName = "Nicole", LastName = "Kidman", VideoId = 18 },
                new Actor { Id = 36, FirstName = "Melissa", LastName = "McCarthy", VideoId = 18 },
                new Actor { Id = 37, FirstName = "Andrew", LastName = "Licnoln", VideoId = 19 },
                new Actor { Id = 38, FirstName = "Norman", LastName = "Reedus", VideoId = 19 },
                new Actor { Id = 39, FirstName = "Emilia", LastName = "Clarke", VideoId = 20 },
                new Actor { Id = 40, FirstName = "Peter", LastName = "Dinklage", VideoId = 20 },
                new Actor { Id = 41, FirstName = "Melissa", LastName = "Roxburgh", VideoId = 21 },
                new Actor { Id = 42, FirstName = "Josh", LastName = "Dallas", VideoId = 21 },
                new Actor { Id = 43, FirstName = "Andy", LastName = "Samberg", VideoId = 22 },
                new Actor { Id = 44, FirstName = "Stephanie", LastName = "Beatriz", VideoId = 22 },
                new Actor { Id = 45, FirstName = "Bryan", LastName = "Cranston", VideoId = 23 },
                new Actor { Id = 46, FirstName = "Aaron", LastName = "Paul", VideoId = 23 },
                new Actor { Id = 47, FirstName = "Jennifer", LastName = "Aniston", VideoId = 24 },
                new Actor { Id = 48, FirstName = "Courteney", LastName = "Cox", VideoId = 24 },
                new Actor { Id = 49, FirstName = "Dominic", LastName = "Purcell", VideoId = 25 },
                new Actor { Id = 50, FirstName = "Wentworth", LastName = "Miller", VideoId = 25 },
                new Actor { Id = 51, FirstName = "Matthewr", LastName = "Gray Gubler", VideoId = 26 },
                new Actor { Id = 52, FirstName = "Kristen", LastName = "Vangsness", VideoId = 26 },
                new Actor { Id = 53, FirstName = "Shabana", LastName = "Azmi", VideoId = 27 },
                new Actor { Id = 54, FirstName = "Kunal", LastName = "Kapoor", VideoId = 27 },
                new Actor { Id = 55, FirstName = "James", LastName = "Spader", VideoId = 28 },
                new Actor { Id = 56, FirstName = "Megane", LastName = "Bone", VideoId = 28 },
                new Actor { Id = 57, FirstName = "Hugh", LastName = "Lauri", VideoId = 29 },
                new Actor { Id = 58, FirstName = "Omar", LastName = "Epps", VideoId = 29 },
                new Actor { Id = 59, FirstName = "Taylor", LastName = "Kitsch", VideoId = 30 },
                new Actor { Id = 60, FirstName = "Michael", LastName = "C. Hall", VideoId = 30 }
            );
            #endregion
            /// Rating for every movie and Tv Show
            #region VideosActors Data
            modelBuilder.Entity<Rating>().HasData(
                new Rating { Id = 1, Score = 5, VideoId = 1 },
                new Rating { Id = 2, Score = 5, VideoId = 1 },
                new Rating { Id = 3, Score = 4, VideoId = 2 },
                new Rating { Id = 4, Score = 4, VideoId = 2 },
                new Rating { Id = 5, Score = 3, VideoId = 3 },
                new Rating { Id = 6, Score = 2, VideoId = 3 },
                new Rating { Id = 7, Score = 3, VideoId = 4 },
                new Rating { Id = 8, Score = 5, VideoId = 4 },
                new Rating { Id = 9, Score = 4, VideoId = 5 },
                new Rating { Id = 10, Score = 4, VideoId = 5 },
                new Rating { Id = 11, Score = 0, VideoId = 6 },
                new Rating { Id = 12, Score = 0, VideoId = 6 },
                new Rating { Id = 13, Score = 5, VideoId = 7 },
                new Rating { Id = 14, Score = 5, VideoId = 7 },
                new Rating { Id = 15, Score = 4, VideoId = 8 },
                new Rating { Id = 16, Score = 2, VideoId = 8 },
                new Rating { Id = 17, Score = 4, VideoId = 9 },
                new Rating { Id = 18, Score = 5, VideoId = 9 },
                new Rating { Id = 19, Score = 3, VideoId = 10 },
                new Rating { Id = 20, Score = 3, VideoId = 10 },
                new Rating { Id = 21, Score = 4, VideoId = 11 },
                new Rating { Id = 22, Score = 5, VideoId = 11 },
                new Rating { Id = 23, Score = 4, VideoId = 12 },
                new Rating { Id = 24, Score = 4, VideoId = 12 },
                new Rating { Id = 25, Score = 3, VideoId = 13 },
                new Rating { Id = 26, Score = 4, VideoId = 13 },
                new Rating { Id = 27, Score = 2, VideoId = 14 },
                new Rating { Id = 28, Score = 1, VideoId = 14 },
                new Rating { Id = 29, Score = 5, VideoId = 15 },
                new Rating { Id = 30, Score = 2, VideoId = 15 },
                new Rating { Id = 61, Score = 3, VideoId = 32 },
                new Rating { Id = 62, Score = 3, VideoId = 33 },
                new Rating { Id = 63, Score = 0, VideoId = 34 },
                new Rating { Id = 64, Score = 5, VideoId = 36 },
                new Rating { Id = 65, Score = 4, VideoId = 37 },
                new Rating { Id = 66, Score = 4, VideoId = 38 },
                new Rating { Id = 67, Score = 3, VideoId = 39 },
                new Rating { Id = 68, Score = 4, VideoId = 41 },
                new Rating { Id = 69, Score = 2, VideoId = 42 },
                new Rating { Id = 70, Score = 1, VideoId = 46 },
                new Rating { Id = 71, Score = 5, VideoId = 46 },
                new Rating { Id = 72, Score = 2, VideoId = 47 },
                new Rating { Id = 73, Score = 3, VideoId = 47 },
                new Rating { Id = 74, Score = 3, VideoId = 48 },
                new Rating { Id = 75, Score = 4, VideoId = 48 },
                new Rating { Id = 76, Score = 5, VideoId = 48 },
                new Rating { Id = 77, Score = 4, VideoId = 49 },
                new Rating { Id = 78, Score = 4, VideoId = 49 },
                new Rating { Id = 79, Score = 3, VideoId = 45 },
                new Rating { Id = 80, Score = 4, VideoId = 46 },
                new Rating { Id = 81, Score = 2, VideoId = 48 },
                new Rating { Id = 82, Score = 1, VideoId = 40 },
                new Rating { Id = 83, Score = 5, VideoId = 41 },
                new Rating { Id = 84, Score = 2, VideoId = 44 },
                new Rating { Id = 85, Score = 3, VideoId = 60 },
                new Rating { Id = 86, Score = 2, VideoId = 61 },
                new Rating { Id = 87, Score = 4, VideoId = 62 },
                new Rating { Id = 88, Score = 5, VideoId = 63 },
                new Rating { Id = 89, Score = 4, VideoId = 64 },
                new Rating { Id = 90, Score = 3, VideoId = 65 },
                new Rating { Id = 91, Score = 2, VideoId = 66 },
                new Rating { Id = 92, Score = 4, VideoId = 67 },
                new Rating { Id = 93, Score = 1, VideoId = 68 },
                new Rating { Id = 94, Score = 3, VideoId = 69 },
                new Rating { Id = 95, Score = 3, VideoId = 70 },
                new Rating { Id = 96, Score = 2, VideoId = 71 },
                new Rating { Id = 97, Score = 4, VideoId = 72 },
                new Rating { Id = 98, Score = 3, VideoId = 73 },
                new Rating { Id = 99, Score = 5, VideoId = 74 },
                new Rating { Id = 100, Score = 4, VideoId = 75 },
                new Rating { Id = 101, Score = 2, VideoId = 75 },
                new Rating { Id = 102, Score = 3, VideoId = 76 },
                new Rating { Id = 103, Score = 5, VideoId = 76 },
                new Rating { Id = 104, Score = 4, VideoId = 77 },
                new Rating { Id = 105, Score = 1, VideoId = 77 },
                new Rating { Id = 106, Score = 2, VideoId = 78 },
                new Rating { Id = 107, Score = 5, VideoId = 79 },
                new Rating { Id = 108, Score = 3, VideoId = 80 },
                new Rating { Id = 109, Score = 4, VideoId = 81 },
                new Rating { Id = 110, Score = 2, VideoId = 82 },
                new Rating { Id = 111, Score = 3, VideoId = 83 },
                new Rating { Id = 112, Score = 5, VideoId = 84 },
                new Rating { Id = 113, Score = 4, VideoId = 85 },
                new Rating { Id = 114, Score = 1, VideoId = 85 },
                new Rating { Id = 115, Score = 2, VideoId = 86 },
                new Rating { Id = 116, Score = 5, VideoId = 88 },
                new Rating { Id = 117, Score = 3, VideoId = 89 },
                new Rating { Id = 118, Score = 5, VideoId = 90 },
                new Rating { Id = 119, Score = 3, VideoId = 91 },
                new Rating { Id = 120, Score = 0, VideoId = 92 },
                new Rating { Id = 121, Score = 4, VideoId = 93 },
                new Rating { Id = 122, Score = 2, VideoId = 94 },
                new Rating { Id = 123, Score = 3, VideoId = 95 },
                new Rating { Id = 124, Score = 5, VideoId = 96 },
                new Rating { Id = 125, Score = 4, VideoId = 97 },
                new Rating { Id = 126, Score = 1, VideoId = 98 },
                new Rating { Id = 127, Score = 2, VideoId = 99 },
                new Rating { Id = 128, Score = 5, VideoId = 100 },
                new Rating { Id = 129, Score = 3, VideoId = 101 },
                new Rating { Id = 130, Score = 5, VideoId = 102 },
                new Rating { Id = 131, Score = 3, VideoId = 103 },
                new Rating { Id = 132, Score = 0, VideoId = 104 },
                new Rating { Id = 133, Score = 0, VideoId = 105 },
                new Rating { Id = 134, Score = 3, VideoId = 106 },
                new Rating { Id = 135, Score = 5, VideoId = 107 },
                new Rating { Id = 136, Score = 3, VideoId = 108 },
                new Rating { Id = 137, Score = 0, VideoId = 109 },
                new Rating { Id = 138, Score = 0, VideoId = 110 },
                new Rating { Id = 139, Score = 0, VideoId = 111 },
                new Rating { Id = 140, Score = 0, VideoId = 112 },
                new Rating { Id = 141, Score = 3, VideoId = 113 },
                new Rating { Id = 142, Score = 5, VideoId = 114 },
                new Rating { Id = 143, Score = 3, VideoId = 115 },
                new Rating { Id = 144, Score = 0, VideoId = 46 },
                new Rating { Id = 145, Score = 0, VideoId = 47 },
                new Rating { Id = 146, Score = 0, VideoId = 45 },
                ///TvShows Rating
                new Rating { Id = 31, Score = 4, VideoId = 16 },
                new Rating { Id = 32, Score = 2, VideoId = 16 },
                new Rating { Id = 33, Score = 5, VideoId = 17 },
                new Rating { Id = 34, Score = 3, VideoId = 17 },
                new Rating { Id = 35, Score = 3, VideoId = 18 },
                new Rating { Id = 36, Score = 4, VideoId = 18 },
                new Rating { Id = 37, Score = 5, VideoId = 19 },
                new Rating { Id = 38, Score = 2, VideoId = 19 },
                new Rating { Id = 39, Score = 3, VideoId = 20 },
                new Rating { Id = 40, Score = 4, VideoId = 20 },
                new Rating { Id = 41, Score = 5, VideoId = 21 },
                new Rating { Id = 42, Score = 3, VideoId = 21 },
                new Rating { Id = 43, Score = 3, VideoId = 22 },
                new Rating { Id = 44, Score = 2, VideoId = 22 },
                new Rating { Id = 45, Score = 4, VideoId = 23 },
                new Rating { Id = 46, Score = 5, VideoId = 23 },
                new Rating { Id = 47, Score = 5, VideoId = 24 },
                new Rating { Id = 48, Score = 4, VideoId = 24 },
                new Rating { Id = 49, Score = 5, VideoId = 25 },
                new Rating { Id = 50, Score = 5, VideoId = 25 },
                new Rating { Id = 51, Score = 3, VideoId = 26 },
                new Rating { Id = 52, Score = 4, VideoId = 26 },
                new Rating { Id = 53, Score = 3, VideoId = 27 },
                new Rating { Id = 54, Score = 4, VideoId = 27 },
                new Rating { Id = 55, Score = 3, VideoId = 28 },
                new Rating { Id = 56, Score = 4, VideoId = 28 },
                new Rating { Id = 57, Score = 5, VideoId = 29 },
                new Rating { Id = 58, Score = 4, VideoId = 29 },
                new Rating { Id = 59, Score = 3, VideoId = 30 },
                new Rating { Id = 60, Score = 3, VideoId = 30 }
            );
            #endregion
            modelBuilder.Entity<TopTenMoviesByRatings>().HasNoKey().ToView("TopTenMoviesByRatings");
            modelBuilder.Entity<TopTenMoviesByScreenings>().HasNoKey().ToView("TopTenMoviesByScreenings");
            modelBuilder.Entity<TopMoviesByMostSoldTickets>().HasNoKey().ToView("TopMoviesByMostSoldTickets");
        }

    }

}
