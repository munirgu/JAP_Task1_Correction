# JAP_Task1_Correction
This is Movie Application or rating engine, similar to the one on imdb.com, but much, much simpler and more rudimentary. Each movie has a title, a cover image, a description, release date, and cast. Also, every movie can be rated by other users by 1-5 stars. Search can be performed by title, description and rating.

This is an extended version of the previous task. Here you can find buy ticket feature as well as three new endpoints: first one is get 10 movies with the most ratings, ordered by rating descending, second one Get 10 movies with the most screenings ordered by descending, for the period passed as parameter and third one Get movies with the most sold tickets that don’t have ratings, grouped by screening Also you can find testing of these methods in JAP_Task2.Test folder.

In order to run this you should do the following:

First clone JAP_Task2_Backend repository Make sure you change the name of the database in appsettings.json and changing the ConnectionStrings' DefaultConnection value. make sure SQL server is active and that you have database called "MovieApp2". In your Visual Studio run dotnet ef database update Before you start playing with this application first you should insert the data for the screenings on the Swagger. For the first time this should be done because there is a method which is adding screenings once it is called. In order to run the tests you should have installed NUnit3TestAdapter, NUnit, Moq, Microsoft.NET.Test.Sdk and Microsoft.EntityFrameworkCore.InMemory.
