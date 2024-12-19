using MyRow = Movie.Administration.UserRow;
using MyRequest = Movie.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<Movie.Administration.UserRow>;

namespace Movie.Administration;

public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse>
{
}

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
        : base(context)
    {
    }
}