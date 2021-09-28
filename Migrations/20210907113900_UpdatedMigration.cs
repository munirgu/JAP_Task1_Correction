using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class UpdatedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Score",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "Score",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                column: "Score",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                column: "Score",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                column: "Score",
                value: 4);

            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Brad Pitt");

            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Edward Norton");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[] { "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://www.new-video.de/co/fightclu.jpg", new DateTime(1999, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club", 1 });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 30, "Max McLaughlin is an American cop who arrives in Berlin in the summer of 1946 to help create a police force in the chaotic aftermath of the war.", "https://d2iltjk184xms5.cloudfront.net/uploads/photo/file/382771/e6aace1d14a77a2badd179ba926ac1b3-defeatedposter.jpg", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Defeated", 2 },
                    { 29, "An antisocial maverick doctor who specializes in diagnostic medicine does whatever it takes to solve puzzling cases that come his way using his crack team of doctors and his wits.", "https://www.pelisxd.com/wp-content/uploads/2020/04/house-15611-poster.jpg", new DateTime(2004, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "House", 2 },
                    { 28, "A new FBI profiler, Elizabeth Keen, has her entire life uprooted when a mysterious criminal, Raymond Reddington, who has eluded capture for decades, turns himself in and insists on speaking only to her.", "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6259/6259110_so.jpg", new DateTime(2013, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Blacklist", 2 },
                    { 27, "The series focuses on the rise and fall of Mughal Empire through generations from Babur to Aurangzeb.", "https://i1.wp.com/hdmoviez.biz/wp-content/uploads/2021/08/The-Empire-2021-S01.png?w=500", new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Empire", 2 },
                    { 26, "The cases of the F.B.I. Behavioral Analysis Unit (B.A.U.), an elite group of profilers who analyze the nation's most dangerous serial killers and individual heinous crimes in an effort to anticipate their next moves before they strike again.", "https://th.bing.com/th/id/OIP.ZUzAwzdzq780bQ9KjtJ2xgHaKd?pid=ImgDet&rs=1", new DateTime(2005, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Criminal Minds", 2 },
                    { 25, "Due to a political conspiracy, an innocent man is sent to death row and his only hope is his brother, who makes it his mission to deliberately get himself sent to the same prison in order to break the both of them out, from the inside.", "https://cdn.cinematerial.com/p/500x/rkevtzje/prison-break-movie-cover.jpg", new DateTime(2005, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prison Break", 2 },
                    { 24, "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.", "https://images.saymedia-content.com/.image/t_share/MTc2NTc0ODUzMDQ0Nzc0NjE5/tv-shows-like-friends.jpg", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friends", 2 },
                    { 23, "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "https://th.bing.com/th/id/R.7daca6eab99b67e6cd63f01bfdf3a41a?rik=QqKBdpltIOVmrw&riu=http%3a%2f%2fwww.notrecinema.com%2fimages%2fcache%2fbreaking-bad-poster_399299_31440.jpg&ehk=YPzSvSux8LNPKZgfHqAfYce7Rz6%2fafdR6GZvT1TE6J8%3d&risl=&pid=ImgRaw&r=0", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad", 2 },
                    { 22, "Comedy series following the exploits of Det. Jake Peralta and his diverse, lovable colleagues as they police the NYPD's 99th Precinct.", "https://th.bing.com/th/id/R.6ed153b03e7aae27d1c14006c3ffd4eb?rik=E9ceeJRcwZwm5w&pid=ImgRaw&r=0", new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooklyn Nine-Nine", 2 },
                    { 20, "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", "https://th.bing.com/th/id/R.e024c02d31c823d7d68e23550207fb3e?rik=p3JUYI%2bmYV91RA&pid=ImgRaw&r=0", new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones", 2 },
                    { 19, "Sheriff Deputy Rick Grimes wakes up from a coma to learn the world is in ruins and must lead a group of survivors to stay alive.", "https://th.bing.com/th/id/R.b904983728868f3ed5ce79fb819c8699?rik=LmhMRcd0HZRPew&riu=http%3a%2f%2fpics.filmaffinity.com%2fThe_Walking_Dead_TV_Series-285470099-large.jpg&ehk=8lZYkdu%2fiSDQQ%2f9RKV8aveMd7qagFCj573%2fZ1rNnfzQ%3d&risl=&pid=ImgRaw&r=0", new DateTime(2010, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Walking Dead", 2 },
                    { 18, "Nine stressed city dwellers visit a boutique health-and-wellness resort that promises healing and transformation. The resort's director is a woman on a mission to reinvigorate their tired minds and bodies.", "https://th.bing.com/th/id/OIP.yclr5qYMsedWaCB1yJRQdgHaLU?pid=ImgDet&rs=1", new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nine Perfect Strangers", 2 },
                    { 17, "An unusual group of robbers attempt to carry out the most perfect robbery in Spanish history - stealing 2.4 billion euros from the Royal Mint of Spain.", "https://i1.wp.com/www.realhypegh.com/wp-content/uploads/2021/09/Money-Heist.jpg?resize=696%2C1031&ssl=1", new DateTime(2017, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Money Heist", 2 },
                    { 16, "When family man Nick Brewer is abducted in a crime with a sinister online twist, those closest to him race to uncover who is behind it and why.", "https://www.what-song.com/_next/image?url=https:%2F%2Fimage.tmdb.org%2Ft%2Fp%2Fw500%2Fq42t4S113jebD1khigJt8z3m1mD.jpg&w=828&q=75", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clickbait", 2 },
                    { 15, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2002, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man", 1 },
                    { 14, "When the island's dormant volcano begins roaring to life, Owen and Claire mount a campaign to rescue the remaining dinosaurs from this extinction-level event.", "https://vignette.wikia.nocookie.net/cinemorgue/images/d/df/322699f120c17c2728457969b59af12c.jpg/revision/latest?cb=20180325190743", new DateTime(2018, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurassic World: Fallen Kingdom", 1 },
                    { 13, "A new theme park, built on the original site of Jurassic Park, creates a genetically modified hybrid dinosaur, the Indominus Rex, which escapes containment and goes on a killing spree.", "https://th.bing.com/th/id/OIP.-3smAFf-8f3Xye1-VODc5AHaLH?pid=ImgDet&rs=1", new DateTime(2015, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurassic World", 1 },
                    { 12, "A decidedly odd couple with ulterior motives convince Dr. Grant to go to Isla Sorna for a holiday, but their unexpected landing startles the island's new inhabitants.", "https://th.bing.com/th/id/OIP.mMwLmfEru8a0Y86217RLJwHaLH?pid=ImgDet&rs=1", new DateTime(2001, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurassic Park III", 1 },
                    { 11, "A research team is sent to the Jurassic Park Site B island to study the dinosaurs there, while an InGen team approaches with another agenda.", "https://vignette.wikia.nocookie.net/cinemorgue/images/d/d8/11168888_800.jpg/revision/latest?cb=20150519044035", new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lost World: Jurassic Park", 1 },
                    { 10, "A pragmatic paleontologist visiting an almost complete theme park is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.", "https://th.bing.com/th/id/R.795762624b2ebe035d8ebe1000397e70?rik=tM2O0EXzddMb7g&riu=http%3a%2f%2fwww.sf-fan.de%2fwp-content%2fuploads%2f2011%2f07%2fjurassic-park-poster.jpg&ehk=ISz78v6xTLdiIOGEtMFG9Qxj29cLWqZWOeZ9OUA8rGk%3d&risl=&pid=ImgRaw&r=0", new DateTime(1993, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurassic Park", 1 },
                    { 9, "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "https://www.okdrama.com/wp-content/uploads/2021/07/The-Tomorrow-War.jpg", new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Tomorrow War", 1 },
                    { 8, "Miami detectives Mike Lowrey and Marcus Burnett must face off against a mother-and-son pair of drug lords who wreak vengeful havoc on their city.", "https://th.bing.com/th/id/OIP.Ox-F7hWGAUkWLucz4B7ggwHaLH?pid=ImgDet&rs=1", new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bad Boys For Life", 1 },
                    { 7, "Two hip detectives protect a witness to a murder while investigating a case of stolen heroin from the evidence storage room from their police precinct.", "https://th.bing.com/th/id/OIP.M5Y738m_1kCMg-Fef-fI2gHaLH?pid=ImgDet&rs=1", new DateTime(2003, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bad Boys II", 1 },
                    { 21, "A commercial airliner suddenly reappears after being missing for five years. As those aboard reintegrate into society, they experience guiding voices and visions of events yet to occur, and soon a deeper mystery unfolds.", "https://image.tmdb.org/t/p/original/moaCMoZYVifaQnNJGDr3M6rBglB.jpg", new DateTime(2018, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manifest", 2 },
                    { 6, "Two loose-cannon narcotics cops investigate the flow of Ecstasy into Florida from a Cuban drug cartel.", "https://i.pinimg.com/736x/f8/a5/5d/f8a55dd993b59363dcf4b6e410305f44--hd-movies-action-movies.jpg", new DateTime(1995, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bad Boys", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "VideoId" },
                values: new object[,]
                {
                    { 11, 8, 6 },
                    { 30, 9, 15 },
                    { 31, 4, 16 },
                    { 32, 6, 16 },
                    { 33, 5, 17 },
                    { 34, 7, 17 },
                    { 35, 8, 18 },
                    { 37, 7, 19 },
                    { 38, 5, 19 },
                    { 39, 7, 20 },
                    { 40, 8, 20 },
                    { 41, 8, 21 },
                    { 42, 6, 21 },
                    { 43, 9, 22 },
                    { 44, 6, 22 },
                    { 29, 5, 15 },
                    { 45, 8, 23 },
                    { 47, 10, 24 },
                    { 48, 9, 24 },
                    { 49, 10, 25 },
                    { 50, 10, 25 },
                    { 51, 6, 26 },
                    { 52, 8, 26 },
                    { 53, 3, 27 },
                    { 54, 4, 27 },
                    { 55, 7, 28 },
                    { 56, 8, 28 },
                    { 57, 9, 29 },
                    { 58, 8, 29 },
                    { 59, 5, 30 },
                    { 60, 6, 30 },
                    { 46, 7, 23 },
                    { 28, 10, 14 },
                    { 36, 8, 18 },
                    { 23, 9, 12 },
                    { 22, 10, 11 },
                    { 15, 8, 8 },
                    { 21, 4, 11 },
                    { 24, 4, 12 },
                    { 17, 6, 9 },
                    { 14, 5, 7 },
                    { 13, 9, 7 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "VideoId" },
                values: new object[,]
                {
                    { 16, 5, 8 },
                    { 26, 4, 13 },
                    { 20, 3, 10 },
                    { 27, 8, 14 },
                    { 18, 3, 9 },
                    { 19, 4, 10 },
                    { 12, 5, 6 },
                    { 25, 3, 13 }
                });

            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[,]
                {
                    { 47, "Jennifer Aniston", 24 },
                    { 15, "Will Smith", 8 },
                    { 16, "Martin Lawrence", 8 },
                    { 49, "Dominic Purcell", 25 },
                    { 50, "Wentworth Miller", 25 },
                    { 48, "Courteney Cox", 24 },
                    { 27, "Chris Pratt", 14 },
                    { 52, "Kristen Vangsness", 26 },
                    { 17, "Chris Pratt", 9 },
                    { 14, "Martin Lawrence", 7 },
                    { 53, "Shabana Azmi", 27 },
                    { 54, "Kunal Kapoor", 27 },
                    { 13, "Will Smith", 7 },
                    { 55, "James Spader", 28 },
                    { 56, "Megane Boone", 28 },
                    { 12, "Martin Lawrence", 6 },
                    { 57, "Hugh Lauri", 29 },
                    { 58, "Omar Epps", 29 },
                    { 11, "Will Smith", 6 },
                    { 51, "Matthew Gray Gubler", 26 },
                    { 46, "Aaron Paul", 23 },
                    { 43, "Andy Samberg", 22 },
                    { 18, "Yvonne Strahovski", 9 },
                    { 28, "Bryce Dallas Howard", 14 },
                    { 26, "Bryce Dallas Howard", 13 },
                    { 25, "Chris Pratt", 13 },
                    { 29, "Tobey Maguire", 15 },
                    { 30, "Kristen Dunst", 15 },
                    { 31, "Zoe Kazan", 16 },
                    { 32, "Betty Gabriel", 16 },
                    { 24, "William H. Macy", 12 },
                    { 23, "Sam Neill", 12 },
                    { 33, "Ursula Cobero", 17 },
                    { 34, "Alvaro Morte", 17 }
                });

            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[,]
                {
                    { 59, "Taylor Kitsch", 30 },
                    { 35, "Nicole Kidman", 18 },
                    { 36, "Melissa McCarthy", 18 },
                    { 22, "Julianne Moore", 11 },
                    { 37, "Andrew Lincoln", 19 },
                    { 38, "Norman Reedus", 19 },
                    { 21, "Jeff Goldblum", 11 },
                    { 39, "Emilia Clarke", 20 },
                    { 40, "Peter Dinklage", 20 },
                    { 20, "Laura Dern", 10 },
                    { 41, "Melissa Roxburgh", 21 },
                    { 42, "Josh Dallas", 21 },
                    { 19, "Sam Neill", 10 },
                    { 44, "Stephanie Beatriz", 22 },
                    { 45, "Bryan Cranston", 23 },
                    { 60, "Michael C. Hall", 30 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Score",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "Score",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                column: "Score",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                column: "Score",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                column: "Score",
                value: 5);

            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Tom Hanks");

            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Robin Wright");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[] { "Forrest Gump is a 1994 American drama film directed by Robert Zemeckis and written by Eric Roth with comedic aspects. It is based on the 1986 novel of the same name by Winston Groom and stars Tom Hanks, Robin Wright, Gary Sinise, Mykelti Williamson and Sally Field.", "https://cinecalidad.in/wp-content/uploads/2020/03/forrest-gump-7240-poster-683x1024.jpg", new DateTime(1994, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump", 2 });
        }
    }
}
