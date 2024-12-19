﻿namespace Movie.Modules.MovieDB.Movie;

[EnumKey("MovieDB.MovieKind")]
public enum MovieKind
{
    [Description("Film")]
    Film = 1,
    [Description("TV Series")]
    TvSeries = 2,
    [Description("MiniSeries")]
    MiniSeries = 3,
}