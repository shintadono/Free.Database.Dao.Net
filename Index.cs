using System;

namespace Free.Database.Dao.Net
{
	public class Index
	{
		internal DAO.Index ind;

		public Index(DAO.Index _ind)
		{
			ind=_ind; 
		}

		public Field CreateField()
		{
			return new Field(ind.CreateField(Type.Missing, Type.Missing, Type.Missing));
		}
		
		public Field CreateField(string name)
		{
			return new Field(ind.CreateField(name, Type.Missing, Type.Missing)); 
		}

		public Field CreateField(string name, DataType type)
		{
			return new Field(ind.CreateField(name, type, Type.Missing)); 
		}

		public Field CreateField(string name, DataType type, int size)
		{
			return new Field(ind.CreateField(name, type, size)); 
		}

		public Property CreateProperty()
		{
			return new Property(ind.CreateProperty(System.Type.Missing, System.Type.Missing,
				System.Type.Missing, System.Type.Missing));
		}

		public Property CreateProperty(string name)
		{
			return new Property(ind.CreateProperty(name, System.Type.Missing,
				System.Type.Missing, System.Type.Missing));
		}

		public Property CreateProperty(string name, DataType type)
		{
			return new Property(ind.CreateProperty(name, type,
				System.Type.Missing, System.Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val)
		{
			return new Property(ind.CreateProperty(name, type, val, System.Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val, bool ddl)
		{
			return new Property(ind.CreateProperty(name, type, val, ddl));
		}

		public bool Clustered
		{
			get { return ind.Clustered; }
			set { ind.Clustered=value; }
		}

		public int DistinctCount
		{
			get { return ind.DistinctCount; }
		}

		public IndexFields Fields
		{
			get{ return new IndexFields((DAO.IndexFields)ind.Fields); }
			set{ ind.Fields=value.flds; }
		}

		public bool Foreign
		{
			get { return ind.Foreign; }
		}
		
		public bool IgnoreNulls
		{
			get { return ind.IgnoreNulls; }
			set { ind.IgnoreNulls=value; }
		}

		public string Name
		{
			get { return ind.Name; }
			set { ind.Name=value; }
		}
		
		public bool Primary
		{
			get { return ind.Primary; }
			set { ind.Primary=value; }
		}

		public Properties Properties
		{
			get{ return new Properties(ind.Properties); }
		}

		public bool Required
		{
			get { return ind.Required; }
			set { ind.Required=value; }
		}
		
		public bool Unique
		{
			get { return ind.Unique; }
			set { ind.Unique=value; }
		}
	}

	class IndexesEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public IndexesEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Index((DAO.Index)Enmtr.Current); } }
	}

	public class Indexes
	{
		internal DAO.Indexes inds;

		public Indexes(DAO.Indexes _inds)
		{
			inds=_inds;
		}

		short Count
		{
			get{ return inds.Count; }
		}
		
		public System.Collections.IEnumerator GetEnumerator()
		{
			return new IndexesEnumerator(inds.GetEnumerator());
		}

		public void Refresh()
		{
			inds.Refresh();
		}
		
		public void Append(Index ind)
		{
			inds.Append(ind.ind);
		}
		
		public void Delete(string name)
		{
			inds.Delete(name);
		}
		
		public Index this[string index]
		{
			get{ return new Index(inds[index]); }
		}

		public Index this[int index]
		{
			get{ return new Index(inds[index]); }
		}
	}
}
