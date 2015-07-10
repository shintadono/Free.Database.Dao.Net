using System;

namespace Free.Database.Dao.Net
{
	public class Field
	{
		internal DAO.Field fld;

		public Field(DAO.Field _fld)
		{
			fld=_fld; 
		}

		[Obsolete("Use FieldSize instead.", false)]
		public int _30_FieldSize()
		{
			return fld._30_FieldSize();
		}

		public void AppendChunk(string chunk)
		{
			fld.AppendChunk(chunk);
		}

		public Property CreateProperty()
		{
			return new Property(fld.CreateProperty(System.Type.Missing, System.Type.Missing,
				System.Type.Missing, System.Type.Missing));
		}

		public Property CreateProperty(string name)
		{
			return new Property(fld.CreateProperty(name, System.Type.Missing,
				System.Type.Missing, System.Type.Missing));
		}

		public Property CreateProperty(string name, DataType type)
		{
			return new Property(fld.CreateProperty(name, type,
				System.Type.Missing, System.Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val)
		{
			return new Property(fld.CreateProperty(name, type, val, System.Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val, bool ddl)
		{
			return new Property(fld.CreateProperty(name, type, val, ddl));
		}

		public string GetChunk(int offset, int count)
		{
			return (string)fld.GetChunk(offset, count);
		}

		public bool AllowZeroLength
		{ 
			get { return fld.AllowZeroLength; }
			set { fld.AllowZeroLength=value; }
		}

		public FieldAttribute Attributes
		{
			get { return (FieldAttribute)fld.Attributes; }
			set { fld.Attributes=(int)value; }
		}

		public CollatingOrder CollatingOrder
		{
			get { return (CollatingOrder)fld.CollatingOrder; }
		}

		public short CollectionIndex
		{
			get { return fld.CollectionIndex; }
		}

		public bool DataUpdatable
		{ 
			get { return fld.DataUpdatable; }
		}

		public object DefaultValue
		{
			get { return fld.DefaultValue; }
			set { fld.DefaultValue=value; }
		}

		public int FieldSize
		{
			get { return fld.FieldSize; }
		}

		public string ForeignName
		{
			get { return fld.ForeignName; }
			set { fld.ForeignName=value; }
		}

		public string Name
		{
			get { return fld.Name; }
			set { fld.Name=value; }
		}

		public short OrdinalPosition
		{
			get { return fld.OrdinalPosition; }
			set { fld.OrdinalPosition=value; }
		}

		public object OriginalValue
		{
			get { return fld.OriginalValue; }
		}

		public Properties Properties
		{ 
			get{ return new Properties(fld.Properties); }
		}

		public bool Required
		{ 
			get { return fld.Required; }
			set { fld.Required=value; }
		}

		public int Size
		{ 
			get { return fld.Size; }
			set { fld.Size=value; }
		}

		public string SourceField
		{
			get { return fld.SourceField; }
		}

		public string SourceTable
		{
			get { return fld.SourceTable; }
		}

		public DataType Type
		{
			get { return (DataType)fld.Type; }
		}

		public bool ValidateOnSet
		{
			get { return fld.ValidateOnSet; }
			set { fld.ValidateOnSet=value; }
		}

		public string ValidationRule
		{
			get { return fld.ValidationRule; }
			set { fld.ValidationRule=value; }
		}

		public string ValidationText
		{
			get { return fld.ValidationText; }
			set { fld.ValidationText=value; }
		}

		public object Value
		{
			get { return fld.Value; }
			set { fld.Value=value; }
		}

		public object VisibleValue
		{
			get { return fld.VisibleValue; }
		}
	}

	class FieldsEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public FieldsEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Field((DAO.Field)Enmtr.Current); } }
	}

	public class Fields
	{
		internal DAO.Fields flds;

		public Fields(DAO.Fields _flds)
		{
			flds=_flds; 
		}
		
		short Count 
		{
			get{ return flds.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new FieldsEnumerator(flds.GetEnumerator());
		}

		public void Refresh()
		{
			flds.Refresh(); 
		}
		
		public void Append(Field fld)
		{
			flds.Append(fld.fld); 
		}
		
		public void Delete(string name)
		{
			flds.Delete(name); 
		}
		
		public Field this[string index]
		{
			get{ return new Field(flds[index]); }
		}

		public Field this[int index]
		{
			get{ return new Field(flds[index]); }
		}
	}

	public class IndexFields
	{
		internal DAO.IndexFields flds;

		public IndexFields(DAO.IndexFields _flds)
		{
			flds=_flds; 
		}
		
		short Count 
		{
			get{ return flds.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new FieldsEnumerator(flds.GetEnumerator());
		}

		public void Refresh()
		{
			flds.Refresh(); 
		}
		
		public void Append(Field fld)
		{
			flds.Append(fld.fld); 
		}
		
		public void Delete(string name)
		{
			flds.Delete(name); 
		}
		
		public Field this[string index]
		{
			get{ return new Field((DAO.Field)flds[index]); }
		}

		public Field this[int index]
		{
			get{ return new Field((DAO.Field)flds[index]); }
		}
	}
}
