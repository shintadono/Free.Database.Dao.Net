using System;

namespace Free.Database.Dao.Net
{
	public class Relation
	{
		internal DAO.Relation rel;

		public Relation(DAO.Relation _rel)
		{
			rel=_rel;
		}

		public Field CreateField()
		{
			return new Field(rel.CreateField(Type.Missing, Type.Missing, Type.Missing));
		}
		
		public Field CreateField(string name)
		{
			return new Field(rel.CreateField(name, Type.Missing, Type.Missing));
		}
		
		public Field CreateField(string name, DataType type)
		{
			return new Field(rel.CreateField(name, type, Type.Missing));
		}
		
		public Field CreateField(string name, DataType type, int size)
		{
			return new Field(rel.CreateField(name, type, size));
		}

		public RelationAttribute Attributes
		{
			get { return (RelationAttribute)rel.Attributes; }
			set { rel.Attributes=(int)value; }
		}

		public Fields Fields
		{
			get { return new Fields(rel.Fields); }
		}

		public string ForeignTable
		{
			get { return rel.ForeignTable; }
			set { rel.ForeignTable=value; }
		}

		public string Name
		{
			get { return rel.Name; }
			set { rel.Name=value; }
		}

		public bool PartialReplica
		{
			get { return rel.PartialReplica; }
			set { rel.PartialReplica=value; }
		}

		public Properties Properties
		{
			get { return new Properties(rel.Properties); }
		}

		public string Table
		{
			get { return rel.Table; }
			set { rel.Table=value; }
		}
	}

	class RelationsEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public RelationsEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Relation((DAO.Relation)Enmtr.Current); } }
	}

	public class Relations : System.Collections.IEnumerable
	{
		internal DAO.Relations rels;

		public Relations(DAO.Relations _rels)
		{
			rels=_rels;
		}

		public short Count
		{
			get { return rels.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new RelationsEnumerator(rels.GetEnumerator());
		}

		public void Refresh()
		{
			rels.Refresh();
		}

		public void Append(Relation rel)
		{
			rels.Append(rel.rel);
		}

		public void Delete(string name)
		{
			rels.Delete(name);
		}

		public Relation this[string index] 
		{
			get { return new Relation(rels[index]); }
		}

		public Relation this[int index] 
		{
			get { return new Relation(rels[index]); }
		}
	}
}
