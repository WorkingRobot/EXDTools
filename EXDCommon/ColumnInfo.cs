﻿using EXDCommon.SchemaModel.EXDSchema;
using Lumina.Data.Structs.Excel;
using SchemaConverter;

namespace EXDCommon;

public class ColumnInfo
{
	public int BitOffset { get; set; }
	public string Name { get; set; }
	public int Index;
	public string? Type { get; set; } // icon, color etc
	public ExcelColumnDataType DataType { get; set; }
	public bool IsArrayMember { get; set; }
	public int? ArrayIndex { get; set; }
	public Condition? Condition { get; set; }
	public List<string>? Targets { get; set; }
	
	public ColumnInfo() { }

	public ColumnInfo(SchemaModel.SaintCoinach.Definition def, int index, bool isArrayMember, int? arrayIndex, Condition? condition, List<string>? targets)
	{
		var converterType = def.Converter?.Type;
		var nameSuffix = isArrayMember ? $"[{arrayIndex}]" : "";
		Name = Util.StripDefinitionName(def.Name);// + nameSuffix;
		Index = index;
		Type = converterType;
		IsArrayMember = isArrayMember;
		ArrayIndex = arrayIndex;
		Condition = condition;
		Targets = targets;
	}
	
	public override string ToString() => $"{Name} ({Index}@{BitOffset / 8}&{BitOffset % 8}) {Type} {IsArrayMember} {ArrayIndex}";
}