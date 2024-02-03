﻿namespace Core.Schemas;
public class TableSchema
{
    public string TableName { get; set; } = null!;
    public List<ColumnSchema> Columns { get; set; } = new();
}