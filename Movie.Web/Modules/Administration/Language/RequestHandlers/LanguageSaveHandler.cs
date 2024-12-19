﻿using MyRow = Movie.Administration.LanguageRow;
using MyRequest = Serenity.Services.SaveRequest<Movie.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;


namespace Movie.Administration;

public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse>
{
}

public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
        : base(context)
    {
    }
}