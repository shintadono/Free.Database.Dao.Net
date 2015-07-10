using System;

namespace Free.Database.Dao.Net
{
	public class Connection
	{
		internal DAO.Connection con;

		public Connection(DAO.Connection _con)
		{
			con=_con;
		}

		public void Cancel()
		{
			con.Cancel();
		}

		public void Close()
		{
			con.Close();
		}

		public QueryDef CreateQueryDef()
		{
			return new QueryDef(con.CreateQueryDef(Type.Missing, Type.Missing));
		}

		public QueryDef CreateQueryDef(string name)
		{
			return new QueryDef(con.CreateQueryDef(name, Type.Missing));
		}

		public QueryDef CreateQueryDef(string name, string sqltext)
		{
			return new QueryDef(con.CreateQueryDef(name, sqltext));
		}

		public void Execute(string source)
		{
			con.Execute(source, Type.Missing);
		}

		public void Execute(string source, RecordsetOption options)
		{
			con.Execute(source, options);
		}

		public Recordset OpenRecordset(string source)
		{
			return new Recordset(con.OpenRecordset(source, Type.Missing, Type.Missing, Type.Missing));
		}
		
		public Recordset OpenRecordset(string source, RecordsetType type)
		{
			return new Recordset(con.OpenRecordset(source, type, Type.Missing, Type.Missing));
		}
		
		public Recordset OpenRecordset(string source, RecordsetType type, RecordsetOption options)
		{
			return new Recordset(con.OpenRecordset(source, type, options, Type.Missing));
		}
		
		public Recordset OpenRecordset(string source, RecordsetType type, RecordsetOption options, LockType lockedits)
		{
			return new Recordset(con.OpenRecordset(source, type, options, lockedits));
		}

		public string Connect
		{
			get { return con.Connect; }
		}

		public Database Database
		{
			get { return new Database(con.Database); }
		}

		public int hDbc
		{
			get { return con.hDbc; }
		}

		public string Name
		{
			get { return con.Name; }
		}

		public QueryDefs QueryDefs
		{
			get { return new QueryDefs(con.QueryDefs); }
		}

		public short QueryTimeout
		{
			get { return con.QueryTimeout; }
			set { con.QueryTimeout=value; }
		}

		public int RecordsAffected
		{
			get { return con.RecordsAffected; }
		}

		public Recordsets Recordsets
		{
			get { return new Recordsets(con.Recordsets); }
		}

		public bool StillExecuting
		{
			get { return con.StillExecuting; }
		}

		public bool Transactions
		{
			get { return con.Transactions; }
		}

		public bool Updatable
		{
			get { return con.Updatable; }
		}
	}

	class ConnectionsEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public ConnectionsEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get { return new Connection((DAO.Connection)Enmtr.Current); } }
	}

	public class Connections
	{
		internal DAO.Connections cons;

		public Connections(DAO.Connections _cons)
		{
			cons=_cons;
		}

		public short Count
		{
			get { return cons.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new ConnectionsEnumerator(cons.GetEnumerator());
		}
		
		public void Refresh()
		{
			cons.Refresh();
		}

		public Connection this[string index]
		{
			get { return new Connection(cons[index]); }
		}

		public Connection this[int index]
		{
			get { return new Connection(cons[index]); }
		}
	}
}
