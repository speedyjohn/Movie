using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Movie.MovieDB.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Movie.MovieDB.MovieRow;

namespace Movie.MovieDB;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    public MovieSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}