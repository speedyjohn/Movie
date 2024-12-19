using FluentMigrator;

namespace Movie.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20241219_1024)]
public class DefaultDB_20241219_1024_MovieTable : ForwardOnlyMigration
{
    public override void Up()
    {
        Create.Table("MovieGenres")
            .WithColumn("MovieGenreId").AsInt32()
            .Identity().PrimaryKey().NotNullable()
            .WithColumn("MovieId").AsInt32().NotNullable()
            .ForeignKey("FK_MovieGenres_MovieId", "Movie", "MovieId")
            .WithColumn("GenreId").AsInt32().NotNullable()
            .ForeignKey("FK_MovieGenres_GenreId", "Genre", "GenreId");

        Execute.Sql(
            @"INSERT INTO MovieGenres (MovieId, GenreId)
                SELECT m.MovieId, m.GenreId
                FROM Movie m
                WHERE m.GenreId IS NOT NULL");

        Delete.ForeignKey("FK_Movie_GenreId")
            .OnTable("Movie");
        Delete.Column("GenreId")
            .FromTable("Movie");
    }
}