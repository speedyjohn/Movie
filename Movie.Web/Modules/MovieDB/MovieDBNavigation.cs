using DocumentFormat.OpenXml.Drawing;
using Serenity.Navigation;
using MyPages = Movie.MovieDB.Pages;

[assembly: NavigationMenu(int.MaxValue, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(int.MaxValue, "Movie Database/Movies",
    typeof(MyPages.MoviePage), icon: "fa-video-camera")]
[assembly: NavigationLink(int.MaxValue, "Movie Database/Genres",
    typeof(MyPages.GenrePage), icon: "fa-thumb-tack")]