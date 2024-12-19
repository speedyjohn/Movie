﻿using MyRow = Movie.Administration.LanguageRow;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;


namespace Movie.Administration;

public interface ILanguageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse>
{
}

public class LanguageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageDeleteHandler
{
    public LanguageDeleteHandler(IRequestContext context)
        : base(context)
    {
    }
}