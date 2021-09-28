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
        public DbSet<VideoActor> VideoActors { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<TopTenMoviesByRatings> TopTenMoviesByRatings { get; set; }
        public DbSet<TopTenMoviesByScreenings> TopTenMoviesByScreenings { get; set; }
        public DbSet<TopMoviesByMostSoldTickets> TopMoviesByMostSoldTickets { get; set; }
        public DbSet<Screening> Screenings { get; set; }

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
            modelBuilder.Entity<VideoActor>().HasData(
                new VideoActor { Id = 1, Name = "Tom Hanks", VideoId = 1 },
                new VideoActor { Id = 2, Name = "Matt Damon", VideoId = 1 },
                new VideoActor { Id = 3, Name = "Leonardo DiCaprio", VideoId = 2 },
                new VideoActor { Id = 4, Name = "Joseph Gordon-Levitt", VideoId = 2 },
                new VideoActor { Id = 5, Name = "Henry Cavill", VideoId = 3 },
                new VideoActor { Id = 6, Name = "Anna Shaffer", VideoId = 3 },
                new VideoActor { Id = 7, Name = "Tom Hanks", VideoId = 4 },
                new VideoActor { Id = 8, Name = "Robin Wright", VideoId = 4 },
                new VideoActor { Id = 9, Name = "Brad Pitt", VideoId = 5 },
                new VideoActor { Id = 10, Name = "Edward Norton", VideoId = 5 },
                new VideoActor { Id = 11, Name = "Will Smith", VideoId = 6 },
                new VideoActor { Id = 12, Name = "Martin Lawrence", VideoId = 6 },
                new VideoActor { Id = 13, Name = "Will Smith", VideoId = 7 },
                new VideoActor { Id = 14, Name = "Martin Lawrence", VideoId = 7 },
                new VideoActor { Id = 15, Name = "Will Smith", VideoId = 8 },
                new VideoActor { Id = 16, Name = "Martin Lawrence", VideoId = 8 },
                new VideoActor { Id = 17, Name = "Chris Pratt", VideoId = 9 },
                new VideoActor { Id = 18, Name = "Yvonne Strahovski", VideoId = 9 },
                new VideoActor { Id = 19, Name = "Sam Neill", VideoId = 10 },
                new VideoActor { Id = 20, Name = "Laura Dern", VideoId = 10 },
                new VideoActor { Id = 21, Name = "Jeff Goldblum", VideoId = 11 },
                new VideoActor { Id = 22, Name = "Julianne Moore", VideoId = 11 },
                new VideoActor { Id = 23, Name = "Sam Neill", VideoId = 12 },
                new VideoActor { Id = 24, Name = "William H. Macy", VideoId = 12 },
                new VideoActor { Id = 25, Name = "Chris Pratt", VideoId = 13 },
                new VideoActor { Id = 26, Name = "Bryce Dallas Howard", VideoId = 13 },
                new VideoActor { Id = 27, Name = "Chris Pratt", VideoId = 14 },
                new VideoActor { Id = 28, Name = "Bryce Dallas Howard", VideoId = 14 },
                new VideoActor { Id = 29, Name = "Tobey Maguire", VideoId = 15 },
                new VideoActor { Id = 30, Name = "Kristen Dunst", VideoId = 15 },
                new VideoActor { Id = 61, Name = "Tom Hanks", VideoId = 31 },
                new VideoActor { Id = 62, Name = "Matt Damon", VideoId = 31 },
                new VideoActor { Id = 63, Name = "Leonardo DiCaprio", VideoId = 32 },
                new VideoActor { Id = 64, Name = "Joseph Gordon-Levitt", VideoId = 32 },
                new VideoActor { Id = 65, Name = "Henry Cavill", VideoId = 33 },
                new VideoActor { Id = 66, Name = "Anna Shaffer", VideoId = 33 },
                new VideoActor { Id = 67, Name = "Tom Hanks", VideoId = 34 },
                new VideoActor { Id = 68, Name = "Robin Wright", VideoId = 34 },
                new VideoActor { Id = 69, Name = "Brad Pitt", VideoId = 35 },
                new VideoActor { Id = 70, Name = "Edward Norton", VideoId = 35 },
                new VideoActor { Id = 71, Name = "Will Smith", VideoId = 36 },
                new VideoActor { Id = 72, Name = "Martin Lawrence", VideoId = 36 },
                new VideoActor { Id = 73, Name = "Will Smith", VideoId = 37 },
                new VideoActor { Id = 74, Name = "Martin Lawrence", VideoId = 37 },
                new VideoActor { Id = 75, Name = "Will Smith", VideoId = 38 },
                new VideoActor { Id = 76, Name = "Martin Lawrence", VideoId = 38 },
                new VideoActor { Id = 77, Name = "Chris Pratt", VideoId = 39 },
                new VideoActor { Id = 78, Name = "Yvonne Strahovski", VideoId = 39 },
                new VideoActor { Id = 79, Name = "Sam Neill", VideoId = 40 },
                new VideoActor { Id = 80, Name = "Laura Dern", VideoId = 40 },
                new VideoActor { Id = 81, Name = "Jeff Goldblum", VideoId = 41 },
                new VideoActor { Id = 82, Name = "Julianne Moore", VideoId = 41 },
                new VideoActor { Id = 83, Name = "Sam Neill", VideoId = 42 },
                new VideoActor { Id = 84, Name = "William H. Macy", VideoId = 42 },
                new VideoActor { Id = 85, Name = "Chris Pratt", VideoId = 43 },
                new VideoActor { Id = 86, Name = "Bryce Dallas Howard", VideoId = 43 },
                new VideoActor { Id = 87, Name = "Chris Pratt", VideoId = 44 },
                new VideoActor { Id = 88, Name = "Bryce Dallas Howard", VideoId = 44 },
                new VideoActor { Id = 89, Name = "Tobey Maguire", VideoId = 45 },
                new VideoActor { Id = 90, Name = "Kristen Dunst", VideoId = 45 },
                new VideoActor { Id = 91, Name = "Tom Hanks", VideoId = 46 },
                new VideoActor { Id = 92, Name = "Matt Damon", VideoId = 46 },
                new VideoActor { Id = 93, Name = "Leonardo DiCaprio", VideoId = 47 },
                new VideoActor { Id = 94, Name = "Joseph Gordon-Levitt", VideoId = 47 },
                new VideoActor { Id = 95, Name = "Henry Cavill", VideoId = 48 },
                new VideoActor { Id = 96, Name = "Anna Shaffer", VideoId = 48 },
                new VideoActor { Id = 97, Name = "Tom Hanks", VideoId = 49 },
                new VideoActor { Id = 98, Name = "Robin Wright", VideoId = 49 },
                new VideoActor { Id = 99, Name = "Brad Pitt", VideoId = 50 },
                new VideoActor { Id = 100, Name = "Edward Norton", VideoId = 50 },
                new VideoActor { Id = 101, Name = "Will Smith", VideoId = 51 },
                new VideoActor { Id = 102, Name = "Martin Lawrence", VideoId = 51 },
                new VideoActor { Id = 103, Name = "Will Smith", VideoId = 52 },
                new VideoActor { Id = 104, Name = "Martin Lawrence", VideoId = 52 },
                new VideoActor { Id = 105, Name = "Will Smith", VideoId = 53 },
                new VideoActor { Id = 106, Name = "Martin Lawrence", VideoId = 53 },
                new VideoActor { Id = 107, Name = "Chris Pratt", VideoId = 54 },
                new VideoActor { Id = 108, Name = "Yvonne Strahovski", VideoId = 54 },
                new VideoActor { Id = 109, Name = "Sam Neill", VideoId = 55 },
                new VideoActor { Id = 110, Name = "Laura Dern", VideoId = 55 },
                new VideoActor { Id = 111, Name = "Jeff Goldblum", VideoId = 56 },
                new VideoActor { Id = 112, Name = "Julianne Moore", VideoId = 56 },
                new VideoActor { Id = 113, Name = "Sam Neill", VideoId = 57 },
                new VideoActor { Id = 114, Name = "William H. Macy", VideoId = 57 },
                new VideoActor { Id = 115, Name = "Chris Pratt", VideoId = 58 },
                new VideoActor { Id = 116, Name = "Bryce Dallas Howard", VideoId = 58 },
                new VideoActor { Id = 117, Name = "Chris Pratt", VideoId = 59 },
                new VideoActor { Id = 118, Name = "Bryce Dallas Howard", VideoId = 59 },
                new VideoActor { Id = 119, Name = "Tobey Maguire", VideoId = 60 },
                new VideoActor { Id = 120, Name = "Kristen Dunst", VideoId = 60 },
                new VideoActor { Id = 121, Name = "Tobey Maguire", VideoId = 62 },
                new VideoActor { Id = 122, Name = "Kristen Dunst", VideoId = 62 },
                new VideoActor { Id = 123, Name = "Tobey Maguire", VideoId = 63 },
                new VideoActor { Id = 124, Name = "Kristen Dunst", VideoId = 63 },
                new VideoActor { Id = 125, Name = "Tobey Maguire", VideoId = 64 },
                new VideoActor { Id = 126, Name = "Kristen Dunst", VideoId = 64 },
                new VideoActor { Id = 127, Name = "Tobey Maguire", VideoId = 65 },
                new VideoActor { Id = 128, Name = "Kristen Dunst", VideoId = 65 },
                new VideoActor { Id = 129, Name = "Tobey Maguire", VideoId = 66 },
                new VideoActor { Id = 130, Name = "Kristen Dunst", VideoId = 66 },
                new VideoActor { Id = 131, Name = "Tobey Maguire", VideoId = 67 },
                new VideoActor { Id = 132, Name = "Kristen Dunst", VideoId = 67 },
                new VideoActor { Id = 133, Name = "Tobey Maguire", VideoId = 68 },
                new VideoActor { Id = 134, Name = "Kristen Dunst", VideoId = 68 },
                new VideoActor { Id = 135, Name = "Tobey Maguire", VideoId = 69 },
                new VideoActor { Id = 136, Name = "Kristen Dunst", VideoId = 69 },
                new VideoActor { Id = 137, Name = "Tobey Maguire", VideoId = 70 },
                new VideoActor { Id = 138, Name = "Kristen Dunst", VideoId = 70 },
                new VideoActor { Id = 139, Name = "Tobey Maguire", VideoId = 71 },
                new VideoActor { Id = 140, Name = "Kristen Dunst", VideoId = 71 },
                new VideoActor { Id = 141, Name = "Tobey Maguire", VideoId = 72 },
                new VideoActor { Id = 142, Name = "Kristen Dunst", VideoId = 72 },
                new VideoActor { Id = 143, Name = "Tobey Maguire", VideoId = 73 },
                new VideoActor { Id = 144, Name = "Kristen Dunst", VideoId = 73 },
                new VideoActor { Id = 145, Name = "Tobey Maguire", VideoId = 74 },
                new VideoActor { Id = 146, Name = "Kristen Dunst", VideoId = 74 },
                new VideoActor { Id = 147, Name = "Tobey Maguire", VideoId = 75 },
                new VideoActor { Id = 148, Name = "Kristen Dunst", VideoId = 75 },
                new VideoActor { Id = 149, Name = "Tobey Maguire", VideoId = 76 },
                new VideoActor { Id = 151, Name = "Kristen Dunst", VideoId = 76 },
                new VideoActor { Id = 152, Name = "Tobey Maguire", VideoId = 77 },
                new VideoActor { Id = 153, Name = "Kristen Dunst", VideoId = 77 },
                new VideoActor { Id = 154, Name = "Tobey Maguire", VideoId = 78 },
                new VideoActor { Id = 155, Name = "Kristen Dunst", VideoId = 78 },
                new VideoActor { Id = 156, Name = "Tobey Maguire", VideoId = 79 },
                new VideoActor { Id = 157, Name = "Kristen Dunst", VideoId = 79 },
                new VideoActor { Id = 158, Name = "Tobey Maguire", VideoId = 80 },
                new VideoActor { Id = 159, Name = "Kristen Dunst", VideoId = 80 },
                new VideoActor { Id = 160, Name = "Tobey Maguire", VideoId = 81 },
                new VideoActor { Id = 161, Name = "Kristen Dunst", VideoId = 81 },
                new VideoActor { Id = 162, Name = "Tobey Maguire", VideoId = 82 },
                new VideoActor { Id = 163, Name = "Kristen Dunst", VideoId = 82 },
                new VideoActor { Id = 164, Name = "Tobey Maguire", VideoId = 83 },
                new VideoActor { Id = 165, Name = "Kristen Dunst", VideoId = 83 },
                new VideoActor { Id = 166, Name = "Tobey Maguire", VideoId = 84 },
                new VideoActor { Id = 167, Name = "Kristen Dunst", VideoId = 84 },
                new VideoActor { Id = 168, Name = "Tobey Maguire", VideoId = 85 },
                new VideoActor { Id = 169, Name = "Kristen Dunst", VideoId = 85 },
                new VideoActor { Id = 170, Name = "Tobey Maguire", VideoId = 86 },
                new VideoActor { Id = 171, Name = "Kristen Dunst", VideoId = 86 },
                new VideoActor { Id = 172, Name = "Tobey Maguire", VideoId = 87 },
                new VideoActor { Id = 173, Name = "Kristen Dunst", VideoId = 87 },
                new VideoActor { Id = 174, Name = "Tobey Maguire", VideoId = 88 },
                new VideoActor { Id = 175, Name = "Kristen Dunst", VideoId = 88 },
                new VideoActor { Id = 176, Name = "Tobey Maguire", VideoId = 89 },
                new VideoActor { Id = 177, Name = "Kristen Dunst", VideoId = 89 },
                new VideoActor { Id = 178, Name = "Tobey Maguire", VideoId = 90 },
                new VideoActor { Id = 179, Name = "Kristen Dunst", VideoId = 90 },
                new VideoActor { Id = 180, Name = "Tobey Maguire", VideoId = 91 },
                new VideoActor { Id = 181, Name = "Kristen Dunst", VideoId = 91 },
                new VideoActor { Id = 182, Name = "Tobey Maguire", VideoId = 92 },
                new VideoActor { Id = 183, Name = "Kristen Dunst", VideoId = 92 },
                new VideoActor { Id = 184, Name = "Tobey Maguire", VideoId = 94 },
                new VideoActor { Id = 185, Name = "Kristen Dunst", VideoId = 95 },
                new VideoActor { Id = 186, Name = "Tobey Maguire", VideoId = 96 },
                new VideoActor { Id = 187, Name = "Kristen Dunst", VideoId = 97 },
                new VideoActor { Id = 188, Name = "Tobey Maguire", VideoId = 98 },
                new VideoActor { Id = 189, Name = "Kristen Dunst", VideoId = 99 },
                new VideoActor { Id = 190, Name = "Tobey Maguire", VideoId = 100 },
                new VideoActor { Id = 191, Name = "Kristen Dunst", VideoId = 101 },
                new VideoActor { Id = 192, Name = "Tobey Maguire", VideoId = 102 },
                new VideoActor { Id = 193, Name = "Kristen Dunst", VideoId = 103 },
                new VideoActor { Id = 194, Name = "Tobey Maguire", VideoId = 104 },
                new VideoActor { Id = 195, Name = "Kristen Dunst", VideoId = 105 },
                new VideoActor { Id = 196, Name = "Tobey Maguire", VideoId = 106 },
                new VideoActor { Id = 197, Name = "Kristen Dunst", VideoId = 107 },
                new VideoActor { Id = 198, Name = "Tobey Maguire", VideoId = 108 },
                new VideoActor { Id = 199, Name = "Kristen Dunst", VideoId = 109 },
                new VideoActor { Id = 200, Name = "Tobey Maguire", VideoId = 110 },
                new VideoActor { Id = 201, Name = "Kristen Dunst", VideoId = 111 },
                new VideoActor { Id = 202, Name = "Tobey Maguire", VideoId = 112 },
                new VideoActor { Id = 203, Name = "Kristen Dunst", VideoId = 113 },
                new VideoActor { Id = 204, Name = "Tobey Maguire", VideoId = 114 },
                new VideoActor { Id = 205, Name = "Kristen Dunst", VideoId = 115 },
                ///Tv Shows
                new VideoActor { Id = 31, Name = "Zoe Kazan", VideoId = 16 },
                new VideoActor { Id = 32, Name = "Betty Gabriel", VideoId = 16 },
                new VideoActor { Id = 33, Name = "Ursula Cobero", VideoId = 17 },
                new VideoActor { Id = 34, Name = "Alvaro Morte", VideoId = 17 },
                new VideoActor { Id = 35, Name = "Nicole Kidman", VideoId = 18 },
                new VideoActor { Id = 36, Name = "Melissa McCarthy", VideoId = 18 },
                new VideoActor { Id = 37, Name = "Andrew Lincoln", VideoId = 19 },
                new VideoActor { Id = 38, Name = "Norman Reedus", VideoId = 19 },
                new VideoActor { Id = 39, Name = "Emilia Clarke", VideoId = 20 },
                new VideoActor { Id = 40, Name = "Peter Dinklage", VideoId = 20 },
                new VideoActor { Id = 41, Name = "Melissa Roxburgh", VideoId = 21 },
                new VideoActor { Id = 42, Name = "Josh Dallas", VideoId = 21 },
                new VideoActor { Id = 43, Name = "Andy Samberg", VideoId = 22 },
                new VideoActor { Id = 44, Name = "Stephanie Beatriz", VideoId = 22 },
                new VideoActor { Id = 45, Name = "Bryan Cranston", VideoId = 23 },
                new VideoActor { Id = 46, Name = "Aaron Paul", VideoId = 23 },
                new VideoActor { Id = 47, Name = "Jennifer Aniston", VideoId = 24 },
                new VideoActor { Id = 48, Name = "Courteney Cox", VideoId = 24 },
                new VideoActor { Id = 49, Name = "Dominic Purcell", VideoId = 25 },
                new VideoActor { Id = 50, Name = "Wentworth Miller", VideoId = 25 },
                new VideoActor { Id = 51, Name = "Matthew Gray Gubler", VideoId = 26 },
                new VideoActor { Id = 52, Name = "Kristen Vangsness", VideoId = 26 },
                new VideoActor { Id = 53, Name = "Shabana Azmi", VideoId = 27 },
                new VideoActor { Id = 54, Name = "Kunal Kapoor", VideoId = 27 },
                new VideoActor { Id = 55, Name = "James Spader", VideoId = 28 },
                new VideoActor { Id = 56, Name = "Megane Boone", VideoId = 28 },
                new VideoActor { Id = 57, Name = "Hugh Lauri", VideoId = 29 },
                new VideoActor { Id = 58, Name = "Omar Epps", VideoId = 29 },
                new VideoActor { Id = 59, Name = "Taylor Kitsch", VideoId = 30 },
                new VideoActor { Id = 60, Name = "Michael C. Hall", VideoId = 30 }
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
