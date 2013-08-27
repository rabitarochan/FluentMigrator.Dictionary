using FluentMigrator.Dictionary;

namespace FluentMigrator
{
    public static class MigrationEx
    {
        // create table
        public static Builders.Create.Table.ICreateTableColumnOptionOrWithColumnSyntax WithColumn(this Builders.Create.Table.ICreateTableWithColumnSyntax self, TemporaryColumnDefinition column)
        {
            var builder = (Builders.Create.Table.CreateTableExpressionBuilder) self.WithColumn(column.Name).AsInt32();
            builder.CurrentColumn.Type = column.Type;
            builder.CurrentColumn.CustomType = column.CustomType;
            builder.CurrentColumn.Size = column.Size;
            builder.CurrentColumn.Precision = column.Precision;
            return builder;
        }

        // create column
        public static Builders.Create.Column.ICreateColumnOptionSyntax ColumnOnTable(this Builders.Create.ICreateExpressionRoot self, TemporaryColumnDefinition column, string tableName)
        {
            var builder = (Builders.Create.Column.CreateColumnExpressionBuilder) self.Column(column.Name).OnTable(tableName);
            builder.Expression.Column.Type = column.Type;
            builder.Expression.Column.CustomType = column.CustomType;
            builder.Expression.Column.Size = column.Size;
            builder.Expression.Column.Precision = column.Precision;
            return builder;
        }
    }
}
