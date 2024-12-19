using MyRow = Movie.Administration.RoleRow;
using MyRequest = Serenity.Services.SaveRequest<Movie.Administration.RoleRow>;
using MyResponse = Serenity.Services.SaveResponse;

namespace Movie.Administration;

public interface IRoleSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse>
{
}

public class RoleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
{
    public RoleSaveHandler(IRequestContext context)
        : base(context)
    {
    }

    protected override void InvalidateCacheOnCommit()
    {
        base.InvalidateCacheOnCommit();

        Cache.InvalidateOnCommit(UnitOfWork, UserPermissionRow.Fields);
        Cache.InvalidateOnCommit(UnitOfWork, RolePermissionRow.Fields);
    }
}