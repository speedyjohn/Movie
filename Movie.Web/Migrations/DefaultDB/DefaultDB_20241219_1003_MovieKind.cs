using FluentMigrator;

namespace Movie.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20241219_1003)]
public class DefaultDB_20241219_1003_MovieTable : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Movie")
            .AddColumn("Kind").AsInt32().NotNullable().WithDefaultValue(1);
    }
}