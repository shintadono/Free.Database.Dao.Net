using System;

namespace Free.Database.Dao.Net
{
	public class TableDef
	{
		internal DAO.TableDef td;

		public TableDef(DAO.TableDef _td)
		{
			td=_td;
		}

		public Field CreateField()
		{
			return new Field(td.CreateField(Type.Missing, Type.Missing, Type.Missing));
		}
		
		public Field CreateField(string name)
		{
			return new Field(td.CreateField(name, Type.Missing, Type.Missing));
		}
		
		public Field CreateField(string name, DataType type)
		{
			return new Field(td.CreateField(name, type, Type.Missing));
		}
		
		public Field CreateField(string name, DataType type, int size)
		{
			return new Field(td.CreateField(name, type, size));
		}

		public Index CreateIndex()
		{
			return new Index(td.CreateIndex(Type.Missing));
		}

		public Index CreateIndex(string name)
		{
			return new Index(td.CreateIndex(name));
		}

		public Property CreateProperty()
		{
			return new Property(td.CreateProperty(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
		}

		public Property CreateProperty(string name)
		{
			return new Property(td.CreateProperty(name, Type.Missing, Type.Missing, Type.Missing));
		}

		public Property CreateProperty(string name, DataType type)
		{
			return new Property(td.CreateProperty(name, type, Type.Missing, Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val)
		{
			return new Property(td.CreateProperty(name, type, val, Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val, bool ddl)
		{
			return new Property(td.CreateProperty(name, type, val, ddl));
		}

		public Recordset OpenRecordset()
		{
			return new Recordset(td.OpenRecordset(Type.Missing, Type.Missing));
		}

		public Recordset OpenRecordset(RecordsetType type)
		{
			return new Recordset(td.OpenRecordset(type, Type.Missing));
		}
		
		public Recordset OpenRecordset(RecordsetType type, RecordsetOption options)
		{
			return new Recordset(td.OpenRecordset(type, options));
		}

		public void RefreshLink()
		{
			td.RefreshLink();
		}

		public TableDefAttribute Attributes
		{
			get { return (TableDefAttribute)td.Attributes; }
			set { td.Attributes=(int)value; }
		}

		public string ConflictTable
		{
			get { return td.ConflictTable; }
		}

		public string Connect
		{
			get { return td.Connect; }
			set { td.Connect=value; }
		}

		public DateTime DateCreated
		{
			get { return (DateTime)td.DateCreated; }
		}

		public Fields Fields
		{
			get { return new Fields(td.Fields); }
		}

		public Indexes Indexes
		{
			get { return new Indexes(td.Indexes); }
		}

		public DateTime LastUpdated
		{
			get { return (DateTime)td.LastUpdated; }
		}

		public string Name
		{
			get { return td.Name; }
			set { td.Name=value; }
		}

		public Properties Properties
		{
			get { return new Properties(td.Properties); }
		}

		public int RecordCount
		{
			get { return td.RecordCount; }
		}
		
		// returns and value ^= string | bool
		public object ReplicaFilter
		{
			get { return td.ReplicaFilter; }
			set { td.ReplicaFilter=value; }
		}

		public string SourceTableName
		{
			get { return td.SourceTableName; }
			set { td.SourceTableName=value; }
		}

		public bool Updatable
		{
			get { return td.Updatable; }
		}

		public string ValidationRule
		{
			get { return td.ValidationRule; }
			set { td.ValidationRule=value; }
		}

		public string ValidationText
		{
			get { return td.ValidationText; }
			set { td.ValidationText=value; }
		}
	}

	class TableDefsEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public TableDefsEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new TableDef((DAO.TableDef)Enmtr.Current); } }
	}

	public class TableDefs : System.Collections.IEnumerable
	{
		internal DAO.TableDefs tds;

		public TableDefs(DAO.TableDefs _tds)
		{
			tds=_tds;
		}

		public short Count
		{
			get { return tds.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new TableDefsEnumerator(tds.GetEnumerator());
		}

		public void Refresh()
		{
			tds.Refresh();
		}

		public void Append(TableDef td)
		{
			tds.Append(td.td);
		}

		public void Delete(string name)
		{
			tds.Delete(name);
		}

		public TableDef this[string index] 
		{
			get { return new TableDef(tds[index]); }
		}

		public TableDef this[int index] 
		{
			get { return new TableDef(tds[index]); }
		}
	}
}
