using Movie.Administration;

namespace Movie.AppServices;

public class PermissionKeyLister(ITwoLevelCache cache, ITypeSource typeSource)
    : BasePermissionKeyLister(cache, typeSource)
{
    protected override string GetCacheGroupKey()
    {
        return RoleRow.Fields.GenerationKey;
    }
}