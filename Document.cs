using System;

namespace Free.Database.Dao.Net
{
	public class Document
	{
		internal DAO.Document doc;

		public Document(DAO.Document _doc)
		{
			doc=_doc;
		}

		public Property CreateProperty()
		{
			return new Property(doc.CreateProperty(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
		}

		public Property CreateProperty(string name)
		{
			return new Property(doc.CreateProperty(name, Type.Missing, Type.Missing, Type.Missing));
		}

		public Property CreateProperty(string name, DataType type)
		{
			return new Property(doc.CreateProperty(name, type, Type.Missing, Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val)
		{
			return new Property(doc.CreateProperty(name, type, val, Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val, bool ddl)
		{
			return new Property(doc.CreateProperty(name, type, val, ddl));
		}

		public Permission AllPermissions
		{
			get { return (Permission)doc.AllPermissions; }
		}

		public string Container
		{
			get { return doc.Container; }
		}

		public DateTime DateCreated
		{
			get { return (DateTime)doc.DateCreated; }
		}

		public DateTime LastUpdated
		{
			get { return (DateTime)doc.LastUpdated; }
		}

		public string Name
		{
			get { return doc.Name; }
		}

		public string Owner
		{
			get { return doc.Owner; }
			set { doc.Owner=value; }
		}

		public Permission Permissions
		{
			get { return (Permission)doc.Permissions; }
			set { doc.Permissions=(int)value; }
		}

		public Properties Properties
		{
			get { return new Properties(doc.Properties); }
		}

		public string UserName
		{
			get { return doc.UserName; }
			set { doc.UserName=value; }
		}
	}

	class DocumentsEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public DocumentsEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new Document((DAO.Document)Enmtr.Current); } }
	}

	public class Documents
	{
		internal DAO.Documents docs;

		public Documents(DAO.Documents _docs)
		{
			docs=_docs;
		}

		public short Count
		{
			get { return docs.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new DocumentsEnumerator(docs.GetEnumerator());
		}

		public void Refresh()
		{
			docs.Refresh();
		}

		public Document this[string index] 
		{
			get { return new Document(docs[index]); }
		}

		public Document this[int index] 
		{
			get { return new Document(docs[index]); }
		}
	}
}
