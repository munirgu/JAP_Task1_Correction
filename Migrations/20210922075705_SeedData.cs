using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[,]
                {
                    { 62, "Matt Damon", 31 },
                    { 61, "Tom Hanks", 31 }
                });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ReleaseDate", "Title" },
                values: new object[] { "Famous movie, first time displayed in 2003", new DateTime(2003, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider 2" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 114, "Directed by James Cameron. With Arnold Schwarzenegger, Michael Biehn, Linda Hamilton, Paul Winfield. A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1991, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Terminator 2", 1 },
                    { 92, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2012, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 9", 1 },
                    { 91, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2001, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 8", 1 },
                    { 90, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2000, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 7", 1 },
                    { 89, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 6", 1 },
                    { 88, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2001, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 5", 1 },
                    { 87, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2002, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 4", 1 },
                    { 86, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2005, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 3", 1 },
                    { 93, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2012, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Number 1", 1 },
                    { 85, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 2", 1 },
                    { 83, "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2015, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator 4", 1 },
                    { 82, "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator 3", 1 },
                    { 81, "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2013, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator 2", 1 },
                    { 80, "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator 1", 1 },
                    { 79, "A nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator", 1 },
                    { 78, "An orphaned girl with an evil stepmother, has big dreams and with the help of her Fabulous Godmother, she perseveres to make them come true.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2017, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cinderella 2", 1 },
                    { 77, "Cinderella, an orphaned girl with an evil stepmother, has big dreams and with the help of her Fabulous Godmother, she perseveres to make them come true.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2015, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cinderella", 1 },
                    { 84, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2007, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 1", 1 },
                    { 94, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Number 2", 1 },
                    { 95, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2007, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Number 3", 1 },
                    { 76, "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jungle Cruise 2", 1 },
                    { 113, "Directed by James Cameron. With Arnold Schwarzenegger, Michael Biehn, Linda Hamilton, Paul Winfield. A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1989, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Terminator 1", 1 },
                    { 112, "Directed by James Cameron. With Arnold Schwarzenegger, Michael Biehn, Linda Hamilton, Paul Winfield. A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Terminator", 1 },
                    { 111, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2015, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious 9", 1 },
                    { 110, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2011, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious 8", 1 },
                    { 109, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2008, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious 7", 1 },
                    { 108, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2005, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious 6", 1 },
                    { 107, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2004, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious 5", 1 },
                    { 106, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2003, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious 4", 1 },
                    { 105, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2002, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious 3", 1 },
                    { 104, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2001, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious 2", 1 },
                    { 103, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1999, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious 1", 1 },
                    { 102, "The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and betrayal.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1997, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and Furious", 1 },
                    { 101, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Number 9", 1 },
                    { 100, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Number 8", 1 },
                    { 99, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2008, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Number 7", 1 },
                    { 98, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2003, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Number 6", 1 },
                    { 97, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2009, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Number 5", 1 },
                    { 115, "Directed by James Cameron. With Arnold Schwarzenegger, Michael Biehn, Linda Hamilton, Paul Winfield. A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1995, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Terminator 3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 96, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2008, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie Number 4", 1 },
                    { 75, "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2018, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jungle Cruise 1", 1 },
                    { 73, "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Suicide Squad 3", 1 },
                    { 50, "Life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2011, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption 5", 1 },
                    { 49, "An worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1999, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 6", 1 },
                    { 48, "An office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1999, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 5", 1 },
                    { 47, "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump 4", 1 },
                    { 46, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider 5", 1 },
                    { 45, "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1999, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 4", 1 },
                    { 44, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction 4", 1 },
                    { 43, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2011, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring 3", 1 },
                    { 51, "An office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2001, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 6", 1 },
                    { 42, "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2004, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List 3", 1 },
                    { 40, "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2018, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption 2", 1 },
                    { 39, "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2016, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider", 1 },
                    { 38, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cosmos", 1 },
                    { 37, "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Our Planet", 1 },
                    { 36, "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2017, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blue Planet II", 1 },
                    { 35, "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1986, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chernobyl", 1 },
                    { 34, "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2001, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Band of Brothers", 1 },
                    { 33, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight 4", 1 },
                    { 41, "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2013, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men 3", 1 },
                    { 74, "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2017, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jungle Cruise", 1 },
                    { 52, "The Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2013, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump 4", 1 },
                    { 54, "High school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider 9", 1 },
                    { 72, "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2014, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Suicide Squad 2", 1 },
                    { 71, "Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2011, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Suicide Squad 1", 1 },
                    { 70, "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2007, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Suicide Squad", 1 },
                    { 69, "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a young girl orphaned from a devastating house.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don't Breathe 4", 1 },
                    { 68, "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a young girl orphaned from a devastating house fire. Their quiet life together is shattered when a group of criminals kidnap the girl.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2018, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don't Breathe 3", 1 },
                    { 67, "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a young girl orphaned from a devastating house fire. Their quiet life together is shattered when a group of criminals kidnap the girl.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2017, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don't Breathe 2", 1 },
                    { 66, "Shang-Chi must confront the past he thought he left behind when he is drawn into the web of the mysterious Ten Rings organization.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2003, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shang-Chi and the Legend of the Ten Rings", 1 },
                    { 65, "An eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and The Chamber Of Secrets", 1 },
                    { 53, "An office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2005, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 7", 1 },
                    { 64, "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1999, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Philosopher's Stone", 1 },
                    { 62, "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2011, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar 2", 1 },
                    { 61, "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2010, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar 1", 1 },
                    { 60, "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2009, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar", 1 },
                    { 59, "Luke and Han Solo must free Leilas and destroy the powerful weapon created by the Galactic Empire.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2015, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: A New Hope (Episode VIII)", 1 },
                    { 58, "Luke and Han Solo must free Leilas and destroy the powerful weapon created by the Galactic Empire.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2014, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: A New Hope (Episode VII)", 1 },
                    { 57, "Luke and Han Solo must free Leilas and destroy the powerful weapon created by the Galactic Empire.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2013, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: A New Hope (Episode VI)", 1 },
                    { 56, "Luke and Han Solo must free Leilas and destroy the powerful weapon created by the Galactic Empire.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2011, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: A New Hope (Episode V)", 1 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[] { 55, "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2009, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: A New Hope (Episode IV)", 1 });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[] { 63, "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2012, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar 3", 1 });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[] { 32, "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather 4", 1 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "VideoId" },
                values: new object[,]
                {
                    { 61, 3, 32 },
                    { 95, 3, 70 },
                    { 94, 3, 69 },
                    { 93, 1, 68 },
                    { 91, 2, 66 },
                    { 90, 3, 65 },
                    { 89, 4, 64 },
                    { 88, 5, 63 },
                    { 87, 4, 62 },
                    { 86, 2, 61 },
                    { 85, 3, 60 },
                    { 78, 4, 49 },
                    { 77, 4, 49 },
                    { 81, 2, 48 },
                    { 76, 5, 48 },
                    { 75, 4, 48 },
                    { 74, 3, 48 },
                    { 73, 3, 47 },
                    { 96, 2, 71 },
                    { 97, 4, 72 },
                    { 98, 3, 73 },
                    { 99, 5, 74 },
                    { 117, 3, 89 },
                    { 116, 5, 88 },
                    { 115, 2, 86 },
                    { 114, 1, 85 },
                    { 113, 4, 85 },
                    { 112, 5, 84 },
                    { 111, 3, 83 },
                    { 110, 2, 82 },
                    { 72, 2, 47 },
                    { 109, 4, 81 },
                    { 107, 5, 79 },
                    { 106, 2, 78 },
                    { 105, 1, 77 },
                    { 104, 4, 77 },
                    { 103, 5, 76 },
                    { 102, 3, 76 },
                    { 101, 2, 75 },
                    { 100, 4, 75 },
                    { 108, 3, 80 },
                    { 80, 4, 46 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "VideoId" },
                values: new object[,]
                {
                    { 92, 4, 67 },
                    { 70, 1, 46 },
                    { 71, 5, 46 },
                    { 67, 3, 39 },
                    { 65, 4, 37 },
                    { 82, 1, 40 },
                    { 64, 5, 36 },
                    { 68, 4, 41 },
                    { 83, 5, 41 },
                    { 63, 4, 34 },
                    { 69, 2, 42 },
                    { 62, 3, 33 },
                    { 66, 4, 38 },
                    { 79, 3, 45 },
                    { 84, 2, 44 }
                });

            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[,]
                {
                    { 194, "Tobey Maguire", 104 },
                    { 70, "Edward Norton", 35 },
                    { 158, "Tobey Maguire", 80 },
                    { 159, "Kristen Dunst", 80 },
                    { 69, "Brad Pitt", 35 },
                    { 160, "Tobey Maguire", 81 },
                    { 161, "Kristen Dunst", 81 },
                    { 68, "Robin Wright", 34 },
                    { 162, "Tobey Maguire", 82 },
                    { 198, "Tobey Maguire", 108 },
                    { 163, "Kristen Dunst", 82 },
                    { 67, "Tom Hanks", 34 },
                    { 164, "Tobey Maguire", 83 },
                    { 157, "Kristen Dunst", 79 },
                    { 165, "Kristen Dunst", 83 },
                    { 156, "Tobey Maguire", 79 },
                    { 200, "Tobey Maguire", 110 },
                    { 148, "Kristen Dunst", 75 },
                    { 74, "Martin Lawrence", 37 },
                    { 203, "Kristen Dunst", 113 },
                    { 73, "Will Smith", 37 },
                    { 149, "Tobey Maguire", 76 },
                    { 202, "Tobey Maguire", 112 },
                    { 199, "Kristen Dunst", 109 },
                    { 151, "Kristen Dunst", 76 },
                    { 72, "Martin Lawrence", 36 },
                    { 152, "Tobey Maguire", 77 }
                });

            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[,]
                {
                    { 153, "Kristen Dunst", 77 },
                    { 71, "Will Smith", 36 },
                    { 154, "Tobey Maguire", 78 },
                    { 155, "Kristen Dunst", 78 },
                    { 201, "Kristen Dunst", 111 },
                    { 197, "Kristen Dunst", 107 },
                    { 166, "Tobey Maguire", 84 },
                    { 167, "Kristen Dunst", 84 },
                    { 193, "Kristen Dunst", 103 },
                    { 192, "Tobey Maguire", 102 },
                    { 191, "Kristen Dunst", 101 },
                    { 190, "Tobey Maguire", 100 },
                    { 189, "Kristen Dunst", 99 },
                    { 188, "Tobey Maguire", 98 },
                    { 187, "Kristen Dunst", 97 },
                    { 186, "Tobey Maguire", 96 },
                    { 185, "Kristen Dunst", 95 },
                    { 184, "Tobey Maguire", 94 },
                    { 183, "Kristen Dunst", 93 },
                    { 182, "Tobey Maguire", 92 },
                    { 181, "Kristen Dunst", 91 },
                    { 180, "Tobey Maguire", 91 },
                    { 179, "Kristen Dunst", 90 },
                    { 178, "Tobey Maguire", 90 },
                    { 177, "Kristen Dunst", 89 },
                    { 66, "Anna Shaffer", 33 },
                    { 65, "Henry Cavill", 33 },
                    { 168, "Tobey Maguire", 85 },
                    { 196, "Tobey Maguire", 106 },
                    { 147, "Tobey Maguire", 75 },
                    { 170, "Tobey Maguire", 86 },
                    { 195, "Kristen Dunst", 105 },
                    { 171, "Kristen Dunst", 86 },
                    { 173, "Kristen Dunst", 87 },
                    { 64, "Joseph Gordon-Levitt", 32 },
                    { 174, "Tobey Maguire", 88 },
                    { 175, "Kristen Dunst", 88 },
                    { 63, "Leonardo DiCaprio", 32 },
                    { 176, "Tobey Maguire", 89 },
                    { 172, "Tobey Maguire", 87 },
                    { 169, "Kristen Dunst", 85 },
                    { 76, "Martin Lawrence", 38 }
                });

            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[,]
                {
                    { 146, "Kristen Dunst", 74 },
                    { 104, "Martin Lawrence", 52 },
                    { 105, "Will Smith", 53 },
                    { 106, "Martin Lawrence", 53 },
                    { 107, "Chris Pratt", 54 },
                    { 108, "Yvonne Strahovski", 54 },
                    { 109, "Sam Neill", 55 },
                    { 103, "Will Smith", 52 },
                    { 110, "Laura Dern", 55 },
                    { 112, "Julianne Moore", 56 },
                    { 113, "Sam Neill", 57 },
                    { 114, "William H. Macy", 57 },
                    { 115, "Chris Pratt", 58 },
                    { 116, "Bryce Dallas Howard", 58 },
                    { 117, "Chris Pratt", 59 },
                    { 111, "Jeff Goldblum", 56 },
                    { 102, "Martin Lawrence", 51 },
                    { 101, "Will Smith", 51 },
                    { 100, "Edward Norton", 50 },
                    { 91, "Tom Hanks", 46 },
                    { 92, "Matt Damon", 46 },
                    { 90, "Kristen Dunst", 45 },
                    { 89, "Tobey Maguire", 45 },
                    { 93, "Leonardo DiCaprio", 47 },
                    { 94, "Joseph Gordon-Levitt", 47 },
                    { 88, "Bryce Dallas Howard", 44 },
                    { 87, "Chris Pratt", 44 },
                    { 95, "Henry Cavill", 48 },
                    { 96, "Anna Shaffer", 48 },
                    { 86, "Bryce Dallas Howard", 43 },
                    { 85, "Chris Pratt", 43 },
                    { 97, "Tom Hanks", 49 },
                    { 98, "Robin Wright", 49 },
                    { 99, "Brad Pitt", 50 },
                    { 118, "Bryce Dallas Howard", 59 },
                    { 75, "Will Smith", 38 },
                    { 84, "William H. Macy", 42 },
                    { 120, "Kristen Dunst", 60 },
                    { 79, "Sam Neill", 40 },
                    { 135, "Tobey Maguire", 69 },
                    { 136, "Kristen Dunst", 69 },
                    { 137, "Tobey Maguire", 70 }
                });

            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[,]
                {
                    { 138, "Kristen Dunst", 70 },
                    { 78, "Yvonne Strahovski", 39 },
                    { 134, "Kristen Dunst", 68 },
                    { 139, "Tobey Maguire", 71 },
                    { 77, "Chris Pratt", 39 },
                    { 141, "Tobey Maguire", 72 },
                    { 142, "Kristen Dunst", 72 },
                    { 143, "Tobey Maguire", 73 },
                    { 144, "Kristen Dunst", 73 },
                    { 145, "Tobey Maguire", 74 },
                    { 140, "Kristen Dunst", 71 },
                    { 133, "Tobey Maguire", 68 },
                    { 80, "Laura Dern", 40 },
                    { 132, "Kristen Dunst", 67 },
                    { 83, "Sam Neill", 42 },
                    { 121, "Tobey Maguire", 62 },
                    { 122, "Kristen Dunst", 62 },
                    { 82, "Julianne Moore", 41 },
                    { 123, "Tobey Maguire", 63 },
                    { 124, "Kristen Dunst", 63 },
                    { 81, "Jeff Goldblum", 41 },
                    { 125, "Tobey Maguire", 64 },
                    { 126, "Kristen Dunst", 64 },
                    { 127, "Tobey Maguire", 65 },
                    { 128, "Kristen Dunst", 65 },
                    { 129, "Tobey Maguire", 66 },
                    { 130, "Kristen Dunst", 66 },
                    { 204, "Tobey Maguire", 114 },
                    { 131, "Tobey Maguire", 67 },
                    { 119, "Tobey Maguire", 60 },
                    { 205, "Kristen Dunst", 115 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ReleaseDate", "Title" },
                values: new object[] { "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider" });
        }
    }
}
