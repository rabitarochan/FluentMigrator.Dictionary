using System.Data;
using FluentMigrator.Builders;

namespace FluentMigrator.Dictionary
{
    public class TemporaryColumnDefinition : IColumnTypeSyntax<TemporaryColumnDefinition>
    {
        public string Name { get; private set; }
        public DbType? Type { get; private set; }
        public string CustomType { get; private set; }
        public int Size { get; private set; }
        public int Precision { get; private set; }

        public TemporaryColumnDefinition(string name)
        {
            this.Name = name;
        }

        public TemporaryColumnDefinition Copy(string name = null, DbType? type = null, string customType = null, int size = -1, int precision = -1)
        {
            var newName = (!string.IsNullOrEmpty(name)) ? name : this.Name;

            var newColumn = new TemporaryColumnDefinition(newName) {
                Type = type ?? this.Type,
                CustomType = customType ?? this.CustomType,
                Size = (size != -1) ? size : this.Size,
                Precision = (precision != -1) ? precision : this.Precision
            };

            return newColumn;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsAnsiString()
        {
            this.Type = DbType.AnsiString;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsAnsiString(int size)
        {
            this.Type = DbType.AnsiString;
            this.Size = size;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsBinary()
        {
            this.Type = DbType.Binary;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsBinary(int size)
        {
            this.Type = DbType.Binary;
            this.Size = size;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsBoolean()
        {
            this.Type = DbType.Boolean;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsByte()
        {
            this.Type = DbType.Byte;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsCurrency()
        {
            this.Type = DbType.Currency;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsDate()
        {
            this.Type = DbType.Date;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsDateTime()
        {
            this.Type = DbType.DateTime;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsDecimal()
        {
            this.Type = DbType.Decimal;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsDecimal(int size, int precision)
        {
            this.Type = DbType.Decimal;
            this.Size = size;
            this.Precision = precision;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsDouble()
        {
            this.Type = DbType.Double;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsGuid()
        {
            this.Type = DbType.Guid;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsFixedLengthString(int size)
        {
            this.Type = DbType.StringFixedLength;
            this.Size = size;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsFixedLengthAnsiString(int size)
        {
            this.Type = DbType.AnsiStringFixedLength;
            this.Size = size;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsFloat()
        {
            this.Type = DbType.Single;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsInt16()
        {
            this.Type = DbType.Int16;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsInt32()
        {
            this.Type = DbType.Int32;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsInt64()
        {
            this.Type = DbType.Int64;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsString()
        {
            this.Type = DbType.String;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsString(int size)
        {
            this.Type = DbType.String;
            this.Size = size;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsTime()
        {
            this.Type = DbType.Time;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsXml()
        {
            this.Type = DbType.Xml;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsXml(int size)
        {
            this.Type = DbType.Xml;
            this.Size = size;
            return this;
        }

        TemporaryColumnDefinition IColumnTypeSyntax<TemporaryColumnDefinition>.AsCustom(string customType)
        {
            this.Type = null;
            this.CustomType = customType;
            return this;
        }
    }
}
