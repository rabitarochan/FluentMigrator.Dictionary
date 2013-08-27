using FluentMigrator.Builders;

namespace FluentMigrator.Dictionary
{
    public class ColumnDictionaryBase
    {
        protected static IColumnTypeSyntax<TemporaryColumnDefinition> NewColumn(string name)
        {
            var column = new TemporaryColumnDefinition(name);
            return column;
        }
    }
}
