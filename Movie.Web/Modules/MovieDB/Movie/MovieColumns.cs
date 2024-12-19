using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using Movie.Modules.MovieDB.Movie;
using MovieTutorial;

namespace Movie.MovieDB.Columns;

[ColumnsScript("MovieDB.Movie")]
[BasedOnRow(typeof(MovieRow), CheckNames = true)]
public class MovieColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int MovieId { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Description { get; set; }
    public string Storyline { get; set; }
    public int Year { get; set; }
    public DateTime ReleaseDate { get; set; }
    [DisplayName("Runtime(minutes)"), AlignRight, Width(150)]
    public int Runtime { get; set; }
    public MovieKind Kind { get; set; }
    [Width(200), GenreListFormatter, QuickFilter]
    public List<int> GenreList { get; set; }
}