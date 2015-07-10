using System;

namespace Free.Database.Dao.Net
{
	public class QueryDef
	{
		internal DAO.QueryDef qd;
	
		public QueryDef(DAO.QueryDef _qd)
		{
			qd=_qd;
		}

		[Obsolete("Use _OpenRecordset instead.", false)]
		public Recordset _30__OpenRecordset()
		{
			return new Recordset(qd._30__OpenRecordset(System.Type.Missing, System.Type.Missing));
		}

		[Obsolete("Use _OpenRecordset instead.", false)]
		public Recordset _30__OpenRecordset(RecordsetType type)
		{
			return new Recordset(qd._30__OpenRecordset(type, System.Type.Missing));
		}

		[Obsolete("Use _OpenRecordset instead.", false)]
		public Recordset _30__OpenRecordset(RecordsetType type, RecordsetOption options)
		{
			return new Recordset(qd._30__OpenRecordset(type, options));
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset _30_OpenRecordset()
		{
			return new Recordset(qd._30_OpenRecordset(System.Type.Missing, System.Type.Missing));
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset _30_OpenRecordset(RecordsetType type)
		{
			return new Recordset(qd._30_OpenRecordset(type, System.Type.Missing));
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset _30_OpenRecordset(RecordsetType type, RecordsetOption options)
		{
			return new Recordset(qd._30_OpenRecordset(type, options));
		}

		public void Cancel()
		{
			qd.Cancel();
		}

		public void Close()
		{
			qd.Close();
		}

		public void Compare(QueryDef _qd, ref short lps)
		{
			qd.Compare(_qd.qd, ref lps);
		}

		public QueryDef _Copy()
		{
			return new QueryDef(qd._Copy());
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset CreateDynaset(RecordsetOption options, bool inconsistent)
		{
			return new Recordset(qd.CreateDynaset(options, inconsistent));
		}

		public Property CreateProperty()
		{
			return new Property(qd.CreateProperty(System.Type.Missing, System.Type.Missing,
				System.Type.Missing, System.Type.Missing));
		}

		public Property CreateProperty(string name)
		{
			return new Property(qd.CreateProperty(name, System.Type.Missing,
				System.Type.Missing, System.Type.Missing));
		}

		public Property CreateProperty(string name, DataType type)
		{
			return new Property(qd.CreateProperty(name, type,
				System.Type.Missing, System.Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val)
		{
			return new Property(qd.CreateProperty(name, type, val, System.Type.Missing));
		}

		public Property CreateProperty(string name, DataType type, object val, bool ddl)
		{
			return new Property(qd.CreateProperty(name, type, val, ddl));
		}

		[Obsolete("Use OpenRecordset instead.", false)]
		public Recordset CreateSnapshot(RecordsetOption options)
		{
			return new Recordset(qd.CreateSnapshot(options));
		}

		public void Execute()
		{
			qd.Execute(System.Type.Missing);
		}

		public void Execute(RecordsetOption options)
		{
			qd.Execute(options);
		}

		public Recordset ListParameters()
		{
			return new Recordset(qd.ListParameters());
		}

		public Recordset OpenRecordset()
		{
			return new Recordset(qd.OpenRecordset(System.Type.Missing, System.Type.Missing, System.Type.Missing));
		}
		
		public Recordset OpenRecordset(RecordsetType type)
		{
			return new Recordset(qd.OpenRecordset(type, System.Type.Missing, System.Type.Missing));
		}
		
		public Recordset OpenRecordset(RecordsetType type, RecordsetOption options)
		{
			return new Recordset(qd.OpenRecordset(type, options, System.Type.Missing));
		}
		
		public Recordset OpenRecordset(RecordsetType type, RecordsetOption options, LockType lockedits)
		{
			return new Recordset(qd.OpenRecordset(type, options, lockedits));
		}

		public Recordset _OpenRecordset()
		{
			return new Recordset(qd._OpenRecordset(System.Type.Missing, System.Type.Missing, System.Type.Missing));
		}
		
		public Recordset _OpenRecordset(RecordsetType type)
		{
			return new Recordset(qd._OpenRecordset(type, System.Type.Missing, System.Type.Missing));
		}
		
		public Recordset _OpenRecordset(RecordsetType type, RecordsetOption options)
		{
			return new Recordset(qd._OpenRecordset(type, options, System.Type.Missing));
		}
		
		public Recordset _OpenRecordset(RecordsetType type, RecordsetOption options, LockType lockedits)
		{
			return new Recordset(qd._OpenRecordset(type, options, lockedits));
		}

		public int CacheSize
		{
			get { return qd.CacheSize; }
			set { qd.CacheSize=value; }
		}

		public string Connect
		{
			get { return qd.Connect; }
			set { qd.Connect=value; }
		}

		public DateTime DateCreated
		{
			get { return (DateTime)qd.DateCreated; }
		}

		public Fields Fields
		{
			get { return new Fields(qd.Fields); }
		}

		public int hStmt
		{
			get { return qd.hStmt; }
		}

		public DateTime LastUpdated
		{
			get { return (DateTime)qd.LastUpdated; }
		}

		public int MaxRecords
		{
			get { return qd.MaxRecords; }
			set { qd.MaxRecords=value; }
		}

		public string Name
		{
			get { return qd.Name; }
			set { qd.Name=value; }
		}

		public short ODBCTimeout
		{
			get { return qd.ODBCTimeout; }
			set { qd.ODBCTimeout=value; }
		}

		public ParametersNS.Parameters Parameters
		{
			get { return new ParametersNS.Parameters(qd.Parameters); }
		}

		public QueryDefState Prepare
		{
			get { return (QueryDefState)qd.Prepare; }
			set { qd.Prepare=value; }
		}

		public Properties Properties
		{
			get { return new Properties(qd.Properties); }
		}

		public int RecordsAffected
		{
			get { return qd.RecordsAffected; }
		}

		public bool ReturnsRecords
		{
			get { return qd.ReturnsRecords; }
			set { qd.ReturnsRecords=value; }
		}

		public string SQL
		{
			get { return qd.SQL; }
			set { qd.SQL=value; }
		}

		public bool StillExecuting
		{
			get { return qd.StillExecuting; }
		}

		public QueryDefType Type
		{
			get { return (QueryDefType)qd.Type; }
		}

		public bool Updatable
		{
			get { return qd.Updatable; }
		}
	}

	class QueryDefsEnumerator : System.Collections.IEnumerator
	{
		internal System.Collections.IEnumerator Enmtr;
		public QueryDefsEnumerator(System.Collections.IEnumerator _Enmtr) { Enmtr=_Enmtr; }
		public void Reset() { Enmtr.Reset(); }
		public bool MoveNext() { return Enmtr.MoveNext(); }
		public object Current { get{ return new QueryDef((DAO.QueryDef)Enmtr.Current); } }
	}

	public class QueryDefs
	{
		internal DAO.QueryDefs qds;

		public QueryDefs(DAO.QueryDefs _qds)
		{
			qds=_qds;
		}

		public short Count
		{
			get { return qds.Count; }
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return new QueryDefsEnumerator(qds.GetEnumerator());
		}

		public void Refresh()
		{
			qds.Refresh();
		}

		public void Append(QueryDef qd)
		{
			qds.Append(qd.qd);
		}

		public void Delete(string name)
		{
			qds.Delete(name);
		}

		public QueryDef this[string index]
		{
			get { return new QueryDef(qds[index]); }
		}

		public QueryDef this[int index]
		{
			get { return new QueryDef(qds[index]); }
		}
	}
}
