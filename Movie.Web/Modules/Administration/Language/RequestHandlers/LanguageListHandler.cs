using MyRow = Movie.Administration.LanguageRow;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Movie.Administration.LanguageRow>;


namespace Movie.Administration;

public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse>
{
}

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
        : base(context)
    {
    }
}